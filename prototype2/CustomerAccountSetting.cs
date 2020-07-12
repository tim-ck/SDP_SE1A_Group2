using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Customer
{
    public partial class CustomerAccountSetting : Form
    {
        String customerID, cusEmail, cusName,cusPhone;
        CustomerMain opener;
        public CustomerAccountSetting(CustomerMain opener,String customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            txtUsername.Text = customerID;
            this.opener = opener;
            updateTextBox();
        }

        private void updateTextBox()
        {
            using (var db = new sdpEntities())
            {
                var userAcct = from list in db.customer
                               where list.customerID.Equals(customerID)
                               select list;
                foreach (var user in userAcct.ToList())
                {
                    txtEmail.Text = user.email;
                    txtFirstName.Text= user.customername;

                    txtPhoneNumber.Text = user.phone;

                }


            }
            cusEmail = txtEmail.Text;
            cusName = txtFirstName.Text;
            cusPhone = txtPhoneNumber.Text;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text == cusName)
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

        

        private void txtPassword_TextChanged(object sender, EventArgs e)
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

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Your Account Will Be Delete Permanently. ", "Warnning", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                using (var db = new sdpEntities())
                {
                    var acct = db.customer.SingleOrDefault(a => a.customerID == customerID);
                    db.customer.Remove(acct);
                    MessageBox.Show("account Permanently removed. ");
                    opener.logout();
                }
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;

            if (txtPhoneNumber.Text == cusPhone)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblFname.BackColor = Color.White;
            txtFirstName.ForeColor = Color.White;



            if (txtEmail.Text == cusEmail)
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

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            
            try { var addr = new System.Net.Mail.MailAddress(txtEmail.Text); }
            catch { txtErrMsg.Text = "invalid Email Address"; label11.BackColor = Color.Red; return; }
            if (txtPhoneNumber.TextLength != 8) { txtErrMsg.Text = "invalid Phone Number"; lblPhone.BackColor = Color.Red; return; }
            try { int no = int.Parse(txtPhoneNumber.Text); }
            catch { txtErrMsg.Text = "invalid Phone Number"; lblPhone.BackColor = Color.Red; return; }
            
            if (txtUsername.TextLength < 6 || txtUsername.TextLength > 20) { txtErrMsg.Text = " username should not less than 6 charater and not more than 20 charater"; lbluserName.BackColor = Color.Red; return; }
            
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
                    var acct = db.customer.SingleOrDefault(a => a.customerID == customerID);
                    if (acct != null)
                    {
                        if (txtPassword.Text != "Password" && txtPassword.Text != "")
                            acct.customerpwd = txtPassword.Text;
                        if (txtFirstName.Text != cusName && txtFirstName.Text != "")
                            acct.customername = txtFirstName.Text;
                        if (txtEmail.Text != cusEmail && txtEmail.Text != "")
                            acct.email = txtEmail.Text;
                        acct.phone = txtPhoneNumber.Text;
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
            opener.closeChildForm();
        }
    }
}
