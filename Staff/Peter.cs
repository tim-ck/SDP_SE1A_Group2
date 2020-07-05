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
            dataGridViewRentalRecord.Hide();
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

        private void UpdateRentalRecordDataGridView(string showcaseID)
        {
            dataGridViewItem.Rows.Clear();
            using (var db = new sdpEntities())
            {
                var showcaseList = from showcase in db.showcases
                                   from reservations in db.reservations
                                   from rentinfo in db.rentinfoes
                                   where showcase.showcaseid.Equals(showcaseID) && showcase.showcaseid ==  reservations.showcaseid&& reservations.reservationid == rentinfo.reservationid
                                   orderby reservations.reservationid ascending
                                   select new { showcase.storeAddress, showcase.showcaseid, showcase.size, showcase.status, reservations.reservationid,  };
               
                var showcaseDetail = showcaseList.ToList();
                txtStoreAddress.Text = showcaseDetail[0].storeAddress.ToString();
                txtShowCaseID.Text = showcaseDetail[0].showcaseid.ToString();
                txtShowcaseSize.Text = showcaseDetail[0].size.ToString();
                txtStatus.Text = showcaseDetail[0].status.ToString();

                foreach (var i in showcaseList.ToList())
                {
                    dataGridViewItem.Rows.Add(
                        i.itemDetail.itemID, i.itemDetail.itemName, i.itemDetail.itemDesc, i.itemDetail.unitPrice, i.avalibleQty, i.soldQty
                        );
                }
                
            }
        }
        private void UpdateItemDataGridView(String showcaseID)
        {
            dataGridViewItem.Rows.Clear();
            using (var db = new sdpEntities())
            {
                var showcaseList = from showcase in db.showcases
                                   from showcaseitem in db.showcaseitems
                                   from itemDetail in db.items
                                   where showcase.showcaseid.Equals(showcaseID) && showcase.showcaseid == showcaseitem .showcaseid&& itemDetail.itemID == showcaseitem.itemid
                                   orderby itemDetail.itemID ascending
                                   select new { showcase.storeAddress, showcase.showcaseid, showcase.size,showcase.status, showcaseitem.avalibleQty, showcaseitem.soldQty, showcaseitem.TotalQty, itemDetail};
                var showcaseDetail = showcaseList.ToList();
                txtStoreAddress.Text = showcaseDetail[0].storeAddress.ToString();
                txtShowCaseID.Text = showcaseDetail[0].showcaseid.ToString();
                txtShowcaseSize.Text = showcaseDetail[0].size.ToString();
                txtStatus.Text = showcaseDetail[0].status.ToString();

                foreach (var i in showcaseList.ToList())
                {
                    dataGridViewItem.Rows.Add(
                        i.itemDetail.itemID, i.itemDetail.itemName, i.itemDetail.itemDesc, i.itemDetail.unitPrice,i.avalibleQty,i.soldQty
                        );
                }
            }
        }

        

        //Update view End


        //btnClick behaviour
        private void btnShowShowcaseRecord_Click(object sender, EventArgs e)
        {
            UpdateRentalRecordDataGridView(listBoxShowcaseID.SelectedItem.ToString());
        }

        

        private void btnRentPage_Click(object sender, EventArgs e)
        {
            Peter1 peter1 = new Peter1();
            opener.openChildForm(peter1);
        }

        private void btnShowItemList_Click(object sender, EventArgs e)
        {
            UpdateItemDataGridView(listBoxShowcaseID.SelectedItem.ToString());
        }

        private void dataGridViewItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
