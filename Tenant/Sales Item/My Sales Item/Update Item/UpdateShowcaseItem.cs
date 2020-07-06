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
    public partial class UpdateShowcaseItem : Form
    {
        String itemID;
        InShowcase _owner;
        public UpdateShowcaseItem(String id, InShowcase owner)
        {
            InitializeComponent();
            itemID = id;
            _owner = owner;
        }

        private void loadItemInfo()
        {
            //Load item info
            lblID.Text = itemID;
            using (var db = new sdpEntities())
            {
                var rs = from lsShowcaseItem in db.showcaseitems
                         join lsItem in db.items on lsShowcaseItem.itemid equals lsItem.itemID
                         where lsShowcaseItem.itemid.Contains(itemID)
                         select new
                         {
                             lsItem.itemName,
                             lsItem.unitPrice,
                             lsItem.itemDesc,
                             lsShowcaseItem.availableQty,
                             lsShowcaseItem.availability
                         };

                foreach (var row in rs.ToList())
                {
                    txtName.Text = row.itemName;
                    txtPrice.Text = row.unitPrice.ToString();
                    txtDescription.Text = row.itemDesc;
                    txtQty.Text = row.availableQty.ToString();

                    if (row.availability.Equals(1))
                    {
                        radAva.Checked = true;
                    }
                    else
                    {
                        radUava.Checked = true;
                    }
                }
            }

        }

        private void UpdateShowcaseItem_Load(object sender, EventArgs e)
        {
            loadItemInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Update table: "item" / "ShowcaseItem"
            using (var db = new sdpEntities())
            {
                string newName = txtName.Text.ToString();
                string sql = "Update item set itemName ='" + newName + "' where itemID='" + itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newPrice = txtPrice.Text.ToString();
                sql = "Update item set unitPrice ='" + newPrice + "' where itemID='" + itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newQty = txtQty.Text.ToString();
                sql = "Update showcaseitem set availableQty ='" + newQty + "' where itemID='" + itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                int newStatus = radAva.Checked ? 1 : 0;
                sql = "Update showcaseitem set availability ='" + newStatus + "' where itemID='" + itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newDesc = txtDescription.Text.ToString();
                sql = "Update item set itemDesc ='" + newDesc + "' where itemID='" + itemID + "'";
                db.Database.ExecuteSqlCommand(sql);


                MessageBox.Show("Updated successfully!", "System Message");
                this.Close();
            }
        }

        private void UpdateShowcaseItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.clearDgv();
            _owner.loadDgv();
        }
    }
}
