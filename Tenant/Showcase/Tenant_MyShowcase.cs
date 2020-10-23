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
    public partial class TenantMyShowcase : Form
    {
        public TenantMyShowcase()
        {
            InitializeComponent();
        }

        private void changeStatusColor()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["scStatus"].Value.Equals("Available"))
                {
                    row.Cells["scStatus"].Style.ForeColor = Color.Green;
                }
                else if (row.Cells["scStatus"].Value.Equals("Occupied"))
                {
                    row.Cells["scStatus"].Style.ForeColor = Color.Red;
                }
                else
                    row.Cells["scStatus"].Style.ForeColor = Color.Black;
            }
        }

        public void loadPassRecord()
        {
            dataGridView1.Rows.Clear();
            using (var classicContext = new sdpEntities())
            {
                var showcase = from listrentinfo in classicContext.rentinfoes
                               join listshowcase in classicContext.showcases on listrentinfo.showcaseid equals listshowcase.showcaseid
                               where listrentinfo.tenantID.Contains(TenantMain.tenantID)
                               select new
                               {
                                   listrentinfo.tenantID,
                                   listrentinfo.startDate,
                                   listrentinfo.duration,
                                   listshowcase.showcaseid,
                                   listshowcase.size,
                                   listshowcase.rental,
                                   listshowcase.status
                               };
                foreach (var row in showcase.ToList())
                {
                    // Show pass record only
                    if (row.startDate.AddDays(row.duration) < DateTime.Now)
                    {
                        dataGridView1.Rows.Add(row.showcaseid, row.size, row.rental,row.startDate, row.startDate.AddDays(row.duration));
                    }
                }
            }
            this.dataGridView1.Columns["scStatus"].Visible = false;
        }

        public void loadCurrentRecord()
        {
            dataGridView1.Rows.Clear();
            using (var classicContext = new sdpEntities())
            {
                var showcase = from listrentinfo in classicContext.rentinfoes
                               join listshowcase in classicContext.showcases on listrentinfo.showcaseid equals listshowcase.showcaseid
                               where listrentinfo.tenantID.Contains(TenantMain.tenantID)
                               select new
                               {
                                   listrentinfo.tenantID,
                                   listrentinfo.startDate,
                                   listrentinfo.duration,
                                   listshowcase.showcaseid,
                                   listshowcase.size,
                                   listshowcase.rental,
                                   listshowcase.status
                               };
                foreach (var row in showcase.ToList())
                {
                    // Show pass record only
                    if (row.startDate.AddDays(row.duration) >= DateTime.Now)
                    {
                        string status;
                        //Convert status code to word
                        if (row.status.Equals("a"))
                        {
                            status = "Available";
                        }
                        else if (row.status.Equals("o"))
                        {
                            status = "Occupied";
                        }
                        else
                        {
                            status = "Reserved";
                        }
                        dataGridView1.Rows.Add(row.showcaseid, row.size, row.rental, row.startDate, row.startDate.AddDays(row.duration), status);
                    }
                }

            }
            changeStatusColor();
            this.dataGridView1.Columns["scStatus"].Visible = true;
        }



        private void Form2MyShowcase_Load(object sender, EventArgs e)
        {
            loadCurrentRecord();
        }

        private void radCurrent_CheckedChanged(object sender, EventArgs e)
        {
            loadCurrentRecord();
        }

        private void radOld_CheckedChanged(object sender, EventArgs e)
        {
            loadPassRecord();
        }
    }
}
