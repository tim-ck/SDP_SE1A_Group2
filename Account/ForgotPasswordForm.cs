using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Account
{
    public partial class ForgotPasswordForm : Form
    {
        LoginPage opener;
        public ForgotPasswordForm(LoginPage parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        //Border BAr control start
        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        //Border BAr control End


        //drag form start
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ForgotPasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //drag form END


        //input textbox UI Start
        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
                txtEmail.Clear(); ;
            pictureBox2.Image = Properties.Resources.email_S;
            label1.BackColor = Color.FromArgb(230, 126, 34);
            txtEmail.ForeColor = Color.FromArgb(230, 126, 34);
        }

        private void rdoT_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.email_P;
            label1.BackColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }
        //input textbox UI END


        //Send Email Control START
        private void btnSendemail_Click(object sender, EventArgs e)
        {
            String userEmail = txtEmail.Text;
            String email = "tim.ck.project.email@gmail.com";
            var mailMessage = new MailMessage { };
            var smtpClinet = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(email, "Abc123698745"),
                EnableSsl = true,
            };

            //UI
            pictureBox2.Image = Properties.Resources.email_P;
            label1.BackColor = Color.White;
            txtEmail.ForeColor = Color.White;
            

            //send email
            if (userEmail == "")
            {
                txtErrMsg.Text = "Enter your Email";
                return;
            }
            if (rdoC.Checked)
            {
                if (opener.CustomerEmailVerify(userEmail))
                {
                    mailMessage = new MailMessage
                    {
                        From = new MailAddress(email),
                        Subject = "Customer testing",
                        Body = "<h1>The Hong Kong Cube Shop</h1>" +
                    "<h2>Password Recovery</h2>" +
                    "<p>Below is your account username and password:</p>" +
                    " <p >Username :...</p>" +
                    "<p >Passowrd :...</p>",
                        IsBodyHtml = true,
                    };
                }
                else
                {
                    txtErrMsg.Text = "Incorrect Email";
                    return;
                }
                 
            }else if(rdoT.Checked){
                if (opener.TenantEmailVerify(userEmail))
                {
                    mailMessage = new MailMessage
                    {
                        From = new MailAddress(email),
                        Subject = "Tenant testing",
                        Body = "<h1>The Hong Kong Cube Shop</h1>" +
                    "<h2>Password Recovery</h2>" +
                    "<p>Below is your account username and password:</p>" +
                    " <p >Username :...</p>" +
                    "<p >Passowrd :...</p>",
                        IsBodyHtml = true,
                    };
                }
                else
                {
                    txtErrMsg.Text = "Incorrect Email";
                    return;
                }
            }
            else if (rdoS.Checked)
            {
                if (opener.StaffEmailVerify(userEmail))
                {
                    mailMessage = new MailMessage
                    {
                        From = new MailAddress(email),
                        Subject = "Customer testing",
                        Body = "<h1>The Hong Kong Cube Shop</h1>" +
                    "<h2>Password Recovery</h2>" +
                    "<p>Below is your account username and password:</p>" +
                    " <p >Username :...</p>" +
                    "<p >Passowrd :...</p>",
                        IsBodyHtml = true,
                    };
                }
                else
                {
                    txtErrMsg.Text = "Incorrect Email";
                    return;
                }
            }
            else
            {
                txtErrMsg.Text = "Choose your account type";
                return;
            }

            mailMessage.To.Add(userEmail);
            smtpClinet.Send(mailMessage);
            txtErrMsg.Text = "Email was sent successfully. Didn't recieve?";
            btnSendemail.Text = "Send Again";

        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            opener.Show();
            this.Close();
        }
     
        //Send Email Control END



    }
}
