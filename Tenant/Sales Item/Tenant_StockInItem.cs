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
    public partial class TenantStockInItem : Form
    {
        public TenantStockInItem()
        {
            InitializeComponent();
        }

        private void TenantStockInItem_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add input data to dataGridView1
            this.dataGridView1.Rows.Add(dataGridView1.RowCount + 1,
                                           txtName.Text,
                                           txtDesc.Text,
                                           txtQty.Text,
                                           txtPrice.Text);

            txtName.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Insert row to table: "preinputitem"
            using (var db = new sdpEntities())
            {
                
                int itemAdded = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string newID = (!db.preinputitem.Any()) ? (newID = "001") : (int.Parse(db.preinputitem.Max(p => p.preinputitemid)) + 1).ToString("D3");
                    string name = row.Cells["name"].Value.ToString();
                    string desc = row.Cells["desc"].Value.ToString(); ;
                    int qty = int.Parse(row.Cells["qty"].Value.ToString());
                    float unitPrice = float.Parse(row.Cells["unitPrice"].Value.ToString());

                    string sql = "Insert into preinputitem(preinputitemid, itemname, itemqty, itemdesc, itemunitprice, tenantid) values('" + newID + "', '" + name + "', '" + qty + "','" + desc + "','" + unitPrice + "','" + TenantMain.tenantID + "')";
                    int noOfRowInserted = db.Database.ExecuteSqlCommand(sql);

                    itemAdded++;
                }
                MessageBox.Show(itemAdded + "item(s) add successfully", "System Message");
                dataGridView1.Rows.Clear();
            }

        }
    }
}

