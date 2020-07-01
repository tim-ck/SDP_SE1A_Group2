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
    public partial class TenantShowcaseSalesRecord : Form
    {
        public TenantShowcaseSalesRecord()
        {
            InitializeComponent();
        }

        private void TenantCheckSalesRecord_Load(object sender, EventArgs e)
        {
            //Load sales record
            using (var db = new sdpEntities()){
                var rs = from lsItem in db.item
                         join lsShowcaseItem in db.showcaseitem on lsItem.itemID equals lsShowcaseItem.itemid
                         where lsItem.tenantID.Contains(TenantMain.tenantID)

                         from lsOrder_detail in db.order_detail
                         where lsOrder_detail.itemID.Contains(lsItem.itemID)

                         from lsOrder in db.order
                         where lsOrder.orderID.Contains(lsOrder_detail.orderID)

                         select new
                         {
                             lsItem.itemID,
                             lsItem.itemName,
                             lsItem.unitPrice,
                             lsShowcaseItem.showcaseid,
                             lsShowcaseItem.soldQty,
                             lsOrder.orderDate
                         };

                foreach(var row in rs.ToList())
                {
                    int index = 1;
                    dataGridView1.Rows.Add(index, row.showcaseid, row.itemID, row.itemName, row.unitPrice, row.soldQty, (row.soldQty * row.unitPrice), row.orderDate);
                    index++;
                }
            }
        }
    }
}
