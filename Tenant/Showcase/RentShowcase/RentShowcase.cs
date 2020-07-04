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
        double discountPeriod = 1;
        double discountShowcaseNum = 1;
        public RentShowcase(string id)
        {
            InitializeComponent();
            showcaseid = id;
        }

        private void RentShowcase_Load(object sender, EventArgs e)
        {
            //Load selected showcase info
            lblShowcaseId.Text = showcaseid;
            lblLocation.Text = showcaseid.Substring(0,3).ToUpper();

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
                    lblStatus.ForeColor = Color.Green;
                    break;
                case "o":
                    lblStatus.Text = "Occupied";
                    lblStatus.ForeColor = Color.Red;
                    break;
                case "r":
                    lblStatus.Text = "Reserved";
                    break;
            }


            // Enable "Rent" / "Reserve" button
            if (ava.Equals("o"))
            {
                btnReserve.Enabled = true;
            } else if (ava.Equals("a"))
            {
                btnRent.Enabled = true;
            }
            // Load No. of Showcase that is renting
            using (var db = new sdpEntities())
            {
                var rs = from lsRentinfo in db.rentinfo
                         where lsRentinfo.tenantID.Contains(TenantMain.tenantID)
                         select lsRentinfo;

                int showcaseNumber = 0;
                foreach(var row in rs.ToList())
                {
                    if (row.startDate.ToOADate() + row.duration >= DateTime.Now.ToOADate())
                    showcaseNumber++;
                }
                lblNumShowcase.Text = showcaseNumber.ToString();
            }

            // Calculate discount for No. showcase
            if (int.Parse(lblNumShowcase.Text) > 2 && int.Parse(lblNumShowcase.Text) <= 5)
            {
                lblDiscountNum.Text = "5%";
                discountShowcaseNum = 0.95;
                lblDiscountNum.ForeColor = Color.Green;
            }
            else if (int.Parse(lblNumShowcase.Text) >= 6)
            {
                lblDiscountNum.Text = "10%";
                lblDiscountNum.ForeColor = Color.Green;
                discountShowcaseNum = 0.9;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            // Calculate discount & total price for rent period
            if (!txtPeriod.Text.Equals(""))
            {
                if (int.Parse(txtPeriod.Text) >= 365)
                    // >= 12 months
                {
                    lblTotalPrice.Text = (0.85 * rental * int.Parse(txtPeriod.Text.ToString())).ToString();
                    cb12M.ForeColor = Color.Green;
                    cb12M.Checked = true;
                    cb6M.ForeColor = Color.WhiteSmoke;
                    cb6M.Checked = false;
                    discountPeriod = 0.9;

                }else if (int.Parse(txtPeriod.Text) >= 182 && int.Parse(txtPeriod.Text) < 365)
                    // >= 6 months
                {
                    lblTotalPrice.Text = (0.95 * rental * int.Parse(txtPeriod.Text.ToString())).ToString();
                    cb6M.ForeColor = Color.Green;
                    cb6M.Checked = true;
                    cb12M.ForeColor = Color.WhiteSmoke;
                    cb12M.Checked = false;
                    discountPeriod = 0.95;
                }
                else
                // < 6 months
                {
                    lblTotalPrice.Text = (rental * int.Parse(txtPeriod.Text)).ToString("F1");
                    cb6M.ForeColor = Color.WhiteSmoke;
                    cb6M.Checked = false;
                    cb12M.ForeColor = Color.WhiteSmoke;
                    cb12M.Checked = false;
                    discountPeriod = 1;
                }
            }
            else
            {
                lblTotalPrice.Text = "0";
            }
            // Show "Total Discount"
            lblDiscount.Text = ((double.Parse(lblTotalPrice.Text)) - (double.Parse(lblTotalPrice.Text) * discountPeriod * discountShowcaseNum)).ToString("F1");
            // Show "After Discount"
            lblAfterDiscount.Text = (double.Parse(lblTotalPrice.Text) - double.Parse(lblDiscount.Text)).ToString("F1");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

        }
    }
}
