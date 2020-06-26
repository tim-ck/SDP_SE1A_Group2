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
        Form opener;
        private Stack items = new Stack();
        public CartPage(Form opener, String[] arrayObj)
        {
            InitializeComponent();
            this.opener = opener;
            foreach(String item in arrayObj)
            {
                items.Push(item);
            }
        }
        public void AddItem(String item) {
            if (items.Count == 0)
               opener.UpdateCartHvItem(true);
            items.Push(item);
            
        }
        

    }
}
