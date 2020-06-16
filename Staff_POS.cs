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
        public Staff_POS()
        {
            InitializeComponent();
        }

        private void cmbShowCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qt = int.Parse(txtQT.Text);
            double price = double.Parse(txtPrice.Text);
            double totalPrice;
            
            
            totalPrice = qt * price;
            txtTotalPrice.Text = totalPrice.ToString();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
