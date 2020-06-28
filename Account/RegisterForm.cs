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

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
                txtFirstName.Clear();
            lblFname.BackColor = Color.FromArgb(110, 200, 255);
            txtFirstName.ForeColor = Color.FromArgb(110, 200, 255);

            txtLastName.ForeColor = Color.White;
            lblLname.BackColor = Color.White;

            txtPhoneNumber.ForeColor = Color.White;
            lblPhone.BackColor = Color.White;

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
            pictureBox4.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblCPWD.BackColor = Color.White;
            txtCPwd.ForeColor = Color.White;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            if (txtLastName.Text == "Last Name")
                txtLastName.Clear();
            txtLastName.ForeColor = Color.FromArgb(110, 200, 255);
            lblLname.BackColor = Color.FromArgb(110, 200, 255);

            txtPhoneNumber.ForeColor = Color.White;
            lblPhone.BackColor = Color.White;

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
            pictureBox4.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblCPWD.BackColor = Color.White;
            txtCPwd.ForeColor = Color.White;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            txtLastName.ForeColor = Color.White;
            lblLname.BackColor = Color.White;

            if (txtPhoneNumber.Text == "Phone Numebr")
                txtPhoneNumber.Clear();
            txtPhoneNumber.ForeColor = Color.FromArgb(110, 200, 255);
            lblPhone.BackColor = Color.FromArgb(110, 200, 255);

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
            pictureBox4.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblCPWD.BackColor = Color.White;
            txtCPwd.ForeColor = Color.White;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            txtLastName.ForeColor = Color.White;
            lblLname.BackColor = Color.White;

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
            pictureBox4.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblCPWD.BackColor = Color.White;
            txtCPwd.ForeColor = Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            txtLastName.ForeColor = Color.White;
            lblLname.BackColor = Color.White;

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
            pictureBox4.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblCPWD.BackColor = Color.White;
            txtCPwd.ForeColor = Color.White;
        }

        private void txtCPwd_TextChanged(object sender, EventArgs e)
        {
           
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            txtLastName.ForeColor = Color.White;
            lblLname.BackColor = Color.White;

            txtPhoneNumber.ForeColor = Color.White;
            lblPhone.BackColor = Color.White;

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;

            if (txtCPwd.Text == "Comfirm Password")
                txtCPwd.Clear();
            txtCPwd.PasswordChar = '*';
            pictureBox4.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblCPWD.BackColor = Color.FromArgb(110, 200, 255);
            txtCPwd.ForeColor = Color.FromArgb(110, 200, 255);
        }

        private void btnBacktoSignInPage_Click(object sender, EventArgs e)
        {
            opener.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successgully registered");
            using (var context = new classicmodelsEntities())
            {
                var act = new
            }
        }
    }
}
