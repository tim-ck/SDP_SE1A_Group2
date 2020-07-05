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
    public partial class WaitForStockIn : Form
    {
        public WaitForStockIn()
        {
            InitializeComponent();
        }

        //Load data from table: "preinputitem" to dataGridView1
        public void loadDgv()
        {
            using (var db = new sdpEntities())
            {
                var rs = from result in db.preinputitems
                         where result.tenantid.Contains(TenantMain.tenantID)
                         select result;

                foreach (var row in rs.ToList())
                {
                    dataGridView2.Rows.Add(dataGridView2.RowCount + 1,
                                            row.preinputitemid,
                                            row.itemname,
                                            row.itemdesc,
                                            row.itemqty,
                                            row.itemunitprice);
                }

            }
        }

        public void clearDgv()
        {
            dataGridView2.Rows.Clear();
        }


        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {

            //Open new form to update item info
            string id="";

            id = dataGridView2.CurrentRow.Cells["id"].Value.ToString();
            
            UpdateImportItem updateImportItem = new UpdateImportItem(id, this);
            updateImportItem.Show();
        }

        private void WaitForStockIn_Load(object sender, EventArgs e)
        {
            loadDgv();
        }
    }
}
