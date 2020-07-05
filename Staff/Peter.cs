using SDP_SE1A_Group2.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Staff
{
    public partial class Peter : Form
    {

        CustomerMain opener;
        public Peter(CustomerMain opener)
        {
            this.opener = opener;
            InitializeComponent();
            UpdateListBox();
        }




        //Update view START

        private void UpdateListBox()
        {
            listBoxShowcaseID.Items.Clear();
            using (var db = new sdpEntities())
            {
                var showcaseList = from showcase in db.showcases
                                orderby showcase.showcaseid ascending
                                select new { showcase.showcaseid };

                foreach (var i in showcaseList.ToList()) { listBoxShowcaseID.Items.Add(i.showcaseid); }
            }
            
        }


        private void UpdateDataGridView(String showcaseID)
        {
            dataGridView1.Rows.Clear();
            using (var db = new sdpEntities())
            {
                var showcaseList = from showcase in db.showcases
                                   from showcaseitem in db.showcaseitems
                                   from itemDetail in db.items
                                   where showcase.showcaseid.Equals(showcaseID) && showcase.showcaseid == showcaseitem .showcaseid&& itemDetail.itemID == showcaseitem.itemid
                                   orderby itemDetail.itemID ascending
                                   select new { showcase, showcaseitem, itemDetail };
                String storeName = "";
                foreach (var i in showcaseList.ToList())
                {
                    storeName = i.showcase.
                    dataGridView1.Rows.Add(
                        i.orderID, i.storeName, i.orderDate, i.itemID, i.itemName, i.itemDesc, i.unitPrice, i.qty, i.totalPrice
                        );
                }
                txtStoreAddress.Text = "Store address: " + storeName;
            }
        }


        //Update view End


        //btnClick behaviour
        private void btnShowShowcaseRecord_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(listBoxShowcaseID.SelectedItem.ToString());
        }

        private void btnRentPage_Click(object sender, EventArgs e)
        {
            Peter1 peter1 = new Peter1();
            opener.openChildForm(peter1);
        }
    }
}
