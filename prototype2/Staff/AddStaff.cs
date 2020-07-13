using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Staff
{
    public partial class AddStaff : Form
    {
        private String staffType = "p";
        public AddStaff()
        {
            InitializeComponent();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            object staff;
            if (txtFirstName.Text == "Your full Name" || txtFirstName.Text == "") { txtErrMsg.Text = "Enter Your full Name"; lblFname.BackColor = Color.Red; return; }
            if (txtEmail.Text == "Email(abc@example.com)" || txtEmail.Text == "") { txtErrMsg.Text = "Enter Email"; label11.BackColor = Color.Red; return; }
            try { var addr = new System.Net.Mail.MailAddress(txtEmail.Text); }
            catch { txtErrMsg.Text = "invalid Email Address"; label11.BackColor = Color.Red; return; }
            if (txtUsername.Text == "StaffID" || txtUsername.Text == "") { txtErrMsg.Text = "Enter username(StaffID)"; lbluserName.BackColor = Color.Red; return; }
            if (txtUsername.TextLength < 6 || txtUsername.TextLength > 20) { txtErrMsg.Text = " username should not less than 6 charater and not more than 20 charater"; lbluserName.BackColor = Color.Red; return; }
            if (txtPassword.Text == "Password" || txtPassword.Text == "") { txtErrMsg.Text = "Enter Password"; lblPwd.BackColor = Color.Red; return; }
            if (txtPassword.TextLength < 6 || txtPassword.TextLength > 20) { txtErrMsg.Text = " Password should not less than 6 charater and not more than 20 charater"; lblPwd.BackColor = Color.Red; return; }
            try
            {
                using (var db = new sdpEntities())
                {
                    var acct = new staff()
                    {
                        staffID = txtUsername.Text,
                        staffPwd = txtPassword.Text,
                        email = txtEmail.Text,
                        name = txtFirstName.Text,
                        staffType = this.staffType,
                        salary = float.Parse(txtSalary.Text)

                    };
                    db.staff.Add(acct);
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
            
        }

        private void rdoF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoF.Checked)
            {
                txtSalary.Text = "12000";
                txtSalaryType.Text = "/ month";
                staffType = "f";
            }
            else if (rdoP.Checked)
            {
                txtSalary.Text = "50";
                txtSalaryType.Text = "/ hr";
                staffType = "p";

            }
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;
            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;

            txtEmail.ForeColor = Color.White;
            label11.BackColor = Color.White;

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "Your full Name")
                txtFirstName.Clear();
            lblFname.BackColor = Color.FromArgb(110, 200, 255);
            txtFirstName.ForeColor = Color.FromArgb(110, 200, 255);

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

          
            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            if (txtUsername.Text == "StaffID")
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

        
    }
       
    
}
                
    

