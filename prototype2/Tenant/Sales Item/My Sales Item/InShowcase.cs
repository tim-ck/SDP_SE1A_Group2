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
                var rs = from lsShowcaseItem in db.showcaseitem
                         join lsItem in db.item on lsShowcaseItem.itemid equals lsItem.itemID
                         where lsItem.tenantID.Contains(TenantMain.tenantID)
                         select new
                         {
                             lsItem.itemID,
                             lsShowcaseItem.availableQty,
                             lsItem.unitPrice,
                             lsItem.itemName,
                             lsShowcaseItem.showcaseid,
                         };
                foreach (var row in rs.ToList())
                {
                    int index = dataGridView1.Rows.Count + 1;
                    dataGridView1.Rows.Add(index, row.itemID, row.itemName, row.showcaseid.Substring(0, 3), row.showcaseid, row.availableQty, row.unitPrice);
                    index++;
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
            cbLocation.SelectedIndex = 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Double click to update Item info
            string itemID = dataGridView1.CurrentRow.Cells["itemID"].Value.ToString();

            UpdateShowcaseItem updateShowcaseItem = new UpdateShowcaseItem(itemID, this);
            updateShowcaseItem.Show();
        }



        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearDgv();
            loadDgv();

            if (cbLocation.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.Cells["Location"].Value.ToString().Equals(cbLocation.SelectedItem.ToString().ToLower()))
                    {
                        row.Visible = false;
                    }
                }
            }
        }
    }
}
