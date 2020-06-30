using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Tenant.SalesItem
{
    public partial class InShowcase : Form
    {
        public InShowcase()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InShowcase_Load(object sender, EventArgs e)
        {
            //Load data
            using(var db = new sdpEntities())
            {
                var rs = from resultrentinfo in db.rentinfo
                         from resultitem in db.item
                         join resultSI in db.showcaseitem on resultitem.itemID equals resultSI.itemid
                         where resultitem.tenantID.Contains(TenantMain.tenantID) && resultrentinfo.tenantID.Contains(TenantMain.tenantID)
                         select new
                         {
                             resultitem.itemID,
                             resultSI.avalibleQty,
                             resultitem.unitPrice,
                             resultitem.itemName,
                             resultrentinfo.showcaseid,
                             resultrentinfo.duration,
                             resultrentinfo.startDate
                         };


                foreach (var row in rs.ToList())
                {
                    if (row.startDate.ToOADate() + row.duration >= DateTime.Now.ToOADate())
                        dataGridView1.Rows.Add(row.itemID, row.itemName, row.showcaseid.Substring(0, 3), row.showcaseid, row.avalibleQty, row.unitPrice);
                }

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Update Item info
            string itemID = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                itemID = row.Cells[0].Value.ToString();
            }

            UpdateShowcaseItem updateShowcaseItem = new UpdateShowcaseItem(itemID);
            updateShowcaseItem.Show();
        }
    }
}
