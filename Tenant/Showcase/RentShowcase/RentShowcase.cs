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
    public partial class RentShowcase : Form
    {
        String showcaseid;
        String ava;
        double rental;
        public RentShowcase(string id)
        {
            InitializeComponent();
            showcaseid = id;
        }

        private void RentShowcase_Load(object sender, EventArgs e)
        {
            //Load showcase info
            lblShowcaseId.Text = showcaseid;
            lblLocation.Text = showcaseid.Substring(0,3);

            using (var db = new sdpEntities())
            {
                var rs = from result in db.showcase
                         where result.showcaseid.Contains(showcaseid)
                         select result;
                foreach(var row in rs)
                {
                    lblRental.Text = row.rental.ToString();
                    ava = row.status.ToString();
                    rental = double.Parse(row.rental.ToString());
                }
            }
            switch (ava)
            {
                case "a":
                    lblStatus.Text = "Available";
                    break;
                case "o":
                    lblStatus.Text = "Occupied";
                    break;
                case "r":
                    lblStatus.Text = "Reserved";
                    break;
            }

            if (ava.Equals("a"))
            {
                btnReserve.Enabled = true;
            }
            else if (ava.Equals("o"))
            {
                btnRent.Enabled = true;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblTotalPrice.Text.ToString()))
            {
                if (int.Parse(txtPeriod.Text) >= 4380)
                {
                    lblTotalPrice.Text = (0.85 * rental * double.Parse(txtPeriod.Text.ToString())).ToString();
                }
                else if (int.Parse(txtPeriod.Text) >= 180){
                    lblTotalPrice.Text = (0.95 * rental * double.Parse(txtPeriod.Text.ToString())).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
