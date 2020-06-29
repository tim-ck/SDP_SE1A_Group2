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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TenantStockInItem_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            String itemName;
            float price;
            int qty;
            String desc;
            using (var db = new spdEntities())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string rs = db.Database.SqlQuery<string>("Select MAX(preinputitemid) from preinputitem").FirstOrDefault<string>();
                    itemName = row.Cells[1].Value.ToString();
                    desc = row.Cells[2].Value.ToString();
                    qty = int.Parse(row.Cells[3].Value.ToString());
                    price = int.Parse(row.Cells[4].Value.ToString());

                    string sql = "insert into preinputitem(preinputitemid,itemname, itemqty, itemdesc, itemunitprice, tenantid) values('" + rs + "', + '" + itemName + "', + )"
                    int noOfRowInserted = db.Database.ExecuteSqlCommand("")
                    ExecuteSqlCommand("Insert into preinputitem(preinputitemid,itemname, itemqty, itemdesc, itemunitprice, tenantid) values('" + rs + "', '" +  +"')



    
                    //More code here
                }









                for (int i=0; i<dataGridView1.RowCount; i++)
                {
                    string rs = db.Database.SqlQuery<string>("Select MAX(preinputitemid) from preinputitem").FirstOrDefault<string>();
                }

                Insert command
                int noOfRowInserted = db.Database.
                    ExecuteSqlCommand("Insert into preinputitem(preinputitemid,itemname, itemqty, itemdesc, itemunitprice, tenantid) values('" + rs + "', )




}

        }
    }
}
