﻿using SDP_SE1A_Group2.Staff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Customer
{
    public partial class CustomerMain : Form
    {

        private Form activeForm = null; 
        private String userId, cusName, cusEmail;
        private Boolean hvItem;
        Form opener;                                                             
        CartPage cartPage;
        BrowseItems browseItemForm;
        Order orderForm;
        CustomerAccountSetting setting;
        Bitmap cart_P = Properties.Resources.cart_P;
        Bitmap cart_S = Properties.Resources.cart_S;
        Bitmap cart_hvItem_P = Properties.Resources.cart_hvItem_P;
        Bitmap cart_hvItem_S = Properties.Resources.cart_hvItem_S;

        public CustomerMain(Form parentForm, String userId)
        {
            InitializeComponent();
            opener = parentForm;                                                              
            this.userId = userId;
            UpdateCustomerInfo();


            lblTitle.Text = "Welcome Customer " + cusName;

            //define Form varible
            cartPage = new CartPage(this, cusName, userId);
            browseItemForm = new BrowseItems(this, cusName);
            orderForm = new Order(this, cusName, userId);
            setting = new CustomerAccountSetting(this,userId);

            //UI hide border
            this.Text = string.Empty;
            this.ControlBox = false;

            //UI icon
            btnCart.Image = cart_P;
        }

        private void UpdateCustomerInfo()
        {
            using (var db = new sdpEntities())
            {
                var userAcct = from list in db.customer
                               where list.customerID.Equals(userId)
                               select list;
                foreach (var user in userAcct.ToList())
                {
                    cusEmail = user.email;
                    cusName = user.customername;
                }



            }
        }

        public void updateOrderIdList(){
            orderForm.updateOrderIdList(); ;
        }
        //Title bar START
        private void lblCloseBtn_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }
        
    //Drag From Control 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
//Title bar END


//control cart item START
        public void UpdateStore(int store) { cartPage.UpdateStore(store); }
        public Boolean CartHvItem() { return hvItem; }
        public void UpdateCartHvItem(Boolean hvItem) { this.hvItem = hvItem; UpdateIcon(); }
        public void addItem(String itemID, String itemName, String description, int qty, int qtyRemain, int unitPrice, int totalPrice) { cartPage.AddItem(itemID, itemName, description, qty, qtyRemain, unitPrice, totalPrice); }
        public void ClearCart() { cartPage.ClearCart(); UpdateIcon(); }

       

        public void UpdateIcon() {
            if (hvItem)
            {
                if (btnCart.Image == cart_S|| btnCart.Image == cart_hvItem_S)
                    btnCart.Image = cart_hvItem_S;
                else
                    btnCart.Image = cart_hvItem_P;

            }
            else
            {
                if(btnCart.Image == cart_hvItem_S|| btnCart.Image == cart_S)
                    btnCart.Image = cart_S;
                else
                    btnCart.Image =cart_P;
            }
                
        }

        public String GetStoreName(int storeIndex)
        {
            String storeName="";
            switch (storeIndex)
            {
                case 0:
                    storeName = "cwb";
                    break;
                case 1:
                    storeName = "mka";
                    break;
                case 2:
                    storeName = "mkb";
                    break;
                case 3:
                    storeName = "kwf";
                    break;
                case 4:
                    storeName = "sht";
                    break;
            }
            return storeName;
        }
//control cart item End
//Email start
public void sendEmail(String subject, String message)
        {
             
            String sender = "tim.ck.project.email@gmail.com";
            var mailMessage = new MailMessage { };
            var smtpClinet = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(sender, "Abc123698745"),
                EnableSsl = true,
            };
            mailMessage = new MailMessage
            {
                From = new MailAddress(sender),
                Subject = subject,
                Body = message,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(cusEmail);
            smtpClinet.Send(mailMessage);
        }
//Email End

    //open child form
        public void openChildForm(Form childForm)
        {
            if (activeForm!= null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            panelChildForm.Controls.Add(childForm);
            childForm.Show();
        }
        public void closeChildForm()
        {
            if (activeForm != null)
                activeForm.Close();
            
        }



        //menu button click START

        private void btnProduct_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Product Page";
            openChildForm(browseItemForm);
            //UI
            btnProduct.Image = Properties.Resources.item_P1;
            btnProduct.ForeColor = Color.FromArgb(236, 236, 236);
            btnOrder.Image = Properties.Resources.order_p;
            btnOrder.ForeColor = Color.FromArgb(182, 182, 182);
            if (CartHvItem())
                btnCart.Image = cart_hvItem_P;
            else
                btnCart.Image = cart_P;
            btnCart.ForeColor = Color.FromArgb(182, 182, 182);
            btnAccountSetting.Image = Properties.Resources.setting;
            btnAccountSetting.ForeColor = Color.FromArgb(182, 182, 182);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Cart Page";
            openChildForm(cartPage);
            //UI
            btnProduct.Image = Properties.Resources.item_P;
            btnProduct.ForeColor = Color.FromArgb(182, 182, 182);
            btnOrder.Image = Properties.Resources.order_p;
            btnOrder.ForeColor = Color.FromArgb(182, 182, 182);
            if (CartHvItem())
                btnCart.Image = cart_hvItem_S;
            else
                btnCart.Image = cart_S;
            btnCart.ForeColor = Color.FromArgb(236, 236, 236);

            btnAccountSetting.Image = Properties.Resources.setting;
            btnAccountSetting.ForeColor = Color.FromArgb(182, 182, 182);
        }
        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            lblTitle.Text = "Order Page";
            openChildForm(orderForm);
            //UI
            btnProduct.Image = Properties.Resources.item_P;
            btnProduct.ForeColor = Color.FromArgb(182, 182, 182);
            btnOrder.Image = Properties.Resources.order_s;
            btnOrder.ForeColor = Color.FromArgb(236, 236, 236);
            if (CartHvItem())
                btnCart.Image = cart_hvItem_P;
            else
                btnCart.Image = cart_P;
            btnCart.ForeColor = Color.FromArgb(182, 182, 182);

            btnAccountSetting.Image = Properties.Resources.setting;
            btnAccountSetting.ForeColor = Color.FromArgb(182, 182, 182);
        }

      
        


        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            
            openChildForm(setting);
            //UI
            btnProduct.Image = Properties.Resources.item_P;
            btnProduct.ForeColor = Color.FromArgb(182, 182, 182);
            btnOrder.Image = Properties.Resources.order_p;
            btnOrder.ForeColor = Color.FromArgb(182, 182, 182);
            if (CartHvItem())
                btnCart.Image =cart_hvItem_P;
            else
                btnCart.Image = cart_P;
            btnCart.ForeColor = Color.FromArgb(182, 182, 182);
            btnAccountSetting.Image = Properties.Resources.setting_s;
            btnAccountSetting.ForeColor = Color.FromArgb(236, 236, 236);


        }

        private void lblMinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //show home page
            lblTitle.Text = "Welcome Customer " + cusName;
            if (activeForm != null)
                activeForm.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logout();
        }

        internal void logout()
        {
            this.Close();
            opener.Show();
        }
        

    }
}
