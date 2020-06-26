using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Account
{
    public partial class ForgotPasswordForm : Form
    {
        Form opener;
        public ForgotPasswordForm(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email = "tim.ck.project.email@gmail.com";
            var smtpClinet = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("tim.ck.project.email@gmail.com", "Abc123698745"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(email),
                Subject = "testing",
                Body = "<h1>Your pwd is...</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add("tim.ckchow@gmail.com");
            smtpClinet.Send(mailMessage);
        }
    }
}
