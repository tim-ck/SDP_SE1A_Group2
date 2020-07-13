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
    public partial class editStaffInfo : Form
    {
        String userID, user, userName, userEmail;



        Staff_main opener;
        public editStaffInfo(Staff_main opener, String userID)
        {
            InitializeComponent();
            this.userID = userID;
            txtUsername.Text = userID;
            this.opener = opener;
            updateTextBox();
        }

        private void updateTextBox()
        {
            using (var db = new sdpEntities())
            {
                var userAcct = from list in db.staff
                               where list.staffID.Equals(userID)
                               select list;
                foreach (var user in userAcct.ToList())
                {
                    txtEmail.Text = user.email;
                    txtFirstName.Text = user.name;
                    if (user.staffType == "p")
                    {
                        rdoP.Checked = true;
                        txtSalaryType.Text = "/hr";

                    }
                    if (user.staffType == "f")
                    {
                        rdoF.Checked = true;
                        txtSalaryType.Text = "/month";

                    }
                    txtSalary.Text = user.salary.ToString();
                }


            }
            userEmail = txtEmail.Text;
            userName = txtFirstName.Text;
            
        }


        private void btnComfirm_Click_1(object sender, EventArgs e)
        {

            try { var addr = new System.Net.Mail.MailAddress(txtEmail.Text); }
            catch { txtErrMsg.Text = "invalid Email Address"; label11.BackColor = Color.Red; return; }
           

            if (txtPassword.TextLength < 6 || txtPassword.TextLength > 20) { txtErrMsg.Text = " Password should not less than 6 charater and not more than 20 charater"; lblPwd.BackColor = Color.Red; return; }
            try
            {
                /*var orderde = db.showcaseitems.SingleOrDefault(a => a.itemid == itemid);
                if (orderde != null)
                {
                    orderde.availableQty -= int.Parse(quantity);
                    orderde.soldQty += int.Parse(quantity);
                    db.SaveChanges();
                }*/
                using (var db = new sdpEntities())
                {
                    var acct = db.staff.SingleOrDefault(a => a.staffID == userID);
                    if (acct != null)
                    {
                        if (txtPassword.Text != "Password" && txtPassword.Text != "")
                            acct.staffPwd = txtPassword.Text;
                        if (txtFirstName.Text != userName && txtFirstName.Text != "")
                            acct.name = txtFirstName.Text;
                        if (txtEmail.Text != userEmail && txtEmail.Text != "")
                            acct.email = txtEmail.Text;
                        acct.salary=float.Parse(txtSalary.Text);
                        db.SaveChanges();
                    };


                }
            }
            catch
            {
                txtErrMsg.Text = "SQL err";
                return;
            }
            MessageBox.Show("Successgully Update");
            opener.closeForm();
        }

        private void txtFirstName_Click_1(object sender, EventArgs e)
        {
            if (txtFirstName.Text == userName)
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
            
            txtSalary.ForeColor= Color.White;
            label5.BackColor = Color.White;
        }

        private void txtSalary_Click(object sender, EventArgs e)
        {
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

            txtSalary.ForeColor = Color.FromArgb(110, 200, 255);
            label5.BackColor = Color.FromArgb(110, 200, 255);
        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Your Account Will Be Delete Permanently. ", "Warnning", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                using (var db = new sdpEntities())
                {
                    var acct = db.staff.SingleOrDefault(a => a.staffID == userID);
                    var a = db.staff.Remove(acct);
                    db.SaveChanges();
                    if(a!=null)
                         MessageBox.Show("account Permanently removed. ");
                    opener.logout();

                }
            }
        }

        private void rdoP_Click(object sender, EventArgs e)
        {
            if (rdoF.Checked)
            {
                txtSalary.Text = "12000";
                txtSalaryType.Text = "/ month";
                
            }
            else if (rdoP.Checked)
            {
                txtSalary.Text = "50";
                txtSalaryType.Text = "/ hr";
                

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



        private void txtEmail_Click_1(object sender, EventArgs e)
        {
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;



            if (txtEmail.Text == userEmail)
                txtEmail.Clear();
            txtEmail.ForeColor = Color.FromArgb(110, 200, 255);
            label11.BackColor = Color.FromArgb(110, 200, 255);

            pictureBox2.Image = Properties.Resources.user;
            lbluserName.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
            pictureBox3.Image = Properties.Resources.iconmonstr_lock_3_240;
            lblPwd.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
           

            txtSalary.ForeColor = Color.White;
            label5.BackColor = Color.White;
        }

        private void txtPassword_Click_1(object sender, EventArgs e)
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
           

            txtSalary.ForeColor = Color.White;
            label5.BackColor = Color.White;
        }
    }
}
