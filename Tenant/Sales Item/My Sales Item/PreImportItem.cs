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
    public partial class WaitForStockIn : Form
    {
        public WaitForStockIn()
        {
            InitializeComponent();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            // update item info
            UpdateImportItem updateImportItem = new UpdateImportItem();
            updateImportItem.Show();
        }

        private void WaitForStockIn_Load(object sender, EventArgs e)
        {
            //load data
            using (var db = new sdpEntities())
            {
                var rs = from result in db.preinputitem
                         where result.tenantid.Contains(TenantMain.tenantID)
                         select result;

                foreach (var row in rs.ToList())
                {
                    dataGridView2.Rows.Add( dataGridView2.RowCount,
                                            row.itemname,
                                            row.itemdesc,
                                            row.itemqty,
                                            row.itemunitprice);
                }

            }
        }
    }
}
