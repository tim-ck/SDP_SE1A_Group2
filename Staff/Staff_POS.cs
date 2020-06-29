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
        order_detail item = new order_detail();
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
            id = txtItemID.Text;
            qt = int.Parse(txtQT.Text);

            using (var context = new DBEntities())
            {
                var query = from sci in context.showcase_item
                            where sci.itemId == id
                            select sci;
            }

            using (var context = new DBEntities())
            {
                var qty = context.item.First<order_detail>();
                qty.qty = qt;
                context.SaveChanges();
            }

            //receipt
            string[] receipt = {id,qt.ToString(),totalPrice.ToString()};


        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            qt = int.Parse(txtQT.Text);
            price = double.Parse(txtPrice.Text);

            totalPrice = qt * price;
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
