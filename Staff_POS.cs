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
        showcase_item item = new showcase_item();
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

            using (var context = new DBEntities2())
            {
                var query = from sci in context.order_detail
                            where sci.itemID == id
                            select sci;
            }

            using (var context = new DBEntities2())
            {
<<<<<<< HEAD
                var qty = context.order_detail.First<order_detail>();
                qty.qty = qt;
=======
                var qty = context.showcase_item.First<showcase_item>();
                qty.salesqty = qt;
>>>>>>> parent of 8fcec7f... DIU
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
