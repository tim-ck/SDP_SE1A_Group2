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
            if (txtusername.Text == "Username")
                txtusername.Clear(); ;
            pictureBox2.Image = Properties.Resources.user_blue;
            label1.BackColor = Color.FromArgb(110, 200, 255);
            txtusername.ForeColor = Color.FromArgb(110, 200, 255);
        }

        private void rdoT_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.user;
            label1.BackColor = Color.White;
            txtusername.ForeColor = Color.White;
        }
        //input textbox UI END


        //Send Email Control START
        private void btnSendemail_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String email = "tim.ck.project.email@gmail.com";
            String[] acctDetail = new String[2];
            var mailMessage = new MailMessage { };
            var smtpClinet = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(email, "Abc123698745"),
                EnableSsl = true,
            };

            //UI
            pictureBox2.Image = Properties.Resources.user;
            label1.BackColor = Color.White;
            txtusername.ForeColor = Color.White;
            if (username == "" || username == "UserName")
            {
                label1.BackColor = Color.Red;
                txtErrMsg.Text = "Enter your UserName";
                return;
            }

           
            //get email and password
            if (rdoC.Checked){acctDetail = opener.GetCustomerEmail(username); }
            else  if (rdoT.Checked) { acctDetail = opener.GetTenatEmail(username); } 
            else if (rdoS.Checked) { acctDetail = opener.GetStaffEmail(username); }
            else
            {
                txtErrMsg.Text = "Choose your account type";
                return;
            }
            //send email
            if (acctDetail != null)
            {
                mailMessage = new MailMessage
                {
                    From = new MailAddress(email),
                    Subject = "Password Recovery - The Hong Kong Cube Shop",
                    Body = "<h1>The Hong Kong Cube Shop</h1>" +
                            "<h2>Password Recovery</h2>" +
                            "<p>Below is your account username and password:</p>" +
                            " <p >Username :" + username +
                            "<p >Passowrd :" + acctDetail[1],
                    IsBodyHtml = true,
                };

            }
            else //error
            {
                txtErrMsg.Text = "Incorrect username";
                return;
            }

            mailMessage.To.Add(acctDetail[0]);
            smtpClinet.Send(mailMessage);
            txtErrMsg.Text = "Email was sent successfully. Didn't recieve?";
            btnSendemail.Text = "Send Again";
            
           
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            opener.Show();
            this.Close();
        }



        //Send Email Control END



    }
}
