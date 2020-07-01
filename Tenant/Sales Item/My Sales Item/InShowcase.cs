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
            //Load showcase items  
            using(var db = new sdpEntities())
            {
                var rs = from lsShowcaseItem in db.showcaseitem
                         join lsItem in db.item on lsShowcaseItem.itemid equals lsItem.itemID
                         where lsItem.tenantID.Contains(TenantMain.tenantID)
                         select new
                         {
                             lsItem.itemID,
                             lsShowcaseItem.avalibleQty,
                             lsItem.unitPrice,
                             lsItem.itemName,
                             lsShowcaseItem.showcaseid,
                         };
                foreach(var row in rs.ToList())
                {
                    dataGridView1.Rows.Add(row.itemID, row.itemName, row.showcaseid.Substring(0, 3), row.showcaseid, row.avalibleQty, row.unitPrice);
                }

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Double click to update Item info
            string itemID = "";
            /* foreach (DataGridViewRow row in dataGridView1.SelectedRows)
             {
                 itemID = row.Cells[0].Value.ToString();
             }
             */
            itemID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            UpdateShowcaseItem updateShowcaseItem = new UpdateShowcaseItem(itemID);
            updateShowcaseItem.Show();
        }
    }
}
