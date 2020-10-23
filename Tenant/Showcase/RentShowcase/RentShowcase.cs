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
        TenantRentShowcase _owner;
        String showcaseid;
        String ava;
        double rental;
        double discountPeriod = 1;
        double discountShowcaseNum = 1;
        public RentShowcase(string id, TenantRentShowcase owner)
        {
            InitializeComponent();
            showcaseid = id;
            _owner = owner;
        }


        private void loadInfo()
        //Load selected showcase info
        {
            lblShowcaseId.Text = showcaseid;
            lblLocation.Text = showcaseid.Substring(0, 3).ToUpper();

            using (var db = new sdpEntities())
            {
                var rs = from result in db.showcases
                         where result.showcaseid.Contains(showcaseid)
                         select result;

                foreach (var row in rs)
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
            // Load No. of Showcase that is renting
            using (var db = new sdpEntities())
            {
                var rs = from lsRentinfo in db.rentinfoes
                         where lsRentinfo.tenantID.Contains(TenantMain.tenantID)
                         select lsRentinfo;

                int showcaseNumber = 0;
                foreach (var row in rs.ToList())
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


        private void enableBtn()
        //Enable "Rent" / Reserve
        {
            if (ava.Equals("o"))
            {
                btnReserve.Enabled = true;
            }
            else if (ava.Equals("a"))
            {
                btnRent.Enabled = true;
            }
        }


        private void RentShowcase_Load(object sender, EventArgs e)
        {
            loadInfo();
            enableBtn();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        // Calculate discount & total price for rent period
        {
            if (!txtPeriod.Text.Equals(""))
            {
                lblTotalPrice.Text = (rental * int.Parse(txtPeriod.Text.ToString())).ToString();

                if (int.Parse(txtPeriod.Text) >= 365)
                // >= 12 months
                {
                    cb12M.ForeColor = Color.Green;
                    cb12M.Checked = true;
                    cb6M.ForeColor = Color.WhiteSmoke;
                    cb6M.Checked = false;
                    discountPeriod = 0.9;

                }
                else if (int.Parse(txtPeriod.Text) >= 182 && int.Parse(txtPeriod.Text) < 365)
                // >= 6 months && <365
                {
                    cb6M.ForeColor = Color.Green;
                    cb6M.Checked = true;
                    cb12M.ForeColor = Color.WhiteSmoke;
                    cb12M.Checked = false;
                    discountPeriod = 0.95;
                }
                else
                // < 6 months
                {
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
            using (var db = new sdpEntities())
            {
                //Insert row to table: "rentInfo"
                // int newID = int.Parse(db.rentinfo.Max(p => p.rentID)) + 1;
                string newID = (!db.rentinfoes.Any()) ? (newID = "001") : (int.Parse(db.rentinfoes.Max(p => p.rentID)) + 1).ToString("D3");
                var localDate = DateTime.Now.ToString("yyyy-MM-dd");
               
                string sql = "Insert into rentinfo(rentID, tenantID, startDate, duration, showcaseid, storeID) values('" + newID + "', '" + TenantMain.tenantID + "', DATE '" +localDate + "','" + txtPeriod.Text.ToString() + "', '" + lblShowcaseId.Text.ToString() + "','" + lblShowcaseId.Text.ToString().Substring(0, 3) + "')";
                int noOfRowInserted = db.Database.ExecuteSqlCommand(sql);

                if (noOfRowInserted == 1)
                {
                    //Update table: "Showcase"
                    sql = "Update showcase set status ='o' where showcaseid='" + lblShowcaseId.Text.ToString() + "'";
                    int noOfRowUpdated = db.Database.ExecuteSqlCommand(sql);


                    string msg = "Rent successfully." +
                                 "\r\n\r\nDetail:" +
                                 "\r\nShowcaseID: " + lblShowcaseId.Text.ToString() +
                                 "\r\nDuration: " + txtPeriod.Text.ToString() +
                                 "\r\nTotal Charge: " + lblAfterDiscount.Text.ToString();
                    MessageBox.Show(msg, "System Message");
                    this.Close();

                }
            }

        }

        private void RentShowcase_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.clearDgv();
            _owner.loadDgv();
        }




        private void btnReserve_Click(object sender, EventArgs e)
        {
            using (var db = new sdpEntities())
            {
                //Insert row to table: "reservation"
                string newID = (!db.reservations.Any()) ? (newID = "001") : (int.Parse(db.reservations.Max(p => p.reservationid)) + 1).ToString("D3");

                string sql = "Insert into reservation(reservationid, tenantID, showcaseid) values('" + newID + "', '" + TenantMain.tenantID + "', '" + lblShowcaseId.Text.ToString() + "')";
                int noOfRowInserted = db.Database.ExecuteSqlCommand(sql);

                if (noOfRowInserted == 1)
                {
                    string msg = "You have reserve the following showcase successfully:\r\n" + lblShowcaseId.Text.ToString();
                    MessageBox.Show(msg, "System Message");

                    //Update table: "Showcase" value: "Stutas" to "r"
                    sql = "Update showcase set status ='r' where showcaseid='" + lblShowcaseId.Text.ToString() + "'";
                    int noOfRowUpdated = db.Database.ExecuteSqlCommand(sql);

                    this.Close();
                }


                {


                }
            }
        }
    }
}
