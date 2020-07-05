using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2
{
    public partial class Staff_POS : Form
    {
        showcaseitem showcaseitem = new showcaseitem();
        item item = new item();
        public int qt;
        public double price;
        public double totalPrice;
        public string id;

        public Staff_POS()
        {
            InitializeComponent();
        }

        private void cmbShowCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = txtItemID.Text.ToString();
            qt = int.Parse(txtQT.Text);
            string selectedItem = cmbLocation.Items[cmbLocation.SelectedIndex].ToString();

            using (DBEntities db = new DBEntities())
            {
                var result = db.showcaseitem.SingleOrDefault(b => b.itemid == id);
                if (result != null)
                {
                    if (result.avalibleQty > 0)
                    {
                        result.avalibleQty -= qt;
                        result.soldQty += qt;
                        db.SaveChanges();
                        if (result.avalibleQty >= 0)
                        {
                            MessageBox.Show("Successfully");
                        }
                        else
                        {
                            result.avalibleQty += qt;
                            result.soldQty -= qt;
                            db.SaveChanges();
                            MessageBox.Show("Qty not available");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This item is empty");
                    }
                }
                else
                {
                    MessageBox.Show("Item ID not found");
                }
                updateDate();
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            using (DBEntities show = new DBEntities())
            {
                id = txtItemID.Text;
                var result = show.item.SingleOrDefault(b => b.itemID == id);
                if (result != null)
                {
                    long x = result.unitPrice;
                    txtPrice.Text = x.ToString();
                }
            }
        }

        private void Staff_POS_Load(object sender, EventArgs e)
        {
            updateDate();
        }

        public void updateDate()
        {
            dataGridView1.Rows.Clear();
            using (DBEntities print = new DBEntities())
            {
                var x = (from list in print.showcaseitem
                             select list);

                foreach (var x2 in x.ToList())
                {
                    dataGridView1.Rows.Add(x2.showcaseid, x2.itemid, x2.avalibleQty, x2.soldQty, x2.TotalQty);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            id = txtItemID.Text.ToString();
            qt = int.Parse(txtQT.Text);
            String date = System.DateTime.Now.ToString("f");
            String name = "";
            int unitprice = 0;
            using (DBEntities db = new DBEntities())
            {
                var result = db.item.SingleOrDefault(b => b.itemID == id);
                if (result != null)
                {
                    name = result.itemName;
                    unitprice = result.unitPrice;
                }
            }
            MessageBox.Show("Stock in Date:"+ date+"\r\n"+"Product Name:"+name + "\r\n"+"Unit Price:"+unitprice + "\r\n"+"Qty:"+qt + "\r\n"+"Total Price:"+ totalPrice);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQT_TextChanged(object sender, EventArgs e)
        {
            qt = int.Parse(txtQT.Text);
            price = double.Parse(txtPrice.Text);
            totalPrice = qt * price;
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
