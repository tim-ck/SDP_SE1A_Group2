using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Customer
{

    public partial class CartPage : Form
    {

        CustomerMain opener;
        private String cusName, cusID;
        private int itemsCount=0;

        public CartPage(CustomerMain opener, String cusName, String cusID)
        {
            InitializeComponent();
            this.opener = opener;
            this.cusID = cusID;
            this.cusName = cusName;

           

        }

        public void UpdateStore(int storeIndex) {
            String storeID = "StoreID : ";
            String storeName = "Store Name: ";

            switch (storeIndex)
            {
                case 0:
                    storeID += "cwb"; 
                    storeName += "UG03, ABC Mall";
                    break;
                case 1:
                    storeID += "mka";
                    storeName+= "LG22, DEF Commercial Centre";
                    break;
                case 2:
                    storeID += "mkb";
                    storeName += "203, G.H.I Mall";
                    break;
                case 3:
                    storeID += "kwf";
                    storeName += "LG123, Kwai Fong Plaza";
                    break;
                case 4:
                    storeID += "sht";
                    storeName += "888, New ST Plaza";
                    break;
            }
            txtStoreID.Text = storeID;
            txtStoreAddress.Text = storeName;
        }
        //update Order Total Price
        private void UpdateOrderTotalPrcie()
        {
            float orderTotalPrice = 0;

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if(dataGridView1.Rows[i].Cells["totalPrice"].Value!=null)
                    orderTotalPrice += float.Parse(dataGridView1.Rows[i].Cells["totalPrice"].Value.ToString());
            }
            txtTotalPrice.Text = orderTotalPrice.ToString();
        }

        //add
        public void AddItem(String itemID, String itemName, String description, int quantity, int qtyRemain, int unitPrice, int totalPrice) {
            if (itemsCount == 0)
               opener.UpdateCartHvItem(true);
            ++itemsCount;
            dataGridView1.Rows.Add(itemID, itemName, description, unitPrice);
            

            //modify combox qty colums
            DataGridViewComboBoxCell cmb =
                (DataGridViewComboBoxCell)(dataGridView1.Rows[itemsCount - 1].Cells["qty"]);
            String[] qty = new String[qtyRemain];
            for (int a=1; a <= qtyRemain; a++)
            {
                qty[a-1] = a.ToString();
            }
            cmb.DataSource = qty;
            cmb.Value = quantity.ToString();
            dataGridView1.Rows[itemsCount - 1].Cells["totalPrice"].Value = totalPrice;
            
            UpdateOrderTotalPrcie();


        }

        
        //remove
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int row = e.RowIndex;
            if (colum == dataGridView1.Rows[row].Cells["btnRemoveItem"].ColumnIndex && row < itemsCount)
            {
                itemsCount--;
                if (itemsCount == 0)
                    opener.UpdateCartHvItem(false);
                dataGridView1.Rows.Remove(dataGridView1.Rows[row]);
            }
            UpdateOrderTotalPrcie();

        }
        //clear
        public void ClearCart()
        {
            dataGridView1.Rows.Clear();
            itemsCount = 0;
            opener.UpdateCartHvItem(false);
            UpdateOrderTotalPrcie();
        }

        //btn
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (opener.CartHvItem()) {
                var confirmResult = MessageBox.Show("Are you sure to clear the cart?", "", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                    ClearCart();
            }
            
            
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Rows[e.RowIndex].Cells["qty"].ColumnIndex)
            {
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["qty"].Value != null)
                    {
                        var qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["qty"].Value.ToString());
                        var unitPrice = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString());
                        dataGridView1.Rows[e.RowIndex].Cells["totalPrice"].Value = (qty * unitPrice);
                    }
                }
            }
        }

        private void btnShowShopItem_Click(object sender, EventArgs e)
        {
            if (opener.CartHvItem())
            {
                var confirmResult = MessageBox.Show("Are you sure to create Order?", "", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    int orderCount ;
                    using (var db = new sdpEntities())
                    {
                        var id = from a in db.order
                                 select a;
                        orderCount = id.Count() + 1;
                        String newOrderID = orderCount.ToString("D3");
                        //SendEMail AND create Order
                        var order = new order()
                        {
                            orderID = newOrderID,
                            customerID = cusID,
                            orderDate = System.DateTime.Today,
                            orderTotalPrice = float.Parse(txtTotalPrice.Text),
                            storeID = txtStoreID.Text

                        };
                        db.order.Add(order);
                        db.SaveChanges();
                        var culture = new CultureInfo("en-GB");
                        String subject = "Order Detail for your order #" + newOrderID;
                        String msg = "<h1>The Hong Kong Cube Shop</h1>" +
                            "<h2>Your order is ready.</h2>" +
                            "order id:" + newOrderID +
                            "<br>order date:" + DateTime.Now.ToString(culture) +
                            "<hr>Store ID : " + txtStoreID.Text + "<br>" +
                            "Store Address : " + txtStoreAddress.Text + "<br>" +
                            "Opening hours: 10:00am-09:00pm <p>" +
                            "Contact our staff inside the store mention above. We will check your email and customer account,<br> and we will prepare items of your order." +
                            "<hr>" +
                            "<table bgcolor='#80b3d3' width='100%' border='1' >" +
                            "<tr><th>ItemID</th><th>Item Name</th><th>Description</th><th>Unit Price</th><th>Quantity</th><th>Total Price</th></tr>";
                        for(int i=0; i<dataGridView1.Rows.Count-1;i++)
                        {
                            String itemid = dataGridView1.Rows[i].Cells["itemID"].Value.ToString();
                            String unitprice = dataGridView1.Rows[i].Cells["unitPrice"].Value.ToString();
                            String quantity = dataGridView1.Rows[i].Cells["qty"].Value.ToString();
                            String itemTotalPrice = dataGridView1.Rows[i].Cells["totalPrice"].Value.ToString();
                            msg += "<tr><th>"+itemid+"</th><th>"+ dataGridView1.Rows[i].Cells["itemName"].Value.ToString() + "</th><th>" + dataGridView1.Rows[i].Cells["description"].Value.ToString() + "</th><th>"+unitprice+"</th><th>"+quantity+"</th><th>"+itemTotalPrice+"</th></tr>";
                            
                            var orderdetail = new order_detail()
                            {
                                orderID = newOrderID,
                                itemID = itemid,
                                unitPrice = float.Parse(unitprice),
                                qty = int.Parse(quantity),
                                totalPrice = float.Parse(itemTotalPrice)

                            };
                            db.order_detail.Add(orderdetail);
                            db.SaveChanges();
                            var orderde = db.showcaseitem.SingleOrDefault(a => a.itemid == itemid);
                            if (orderde != null)
                            {
                                orderde.availableQty -= int.Parse(quantity);
                                orderde.soldQty += int.Parse(quantity);
                                db.SaveChanges();
                            }
                        }
                        msg +="<tr>" +
                            "<td colspan='4'>Total Price</td>" +
                            "<td colspan='2'></td></tr></table>";

                        opener.sendEmail(subject, msg);
                        //opener.CreateOrder()
                        MessageBox.Show("The Order detail had sent to your Email successfully. Order created");
                        opener.updateOrderIdList();

                    }
                }




                    
            }
            
        }
    }
}
