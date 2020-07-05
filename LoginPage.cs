using SDP_SE1A_Group2.Account;
using SDP_SE1A_Group2.Customer;
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
        

//drag form Start
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
 //drag form End



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
            if (password == "" || password == "Password")
            {
                label2.BackColor = Color.Red;
                txtErrMsg.Text = "Enter a Password";
                return;
            }
            
            if (rdoCustomer.Checked)
            {
                CustomerVerify(username, password);

            }
            else if (rdoTenent.Checked)
            {
                TenantVerify(username, password);
            }
            else if (rdoStaff.Checked)
            {
                StaffVerify(username, password);
            }
            else
            {
                txtErrMsg.Text = "Choose your account type";
                return;
            }


        }

        //verify start
        public void CustomerVerify(String username, String password)
        {
            Boolean Verify = false;
            using (var db = new sdpEntities())
            {


                var userAcct = from list in db.customers
                               where list.customerID.Equals(username)
                               select new { list.customerID, list.customerpwd };
                if (userAcct == null)
                {
                    txtErrMsg.Text = "The Username / Password is incorrect";
                }
                else
                {
                     foreach (var user in userAcct.ToList())
                        {
                            if ((username == user.customerID.ToString()) && (password == user.customerpwd.ToString()))
                            {
                                Verify = true;
                                this.Hide();
                                txtUsername.Text = "Username";
                                txtPassword.Text = "Password";
                                CustomerMain cus = new CustomerMain(this, username);
                                cus.Show();
                                return;
                            }
                        }
                    if(Verify == false)
                    {

                        label2.BackColor = Color.Red;
                        label1.BackColor = Color.Red;
                        txtErrMsg.Text = "The Username / Password is incorrect";
                        return;
                    }


                }



            }
        }

        public void TenantVerify(String username, String password)
        {
            Boolean Verify = false;
            using (var db = new sdpEntities())
            {
                var userAcct = from list in db.tenants
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
                            TenantMain tenantMain = new TenantMain(this, user.tenantID, user.tenantName);
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

        public void StaffVerify(String username, String password)
        {
            Boolean Verify = false;
            using (var db = new sdpEntities())
            {


                var userAcct = from list in db.staffs
                               where list.staffID.Equals(username)
                               select new { list.staffID, list.staffPwd };
                if (userAcct == null)
                {
                    txtErrMsg.Text = "The Username / Password is incorrect";
                }
                else
                {
                    foreach (var user in userAcct.ToList())
                    {
                        if ((username == user.staffID.ToString()) && (password == user.staffPwd.ToString()))
                        {
                            Verify = true;
                            this.Hide();
                            txtUsername.Text = "Username";
                            txtPassword.Text = "Password";
                            Staff_main staffMain = new Staff_main(this);
                            staffMain.Show();
                            return;
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


        }

//username verify
        public String[] GetCustomerEmail(String username)
        {
            
            using (var db = new sdpEntities())
            {
                var e = from list in db.customers
                               where list.customerID.Equals(username)
                               select new { list.customerID, list.email,list.customerpwd };
                if (e == null) {  return null; } else
                {
                    foreach (var user in e.ToList())
                    {
                        String[] act = { user.email.ToString(), user.customerpwd.ToString() };
                        return act;
                    }
                }return null;
            }
            
            

        }
        public String[] GetTenatEmail(String username)
        {

            using (var db = new sdpEntities())
            {
                var e = from list in db.tenants
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

        public String[] GetStaffEmail(String username)
        {

            using (var db = new sdpEntities())
            {
                var e = from list in db.staffs
                        where list.staffID.Equals(username)
                        select new { list.staffID, list.email, list.staffPwd };
                if (e == null) { return null; }
                else
                {
                    foreach (var user in e.ToList())
                    {
                        String[] act = { user.email.ToString(), user.staffPwd.ToString() };
                        return act;
                    }




                }

                return null;
            }


        }
//username verify ENd

//verify ENd


        public void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgot = new ForgotPasswordForm(this);
            forgot.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm(this);
            register.Show();
        }

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

        private void rdoStaff_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.user;
            label1.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;

            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            label2.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
        }




        //UI END


    }
}
