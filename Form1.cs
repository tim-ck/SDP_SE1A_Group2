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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            Customer.customerMain f = new Customer.customerMain();
            f.Show();
            Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
