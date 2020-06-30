
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

namespace SDP_SE1A_Group2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        

//drag form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (username == ""|| username == "Username")
            {
                label1.BackColor = Color.Red;
                txtErrMsg.Text = "Enter a Username";

                return;
            }
                TenantVerify(username, password);
        }

//verify start
        

        public void TenantVerify(String username, String password)
        {
            Boolean Verify = false;
            using (var db = new sdpEntities())
            {
                var userAcct = from list in db.tenant
                               where list.tenantID.Equals(username)
                               select new { list.tenantID, list.tenantpwd, list.tenantName };
                if (userAcct == null)
                {
                    txtErrMsg.Text = "The Username / Password is incorrect";
                }
                else
                {
                    foreach (var user in userAcct.ToList())
                    {
                        if ((username == user.tenantID.ToString()) && (password == user.tenantpwd.ToString()))
                        {
                            Verify = true;
                            this.Hide();
                            txtUsername.Text = "Username";
                            txtPassword.Text = "Password";
                            TenantMain tenantMain = new TenantMain(user.tenantID, user.tenantName);
                            tenantMain.Show();
                            return;
                        }
                    }
                }
                if (Verify == false)
                {
                    label2.BackColor = Color.Red;
                    label1.BackColor = Color.Red;
                    txtErrMsg.Text = "The Username / Password is incorrect";
                    return;
                }

            }

        }

       

//username verify
        public String[] GetCustomerEmail(String username)
        {
            
            using (var db = new sdpEntities())
            {
                var e = from list in db.customer
                               where list.customerID.Equals(username)
                               select new { list.customerID, list.email,list.customerpwd };
                if (e == null) {  return null; } else
                {
                    foreach (var user in e.ToList())
                    {
                        String[] act = { user.email.ToString(), user.customerpwd.ToString() };
                        return act;
                    }
                }

                return null;
            }
            
            

        }
        public String[] GetTenatEmail(String username)
        {

            using (var db = new sdpEntities())
            {
                var e = from list in db.tenant
                        where list.tenantID.Equals(username)
                        select new { list.tenantID, list.email, list.tenantpwd };
                if (e == null) { return null; }
                else
                {
                    foreach (var user in e.ToList())
                    {
                        String[] act = { user.email.ToString(), user.tenantpwd.ToString() };
                        return act;
                    }
                }

                return null;
            }


        }


//username verify ENd

//verify ENd




//UI START
        private void txtUsername_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text== "Username")
                txtUsername.Clear();
            pictureBox2.Image = Properties.Resources.user_blue;
            label1.BackColor = Color.FromArgb(110, 200, 255);
            txtUsername.ForeColor = Color.FromArgb(110, 200, 255);


            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            label2.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            pictureBox3.Image = Properties.Resources.lock_blue;
            label2.BackColor = Color.FromArgb(110, 200, 255);
            txtPassword.ForeColor = Color.FromArgb(110, 200, 255);


            pictureBox2.Image = Properties.Resources.user;
            label1.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
        }

        
        //UI END


    }
}
