using Microsoft.Extensions.Configuration;

namespace CybBezWireshark
{
    public partial class Form1 : Form
    {
        private readonly IConfiguration config;

        public Form1(IConfiguration config)
        {
            InitializeComponent();
            this.config = config;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}