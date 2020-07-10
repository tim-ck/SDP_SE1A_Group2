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
    public partial class UpdateImportItem : Form
    {
        private string _itemID;
        private WaitForStockIn _owner;
        public UpdateImportItem(string itemID, WaitForStockIn owner)
        {
            InitializeComponent();
            _itemID = itemID;
            _owner = owner;
        }

        private void loadData()
        {
            using (var db = new sdpEntities())
            {
                var rs = from lsPreinputitem in db.preinputitem
                         where lsPreinputitem.preinputitemid.Contains(_itemID)
                         select lsPreinputitem;

                foreach(var row in rs.ToList())
                {
                    txtName.Text = row.itemname.ToString();
                    txtPrice.Text = row.itemunitprice.ToString();
                    txtQty.Text = row.itemqty.ToString();
                    txtDesc.Text = row.itemdesc.ToString();
                }
            }
        }

        private void UpdateImportItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
       
        //Update table: "preinputitem"
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new sdpEntities())
            {
                string newName = txtName.Text.ToString();
                string sql = "Update preinputitem set itemname ='" + newName + "' where preinputitemid='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newPrice = txtPrice.Text.ToString();
                sql = "Update preinputitem set itemunitPrice ='" + newPrice + "' where preinputitemid='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newQty = txtQty.Text.ToString();
                sql = "Update preinputitem set itemqty ='" + newQty + "' where preinputitemid='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newDesc = txtDesc.Text.ToString();
                sql = "Update preinputitem set itemDesc ='" + newDesc + "' where preinputitemid='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);


                MessageBox.Show("Updated successfully!", "System Message");
                this.Close();
            }
        }

        private void UpdateImportItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.clearDgv();
            _owner.loadDgv();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete item: " + _itemID, "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                using (var db = new sdpEntities())
                {
                    string sql = "Delete from preinputitem where preinputitemid=" + _itemID;
                    int noOfRowDeleted = db.Database.ExecuteSqlCommand(sql);
                    if (noOfRowDeleted == 1)
                    {
                        MessageBox.Show("Item: " + _itemID + " is deleted successfully");
                    }
                    this.Close();
                }

                    
            }

        }
    }
}
