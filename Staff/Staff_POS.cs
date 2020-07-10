using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2
{
    public partial class Staff_POS : Form
    {
        private Staff_main opener;
        private int numOfItem = 0;
        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        private int LastSelectedIndex;
        private Boolean hvItem=false;
        private int itemsCount = 0;
        String subject = "",  msg="", pdfmsg="";
        Stack<String> pdf;
        public Staff_POS(Staff_main opener)
        {
            InitializeComponent();
            this.opener = opener;
            dataCart.Hide();
            lblTotalprice.Hide();
            txtTotalPrice.Hide();
        }

        //item
        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hvItem && LastSelectedIndex != cmbStore.SelectedIndex)
            {
                var confirmResult = MessageBox.Show("If you switch location now, your cart will be clear.", "", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    ClearCart();
                    LastSelectedIndex = cmbStore.SelectedIndex;
                }
                else
                {
                    cmbStore.SelectedIndex = LastSelectedIndex;
                }
            }
            LastSelectedIndex = cmbStore.SelectedIndex;
        }
        private void btnShowShopItem_Click_1(object sender, EventArgs e)
        {
            if (cmbStore.Text == "")
            {
                MessageBox.Show("Select Store First");
                return;
            }
            dataItem.Rows.Clear();
            addRows(GetStoreName(cmbStore.SelectedIndex));
        }

        private void addRows(string storeName)
        {
            
            using (var db = new sdpEntities())
            {
                var item = from items in db.items
                           from showcaseItem in db.showcaseitems
                           where showcaseItem.showcaseid.Contains(storeName) && items.itemID == showcaseItem.itemid && showcaseItem.availableQty > 0
                           select new
                           {
                               showcaseItem.itemid,
                               showcaseItem.showcaseid,
                               showcaseItem.availableQty,
                               items.itemName,
                               items.itemDesc,
                               items.unitPrice
                           };
                int count = 0;
                foreach (var i in item.ToList())
                {
                    dataItem.Rows.Add(i.itemid,
                                    storeName,
                                   i.showcaseid,

                                   i.itemName,
                                   i.itemDesc,
                                   i.availableQty,
                                   i.unitPrice);
                    DataGridViewComboBoxCell cmb =
                        (DataGridViewComboBoxCell)(dataItem.Rows[count].Cells["qty"]);
                    String[] qty = new string[i.availableQty + 1];
                    for (int a = 0; a <= i.availableQty; a++)
                    {
                        qty[a] = a.ToString();
                    }
                    cmb.DataSource = qty;
                    dataItem.Rows[count].Cells["qty"].Value = "0";
                    count++;

                }
                numOfItem = dataItem.Rows.Count;



            }
        }

        public String GetStoreName(int storeIndex)
        {
            String storeName = "";
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
        private void dataItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int row = e.RowIndex;
            if (colum == dataItem.Rows[e.RowIndex].Cells["AddToCart"].ColumnIndex && row < numOfItem)
            {
                if (dataItem.Rows[row].Cells["qty"].Value == "0")
                {
                    var confirmResult = MessageBox.Show("Choose quantity", "");
                    return;
                }

                String itemID = dataItem.Rows[row].Cells["itemID"].Value.ToString();
                String itemName = dataItem.Rows[row].Cells["itemName"].Value.ToString();
                String description = dataItem.Rows[row].Cells["description"].Value.ToString();
                int qty = int.Parse(dataItem.Rows[row].Cells["qty"].Value.ToString());
                int qtyRemain = int.Parse(dataItem.Rows[row].Cells["availableQty"].Value.ToString());
                int unitPrice = int.Parse(dataItem.Rows[row].Cells["UnitPrice"].Value.ToString());
                int totalPrice = int.Parse(dataItem.Rows[row].Cells["totalPrice"].Value.ToString());



                AddItem(itemID, itemName, description, qty, qtyRemain, unitPrice, totalPrice);

            }
        }

        private void dataItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataItem.Rows[e.RowIndex].Cells["qty"].ColumnIndex)
            {
                if (dataItem.Rows[e.RowIndex].Cells["qty"].Value != null)
                {
                    var qty = int.Parse(dataItem.Rows[e.RowIndex].Cells["qty"].Value.ToString());
                    var unitPrice = int.Parse(dataItem.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString());
                    dataItem.Rows[e.RowIndex].Cells["totalPrice"].Value = (qty * unitPrice);
                }
            }
        }
        //cart 
        public void ClearCart()
        {
            dataCart.Rows.Clear();
            itemsCount = 0;
            hvItem = false;
            UpdateOrderTotalPrcie();
        }

        private void UpdateOrderTotalPrcie()
        {
            float orderTotalPrice = 0;

            for (int i = 0; i < dataCart.Rows.Count - 1; i++)
            {
                if (dataCart.Rows[i].Cells["cart_TotalPrice"].Value != null)
                    orderTotalPrice += float.Parse(dataCart.Rows[i].Cells["cart_TotalPrice"].Value.ToString());
            }
            txtTotalPrice.Text = orderTotalPrice.ToString();
        }
        //add
        public void AddItem(String itemID, String itemName, String description, int quantity, int qtyRemain, int unitPrice, int totalPrice)
        {
            if (itemsCount == 0)
                hvItem =true;
            for (int i =0; i < itemsCount ; i++)
            {
                if (itemID == dataCart.Rows[i].Cells["cart_itemID"].Value.ToString())
                {
                    return;
                }
            }
            ++itemsCount;
            dataCart.Rows.Add(itemID, itemName, description, unitPrice);


            //modify combox qty colums
            DataGridViewComboBoxCell cmb =
                (DataGridViewComboBoxCell)(dataCart.Rows[itemsCount - 1].Cells["cart_qty"]);
            String[] qty = new String[qtyRemain];
            for (int a = 1; a <= qtyRemain; a++)
            {
                qty[a - 1] = a.ToString();
            }
            cmb.DataSource = qty;
            cmb.Value = quantity.ToString();
            dataCart.Rows[itemsCount - 1].Cells["cart_TotalPrice"].Value = totalPrice;

            UpdateOrderTotalPrcie();


        }
        //remove
        private void dataCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int row = e.RowIndex;
            if (colum == dataCart.Rows[row].Cells["btnRemoveItem"].ColumnIndex && row < itemsCount)
            {
                itemsCount--;
                if (itemsCount == 0)
                    hvItem =false;
                dataCart.Rows.Remove(dataCart.Rows[row]);
            }
            UpdateOrderTotalPrcie();

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (hvItem)
            {
                var confirmResult = MessageBox.Show("Are you sure to clear the cart?", "", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                    ClearCart();
            }

        }

        private void dataCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataCart.Rows[e.RowIndex].Cells["cart_qty"].ColumnIndex)
            {
                {
                    if (dataCart.Rows[e.RowIndex].Cells["cart_qty"].Value != null)
                    {
                        var qty = int.Parse(dataCart.Rows[e.RowIndex].Cells["cart_qty"].Value.ToString());
                        var unitPrice = int.Parse(dataCart.Rows[e.RowIndex].Cells["cart_unitPrice"].Value.ToString());
                        dataCart.Rows[e.RowIndex].Cells["cart_unitPrice"].Value = (qty * unitPrice);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean hvEmail = false;
            if (hvItem)
            {
                var confirmResult = MessageBox.Show("Are you sure to create Order?", "", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    if (txtEmail.Text != "" )
                    {
                        try { var addr = new System.Net.Mail.MailAddress(txtEmail.Text); hvEmail = true; }
                        catch
                        {
                            MessageBox.Show("invalid Email Address");
                            confirmResult = MessageBox.Show("Are you sure to create email Without sending to customer's email?", "", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                hvEmail = false;
                            }
                            else
                            {
                                return;
                            }

                        }
                        

                    }
                    int orderCount;
                    subject = "";
                    msg = "";
                    pdfmsg = "";
                    using (var db = new sdpEntities())
                    {
                        var id = from a in db.orders
                                 select a;
                        orderCount = id.Count() + 1;
                        String newOrderID = orderCount.ToString("D3");
                        //SendEMail AND create Order

                        var order = new order()
                        {
                            orderID = newOrderID,
                            storeID = GetStoreName(cmbStore.SelectedIndex),
                            orderDate = System.DateTime.Today,
                            orderTotalPrice = float.Parse(txtTotalPrice.Text),


                        };
                        db.orders.Add(order);

                        var culture = new CultureInfo("en-GB");
                         subject = "Order Detail for your order #" + newOrderID;
                      

                        msg = "<h1>The Hong Kong Cube Shop</h1>" +
                            "<h2>Your order is ready.</h2>" +
                            "order id:" + newOrderID +
                            "<br>order date:" + DateTime.Now.ToString(culture) +
                            "<hr>Store ID : " + GetStoreName(cmbStore.SelectedIndex) + "<br>" +
                            "Store Address : " + cmbStore.Text + "<br>" +
                            "Opening hours: 10:00am-09:00pm <p>" +
                            "<hr>" +
                            "<table bgcolor='#80b3d3' width='100%' border='1' >" +
                            "<tr><th>ItemID</th><th>Item Name</th><th>Description</th><th>Unit Price</th><th>Quantity</th><th>Total Price For Each Items</th></tr>";
                        MessageBox.Show("order id: " + newOrderID +
                            "\norder date:" + DateTime.Now.ToString(culture) +
                            "\nStore ID : " + GetStoreName(cmbStore.SelectedIndex), "Recipt", MessageBoxButtons.OK);
                        MessageBox.Show("Store Address: " + cmbStore.Text +
                            "\nOpening hours: 10:00am-09:00pm", "Recipt", MessageBoxButtons.OK);
                       
                       



                        for (int i = 0; i < dataCart.Rows.Count - 1; i++)
                        {
                            String itemid = dataCart.Rows[i].Cells["cart_itemID"].Value.ToString();
                            String unitprice = dataCart.Rows[i].Cells["cart_unitPrice"].Value.ToString();
                            String quantity = dataCart.Rows[i].Cells["cart_qty"].Value.ToString();
                            String itemTotalPrice = dataCart.Rows[i].Cells["cart_TotalPrice"].Value.ToString();
                            msg += "<tr><th>" + itemid + "</th><th>" + dataCart.Rows[i].Cells["cart_ItemName"].Value.ToString() + "</th><th>" + dataCart.Rows[i].Cells["cart_des"].Value.ToString() + "</th><th>" + unitprice + "</th><th>" + quantity + "</th><th>" + itemTotalPrice + "</th></tr>";
                            MessageBox.Show("ItemID : " + itemid+ "  Item Name: "+ dataCart.Rows[i].Cells["cart_ItemName"].Value.ToString()+ "\nDescription: "+ dataCart.Rows[i].Cells["cart_des"].Value.ToString() + "\nUnit Price    $"+ unitprice + "\nQuantity"+ quantity + "\nTotal Price For Each Items   $"+ itemTotalPrice, "\nItem " + i+1, MessageBoxButtons.OK);
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
                            var orderde = db.showcaseitems.SingleOrDefault(a => a.itemid == itemid);
                            if (orderde != null)
                            {
                                orderde.availableQty -= int.Parse(quantity);
                                orderde.soldQty += int.Parse(quantity);
                                db.SaveChanges();
                            }
                        }
                        msg += "<tr>" +
                            "<td colspan='4'>Total Price For This Order</td>" +
                            "<td colspan='2'>" + txtTotalPrice.Text + "</td></tr></table>";
                        MessageBox.Show("Total Price For This Order is $" + txtTotalPrice.Text, "Total Price", MessageBoxButtons.OK);
                        if (hvEmail)
                        {
                            sendEmail(subject, msg,txtEmail.Text);

                        }
                        /*string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string file = "OrderID" + newOrderID + ".pdf";
                        Margins margins = new Margins(100, 100, 100, 100);

                        PrintDocument pDoc = new PrintDocument()
                        {
                            PrinterSettings = new PrinterSettings()
                            {
                                PrinterName = "Microsoft Print to PDF",
                                PrintToFile = true,
                                PrintFileName = System.IO.Path.Combine(directory, file),
                                
                            }
                        };

                        pDoc.PrintPage += new PrintPageEventHandler(Print_Page);
                        pDoc.Print();
                        */
                       
                        

                    }
                }






            }
        }

        
        /*
        private void Print_Page(object sender, PrintPageEventArgs e)
        {
            Font header = new Font("Segoe UI", 20);
            Font fnt = new Font("Segoe UI", 9);

            e.Graphics.DrawString(subject, header,System.Drawing.Brushes.Black,0,0);
            e.Graphics.DrawString(pdfmsg, fnt, System.Drawing.Brushes.Black, 0, 30);

        }*/
        /*public class TestComponent extends JPanel {

    private void drawString(Graphics g, String text, int x, int y) {
        for (String line : text.split("\n"))
            g.drawString(line, x, y += g.getFontMetrics().getHeight());
    }

    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        drawString(g, "hello\nworld", 20, 20);
        g.setFont(g.getFont().deriveFont(20f));
        drawString(g, "part1\npart2", 120, 120);
    }

    public static void main(String s[]) {
        JFrame f = new JFrame();
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.add(new TestComponent());
        f.setSize(220, 220);
        f.setVisible(true);
    }
}
*/

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            dataCart.Hide();
            lblTotalprice.Hide();
            txtTotalPrice.Hide();
            dataItem.Show();
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            dataCart.Show();
            lblTotalprice.Show();
            txtTotalPrice.Show();
            dataItem.Hide();
        }

        private void sendEmail(string subject, string msg,string email)
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
                Body = msg,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);
            smtpClinet.Send(mailMessage);
            MessageBox.Show("The Order detail had sent to  Email successfully. ");
        }
    }
}
