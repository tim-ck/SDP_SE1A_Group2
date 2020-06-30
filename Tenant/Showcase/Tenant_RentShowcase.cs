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
            //rent or reserve
            string showcaseID = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                showcaseID = row.Cells[0].Value.ToString();
            }


            RentShowcase rentShowcase = new RentShowcase(showcaseID);

            rentShowcase.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TenantRentShowcase_Load(object sender, EventArgs e)
        {
            //Set dafault value
            cboLocation.SelectedIndex = 0;
            cboSize.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;

            //Load showcase data from db
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            using (var classicContext = new sdpEntities())
            {
                var showcase = (from list in classicContext.showcase
                           select list);    // select * from employees

                foreach (var row in showcase.ToList())
                {
                    dataGridView1.Rows.Add(row.showcaseid, row.size, row.rental, row.status);
                }
            }


            //Filter selected


        }


    }
}
