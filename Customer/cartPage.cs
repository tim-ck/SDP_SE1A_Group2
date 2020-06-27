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

        public CartPage(CustomerMain opener)
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

       

    }
}
