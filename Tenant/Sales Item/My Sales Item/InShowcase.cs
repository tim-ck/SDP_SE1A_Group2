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
    public partial class InShowcase : Form
    {
        public InShowcase()
        {
            InitializeComponent();
        }

        public void loadDgv()
        {
            //Load showcase items  
            using (var db = new sdpEntities())
            {
                var rs = from lsShowcaseItem in db.showcaseitems
                         join lsItem in db.items on lsShowcaseItem.itemid equals lsItem.itemID
                         where lsItem.tenantID.Contains(TenantMain.tenantID)
                         select new
                         {
                             lsItem.itemID,
                             lsShowcaseItem.avalibleQty,
                             lsItem.unitPrice,
                             lsItem.itemName,
                             lsShowcaseItem.showcaseid,
                         };
                foreach (var row in rs.ToList())
                {
                    dataGridView1.Rows.Add(row.itemID, row.itemName, row.showcaseid.Substring(0, 3), row.showcaseid, row.avalibleQty, row.unitPrice);
                }

            }
        }

        public void clearDgv()
        {
            dataGridView1.Rows.Clear();
        }

        private void InShowcase_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Double click to update Item info
            string itemID = "";
            itemID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            UpdateShowcaseItem updateShowcaseItem = new UpdateShowcaseItem(itemID, this);
            updateShowcaseItem.Show();
        }
    }
}
