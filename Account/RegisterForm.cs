using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * line 185: not yet addded tenant and staff register
 
     */
namespace SDP_SE1A_Group2.Account
{
    public partial class RegisterForm : Form
    {
        LoginPage opener;
        public RegisterForm(LoginPage parentForm)
        {

            InitializeComponent();
            opener = parentForm;
        }

//Border BAr control start
        private void lblCloseButton_Click_1(object sender, EventArgs e)
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

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
//drag form END

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "Your full Name")
                txtFirstName.Clear();
            lblFname.BackColor = Color.FromArgb(110, 200, 255);
            txtFirstName.ForeColor = Color.FromArgb(110, 200, 255);


            txtPhoneNumber.ForeColor = Color.White;
            lblPhone.BackColor = Color.White;

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
           
            txtEmail.ForeColor = Color.White;
            label11.BackColor = Color.White;
        }


        private void txtEmail_Click(object sender, EventArgs e)
        {
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

           

            if (txtEmail.Text == "Email(abc@example.com)")
                txtEmail.Clear();
            txtEmail.ForeColor = Color.FromArgb(110, 200, 255);
            label11.BackColor = Color.FromArgb(110, 200, 255);

            txtPhoneNumber.ForeColor = Color.White;
            lblPhone.BackColor = Color.White;

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
          
        }
        private void txtPhoneNumber_Click(object sender, EventArgs e)
        {
            
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            if (txtPhoneNumber.Text == "Phone Numebr(8-digit number)")
                txtPhoneNumber.Clear();
            txtPhoneNumber.ForeColor = Color.FromArgb(110, 200, 255);
            lblPhone.BackColor = Color.FromArgb(110, 200, 255);

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
           
            txtEmail.ForeColor = Color.White;
            label11.BackColor = Color.White;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            txtPhoneNumber.ForeColor = Color.White;
            lblPhone.BackColor = Color.White;

            if (txtUsername.Text == "Username")
                txtUsername.Clear();
            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.FromArgb(110, 200, 255);
            txtUsername.ForeColor = Color.FromArgb(110, 200, 255);
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
           
            txtEmail.ForeColor = Color.White;
            label11.BackColor = Color.White;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            txtPhoneNumber.ForeColor = Color.White;
            lblPhone.BackColor = Color.White;

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;

            if (txtPassword.Text == "Password")
                txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.FromArgb(110, 200, 255);
            txtPassword.ForeColor = Color.FromArgb(110, 200, 255);
           
            txtEmail.ForeColor = Color.White;
            label11.BackColor = Color.White;
        }

        

        private void btnBacktoSignInPage_Click(object sender, EventArgs e)
        {
            opener.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            object customer;
            if (txtFirstName.Text == "Your full Name" || txtFirstName.Text == "") { txtErrMsg.Text = "Enter Your full Name"; lblFname.BackColor = Color.Red; return; }
            if (txtEmail.Text == "Email(abc@example.com)" || txtEmail.Text == "") { txtErrMsg.Text = "Enter Email"; label11.BackColor = Color.Red; return; }
            try{ var addr = new System.Net.Mail.MailAddress(txtEmail.Text);}
            catch{ txtErrMsg.Text = "invalid Email Address"; label11.BackColor = Color.Red; return; }
            if (txtPhoneNumber.TextLength != 8) { txtErrMsg.Text = "invalid Phone Number"; lblPhone.BackColor = Color.Red; return; }
            try { int no = int.Parse(txtPhoneNumber.Text); }
            catch { txtErrMsg.Text = "invalid Phone Number"; lblPhone.BackColor = Color.Red; return; }
            if(txtUsername.Text=="Username" || txtUsername.Text == "") { txtErrMsg.Text = "Enter username"; lbluserName.BackColor = Color.Red; return; }
            if (txtUsername.TextLength < 6 || txtUsername.TextLength > 20) { txtErrMsg.Text = " username should not less than 6 charater and not more than 20 charater"; lbluserName.BackColor = Color.Red; return; }
            if (txtPassword.Text == "Password" || txtPassword.Text == "") { txtErrMsg.Text = "Enter Password"; lblPwd.BackColor = Color.Red; return; }
            if (txtPassword.TextLength<6 || txtPassword.TextLength > 20) { txtErrMsg.Text = " Password should not less than 6 charater and not more than 20 charater"; lblPwd.BackColor = Color.Red; return; }
            if (rdoC.Checked) {
                try
                {
                    using (var db = new sdpEntities())
                    {
                        var acct = new customer()
                        {
                            customerID = txtUsername.Text,
                            customerpwd = txtPassword.Text,
                            customername = txtFirstName.Text,
                            email = txtEmail.Text,
                            phone = txtPhoneNumber.Text
                        };
                        db.customers.Add(acct);
                        db.SaveChanges();
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    txtErrMsg.Text = "username used";
                    return;
                }
                catch
                {
                    txtErrMsg.Text = "SQL err";
                    return;
                }
                MessageBox.Show("Successgully registered");
                this.Close();
                opener.Show();
            }
            else if (rdoT.Checked) { 
                try
                {
                    using (var db = new sdpEntities())
                    {
                        var acct = new tenant()
                        {
                            tenantID = txtUsername.Text,
                            tenantpwd = txtPassword.Text,
                            tenantName = txtFirstName.Text,
                            email = txtEmail.Text,
                            phone = txtPhoneNumber.Text
                        };
                        db.tenants.Add(acct);
                        db.SaveChanges();
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    txtErrMsg.Text = "username used";
                    return;
                }
                catch
                {
                    txtErrMsg.Text = "SQL err";
                    return;
                }
                MessageBox.Show("Successgully registered");
                this.Close();
                opener.Show();
            }
            
            else
            {
                txtErrMsg.Text = "Choose a account type";
                return;
            }
            
            
        }



        //

        /*
         * txtErrMsg.Text
         txtFirstName
         
         txtEmail
         txtPhoneNumber
         txtUsername
         txtPassword
         txtCPwd
         */
        }
    }
