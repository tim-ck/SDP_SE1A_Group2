using System;
using System.Collections;
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
    public partial class CustomerMain : Form
    {
        Form opener;
        private Form activeForm = null;
        private String userId, cusName;
        private Stack item = new Stack(); // store all item user added
        private Stack orderInfo = new Stack(); //store all order id froom DBS
        private int orderId; // store this order ID

        public CustomerMain(Form parentForm, String userId)
        {
            InitializeComponent();
            opener = parentForm;
            this.userId = userId;
            orderInfo.Push("0000");
            /* using (var notSoImportantVariable = new classicmodelsEntities())
             {
                var userAcct = from list in notSoImportantVariable.Customer
                                where list.CustomerID.Equals(userId)
                                select list;
                foreach (var user in userAcct.ToList())
                 {
                     cusName = user.CustomerName;
                 }

                var order = from list in notSoImportantVariable.Oder
                                  select list;
                foreach (var l in order.ToList())
                 {
                     orderInfo.Push(l.orderfID);
                 }

             }*/
            cusName = userId;//test case: customer name and customer id is same. real code in comment above!
            lblTitle.Text= "Welcome Customer " + cusName + " !";
            orderId = Convert.ToInt32(orderInfo.Peek())+1;


        }

        public Boolean cartHvItem() { return item.Count != 0; }
        public void updateItem(Stack item) { this.item = item; }
        private void openChildForm(Form childForm)
        {
            if (activeForm!= null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            panelChildForm.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnBrowseItemPage_Click(object sender, EventArgs e)
        {
            
            BrowseItems browseItemForm = new BrowseItems();
            openChildForm(browseItemForm);
            btnProduct.Image = Properties.Resources.item_P;
            btnProduct.ForeColor = Color.FromArgb(182, 182, 182);
            btnOrder.Image = Properties.Resources.order_p;
            btnOrder.ForeColor = Color.FromArgb(182, 182, 182);
            btnCart.Image = Properties.Resources.cart_P
            btnCart.ForeColor = Color.FromArgb(182, 182, 182);
            btnSetting.Image = Properties.Resources
            btnSetting.ForeColor = Color.FromArgb(182, 182, 182);


        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            BrowseItems browseItemForm = new BrowseItems();
            openChildForm(browseItemForm);
            btnProduct.Image = Properties.Resources
            btnProduct.ForeColor = Color.FromArgb(182, 182, 182);
            btnOrder.Image = Properties.Resources
            btnOrder.ForeColor = Color.FromArgb(182, 182, 182);
            btnCart.Image = Properties.Resources
            btnCart.ForeColor = Color.FromArgb(182, 182, 182);
            btnSetting.Image = Properties.Resources
            btnSetting.ForeColor = Color.FromArgb(182, 182, 182);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartPage browseItemForm = new CartPage(orderId, item);
            openChildForm(browseItemForm);
            btnProduct.Image = Properties.Resources
            btnProduct.ForeColor = Color.FromArgb(182, 182, 182);
            btnOrder.Image = Properties.Resources
            btnOrder.ForeColor = Color.FromArgb(182, 182, 182);
            btnCart.Image = Properties.Resources
            btnCart.ForeColor = Color.FromArgb(182, 182, 182);
            btnSetting.Image = Properties.Resources
            btnSetting.ForeColor = Color.FromArgb(182, 182, 182);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            BrowseItems browseItemForm = new BrowseItems();
            openChildForm(browseItemForm);
            btnProduct.Image = Properties.Resources
            btnProduct.ForeColor = Color.FromArgb(182, 182, 182);
            btnOrder.Image = Properties.Resources
            btnOrder.ForeColor = Color.FromArgb(182, 182, 182);
            btnCart.Image = Properties.Resources
            btnCart.ForeColor = Color.FromArgb(182, 182, 182);
            btnSetting.Image = Properties.Resources
            btnSetting.ForeColor = Color.FromArgb(182, 182, 182);
        }

        private void btnTenantPage_Click(object sender, EventArgs e)
        {
            /*Boolean isTenant = false;
            using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var acct =  from list in notSoImportantVariable.Tenant
                                where Tenant.
                                select new { list.TenantID };

                foreach (var l in acct.ToList())
                {
                    if (username == l.CustomerID.ToString())
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
            this.Close();
            //Tenant_Main tm = new Tenant_Main(opener,orderId, item); //!!!!!!!!!!!!!!!!!!!!!
            //tm.Show();
            Sample s = new Sample();
            s.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            opener.Show();
        }
    }
}
