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
        public Staff_POS()
        {
            InitializeComponent();
        }

        private void cmbShowCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtItemID.Text;

            using (var context = new DBEntities())
            {
                var query = from sci in context.showcase_item
                            where sci.itemId == id
                            select sci;

            }

            using (var context = new DBEntities())
            {
                var qty = context.showcase_item.First<Student>();
                qty.qty = ;
                context.SaveChanges();
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int qt = int.Parse(txtQT.Text);
            double price = double.Parse(txtPrice.Text);
            double totalPrice;

            totalPrice = qt * price;
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
