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

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void Form2MyShowcase_Load(object sender, EventArgs e)
        {
            using (var classicContext = new spdEntities())
            {
                var showcase = (from listrentinfo in classicContext.rentinfo
                                join listshowcase in classicContext.showcase on listrentinfo.showcaseid equals listshowcase.showcaseid
                                where listrentinfo.tenantID.Contains(TenantMain.tenantID)
                                select new { listrentinfo.tenantID, listrentinfo.startDate,listrentinfo.duration,
                                             listshowcase.showcaseid, listshowcase.size,listshowcase.rental, listshowcase.status
                                }) ;
                foreach (var row in showcase.ToList())
                {
                    // if not expired, load data to data grid view
                   if (row.startDate.ToOADate() + row.duration >= DateTime.Now.ToOADate())
                    {
                        dataGridView1.Rows.Add(row.showcaseid, row.size, row.rental, row.status);
                    }
                }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
