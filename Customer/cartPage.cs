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

    public partial class CartPage : Form
    {

        CustomerMain opener;
        private Stack items = new Stack();

        public CartPage(CustomerMain opener, String cusName)
        {
            InitializeComponent();
            this.opener = opener;
            dataGridView1.Columns.Add("itemID", "ID");
            dataGridView1.Columns.Add("qty", "Quantity");
        }
        public void AddItem(String itemID,String qty) {
            if (items.Count == 0)
               opener.UpdateCartHvItem(true);
            String[] item = { itemID, qty };
            items.Push(item);
            opener.UpdateCartHvItem(true);
            dataGridView1.Rows.Add(item[0], item[1]);

        }

        public void ClearCart()
        {
            dataGridView1.Rows.Clear();
            opener.UpdateCartHvItem(false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (opener.CartHvItem()) {
                var confirmResult = MessageBox.Show("Are you sure to clear the cart?", "", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                    ClearCart();
            }
            else
                return;
            
        }
    }
}
