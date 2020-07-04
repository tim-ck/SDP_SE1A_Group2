using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2 { 

    public partial class TenantRentShowcase : Form
    {
        public TenantRentShowcase()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Open a new window to rent or reserve
            if (!dataGridView1.CurrentRow.Cells[3].Value.Equals("Reserved"))
            {
                string showcaseID = "";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    showcaseID = row.Cells[0].Value.ToString();
                }
                RentShowcase rentShowcase = new RentShowcase(showcaseID);
                rentShowcase.Show();
            }
            else
            {
                MessageBox.Show("The showcase you picked is reserved by others, please pick another one.",
                                "Warning",
                                MessageBoxButtons.OK);
            }
        }

        private void TenantRentShowcase_Load(object sender, EventArgs e)
        {
            //Set dafault value of comboboxes
            cboLocation.SelectedIndex = 0;
            cboSize.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;

            //Load showcase data to data grid view from db
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            using (var classicContext = new sdpEntities())
            {
                var showcase = (from list in classicContext.showcase
                           select list);

                

                foreach (var row in showcase.ToList())
                {
                    //Convert status code to word
                    string status = "";
                    if (row.status.Equals("a"))
                    {
                        status = "Available";
                        //dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                    } else if (row.status.Equals("o")){
                        status = "Occupied";
                    }
                    else
                    {
                        status = "Reserved";
                    }
                    dataGridView1.Rows.Add(row.showcaseid, row.size, row.rental, status);
                }
            }
            // Change font color 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Status"].Value.Equals("Available"))
                {
                    row.Cells["Status"].Style.ForeColor = Color.Green;
                } else if (row.Cells["Status"].Value.Equals("Occupied"))
                {
                    row.Cells["Status"].Style.ForeColor = Color.Red;
                } else
                    row.Cells["Status"].Style.ForeColor = Color.Black;
            }
            

            //Filter selected


        }


    }
}
