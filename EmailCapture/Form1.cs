using System.Net;
using System.Net.Mail;

namespace EmailCapture
{
    public partial class Form1 : Form
    {
        private SmtpClient? _smtp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

    }
}