﻿using SDP_SE1A_Group2.Account;
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
        //Titile Bar control start
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

        //Title Bar control END

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (username == "")
            {
                txtErrMsg.Text = "Enter a Username";
                return;
            }
            if (password == "")
            {
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
            /*Boolean Verify = false;
            using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var userAcct =  from list in notSoImportantVariable.Customer
                                where list.CustomerID.Equals(username)
                                select new { list.CustomerID, list.Password };
                if(userAcct==null){
            txtErrMsg.Text = "The Username / Password is incorrect";            }else{
                foreach (var user in userAcct.ToList())
                {
                    if ((username == user.CustomerID.ToString()) && (password == user.Password.ToString()))
                    {
                        Verify = true;
                        this.Hide();
                        Customer.CustomerMain cus = new Customer.CustomerMain(username); //!!!!!!!!!!!!!!!!!!!!!
                        cus.Show();
                        return;
                    }
                }
            }
            if(Verify == false)
                txtErrMsg.Text = "The Username / Password is incorrect";
            else{*/
            this.Hide();
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            CustomerMain cus = new CustomerMain(this, username); 
            cus.Show();

            //}}

        }

        public void TenantVerify(String username, String password)
        {
            /*Boolean Verify = false;
            using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var userAcct =  from list in notSoImportantVariable.Customer
                                where list.TenantID.Equals(username)
                                select new { list.TenantID, list.Password };
                if(userAcct==null){
                    txtErrMsg.Text = "The Username / Password is incorrect";            }
                else{
                foreach (var user in userAcct.ToList())
                {
                    if ((username == user.CustomerID.ToString()) && (password == user.Password.ToString()))
                    {
                        Verify = true;
                        this.Hide();
                        Customer.CustomerMain cus = new Customer.CustomerMain(username); //!!!!!!!!!!!!!!!!!!!!!
                        cus.Show();
                        return;
                    }
                }
            }
            if(Verify == false)
                txtErrMsg.Text = "The Username / Password is incorrect";
            else{*/
            this.Hide();
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            CustomerMain cus = new CustomerMain(this, username);
            cus.Show();

            //}}

        }

        public void StaffVerify(String username, String password)
        {
            /*
            Boolean Verify = false;
            using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var userAcct = from list in notSoImportantVariable.Staff
                                where list.StaffID.Equals(username)
                               select new { list.StaffID, list.Password };
                if(userAcct==null){
                    txtErrMsg.Text = "The Username / Password is incorrect";            
                }
                else{

                foreach (var user in userAcct.ToList())
                {
                    if ((username == user.StaffID.ToString()) && (password == user.Password.ToString()))
                    {
                        Verify = true;
                        this.Hide();
                        Staff s = new Staff(); //!!!!!!!!!!!!!!!!!!
                        s.Show();
                        return;
                    }
                }
            }

            if (Verify == false)
                txtErrMsg.Text = "The Username / Password is incorrect";

            else
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            */


        }

        public Boolean CustomerEmailVerify(String email)
        {
            /*Boolean verify = false;
            using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var e = from list in notSoImportantVariable.Customer
                               where list.Email.Equals(email)
                               select new { list.Email };
                if (e == null) { return false; }

                foreach (var user in email.ToList())
                {
                    if (email == user.email.ToString())
                    {
                        verify = true;

                        return verify;
                    }
                }
            }
            return verify;*/
            return true;//plz delete this when added sql

        }
        public Boolean TenantEmailVerify(String email)
        {
            /*Boolean verify = false;
            using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var e = from list in notSoImportantVariable.Tenant
                               where list.Email.Equals(email)
                               select new { list.Email };
                if (e == null) { return false; }

                foreach (var user in email.ToList())
                {
                    if (email == user.email.ToString())
                    {
                        verify = true;

                        return verify;
                    }
                }
            }
            return verify;*/
            return true;//plz delete this when added sql

        }

        public Boolean StaffEmailVerify(String email)
        {
            /*Boolean verify = false;
            using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var e = from list in notSoImportantVariable.Staff
                               where list.Email.Equals(email)
                               select new { list.Email };
                if (e == null) { return false; }

                foreach (var user in email.ToList())
                {
                    if (email == user.email.ToString())
                    {
                        verify = true;

                        return verify;
                    }
                }
            }
            return verify;*/
            return true;//plz delete this when added sql

        }

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

       




        //UI END


    }
}
