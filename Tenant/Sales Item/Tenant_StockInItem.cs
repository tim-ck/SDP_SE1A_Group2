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
        //!!!!!!!!!!!!!!!//
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (var db = new sdpEntities())
            {
                //Insert row to table: "preinputitem"
                string newID = (!db.preinputitem.Any()) ? (newID = "001") : (int.Parse(db.preinputitem.Max(p => p.preinputitemid)) + 1).ToString("D3");

                string sql = "Insert into preinputitem(preinputid, itemname, itemqty, itemdesc, itemprice, tenantid) values('" + newID + "', '" + TenantMain.tenantID + "', '" + lblShowcaseId.Text.ToString() + "')";
                int noOfRowInserted = db.Database.ExecuteSqlCommand(sql);

                if (noOfRowInserted == 1)
                {
                    string msg = "You have reserve the following showcase successfully:\r\n" + lblShowcaseId.Text.ToString();
                    MessageBox.Show(msg, "System Message");

                    //Update table: "Showcase" value: "Stutas" to "r"
                    sql = "Update showcase set status ='r' where showcaseid='" + lblShowcaseId.Text.ToString() + "'";
                    int noOfRowUpdated = db.Database.ExecuteSqlCommand(sql);

                    this.Close();
                }

            }
}

