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
        private Stack item = new Stack();
        public CartPage(String userID, Stack item)
        {
            InitializeComponent();
            this.item = item;
        }
        public void UpdateItem(Stack item) { this.item = item;  }
        

    }
}
