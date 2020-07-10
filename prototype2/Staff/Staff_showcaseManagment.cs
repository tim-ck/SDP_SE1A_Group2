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
    public partial class Staff_showcaseManagment : Form
    {

        public Staff_showcaseManagment()
        {
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
                var showcaseList = from showcase in db.showcase
                                orderby showcase.showcaseid ascending
                                select new { showcase.showcaseid };

                foreach (var i in showcaseList.ToList()) { listBoxShowcaseID.Items.Add(i.showcaseid); }
            }
            
        }

        private void UpdateRentalRecordDataGridView(string showcaseID)
        {
            dataGridViewRentalRecord.Rows.Clear();
            using (var db = new sdpEntities())
            {//update showcaseInfo

                var showcaseInfo = from storeList in db.store
                                   from showcaseList in db.showcase
                                   where showcaseList.showcaseid.Contains(showcaseID) && storeList.storeID == showcaseList.storeID
                                   select new
                                   {
                                       storeList.storeAddress,
                                       showcaseList.showcaseid,
                                       showcaseList.size,
                                       showcaseList.status
                                   };
                var detail = showcaseInfo.ToList();
                if (detail != null)
                {
                    txtStoreAddress.Text = "Store address: " + detail[0].storeAddress.ToString();
                    txtShowCaseID.Text = "Showcase ID: " + detail[0].showcaseid.ToString();
                    txtShowcaseSize.Text = "Showcase Size: " + detail[0].size.ToString();
                    string status;
                    //Convert status code to word
                    if (detail[0].status.ToString() == "a")
                    {
                        status = "Available";
                    }
                    else if (detail[0].status.ToString() == "o")
                    {
                        status = "Occupied";
                    }
                    else
                    {
                        status = "Reserved";
                    }
                    txtStatus.Text = "Status: " + status;
                }

                //update showcase record
                var showcaseRentalList = from rentRecord in db.rentinfo
                                        where rentRecord.showcaseid.Contains(showcaseID)
                                        select new
                                       {
                                           rentRecord.rentID,
                                           rentRecord.tenantID,
                                           rentRecord.startDate,
                                           rentRecord.duration,


                                       };

                foreach (var i in showcaseRentalList.ToList())
                {
                    var endDate = i.startDate.AddDays(i.duration).ToString("yyyy-MM-dd");
                    var startDate = i.startDate.ToString("yyyy-MM-dd");


                    dataGridViewRentalRecord.Rows.Add(
                        i.rentID, i.tenantID, startDate, i.duration, endDate
                        );

                }
            }
        }
        private void UpdateItemDataGridView(String showcaseID)
        {
            dataGridViewItem.Rows.Clear();
            using (var db = new sdpEntities())
            {
                //update showcaseInfo

                var showcaseInfo = from storeList in db.store
                                   from showcaseList in db.showcase
                                   where showcaseList.showcaseid.Contains(showcaseID) && storeList.storeID == showcaseList.storeID
                                   select new
                                   {
                                       storeList.storeAddress,
                                       showcaseList.showcaseid,
                                       showcaseList.size,
                                       showcaseList.status
                                   };
                var detail = showcaseInfo.ToList();
                if (detail != null)
                {
                    txtStoreAddress.Text = "Store address: " + detail[0].storeAddress.ToString();
                    txtShowCaseID.Text = "Showcase ID: "+detail[0].showcaseid.ToString();
                    txtShowcaseSize.Text = "Showcase Size: " + detail[0].size.ToString();
                    string status;
                    //Convert status code to word
                    if (detail[0].status.ToString()=="a")
                    {
                        status = "Available";
                    }
                    else if (detail[0].status.ToString()=="o")
                    {
                        status = "Occupied";
                    }
                    else
                    {
                        status = "Reserved";
                    }
                    txtStatus.Text = "Status: " + status;
                }

                //update showcase Items
                var showcaseitemList =  from showcaseitems in db.showcaseitem
                                        from item in db.item
                                        where showcaseitems.showcaseid.Contains(showcaseID) && showcaseitems.itemid == item.itemID
                                   select new
                                   {
                                       showcaseitems.itemid,
                                       item.itemName,
                                       item.itemDesc,
                                       item.unitPrice,
                                       showcaseitems.availableQty,
                                       showcaseitems.availability,
                                       showcaseitems.soldQty

                                   };

                foreach (var i in showcaseitemList.ToList())
                {
                    String available = "";
                    if (i.availability == 1)
                    {
                        available = "available";
                    }
                    else
                    {
                        available = "not available";
                    }
                    dataGridViewItem.Rows.Add(
                        i.itemid, i.itemName, i.itemDesc, i.unitPrice,i.availableQty, available, i.soldQty
                        );
                    
                }
            }
        }

        

        //Update view End


        //btnClick behaviour
        private void btnShowShowcaseRecord_Click(object sender, EventArgs e)
        {
            dataGridViewItem.Hide();
            dataGridViewRentalRecord.Show();
            UpdateRentalRecordDataGridView(listBoxShowcaseID.SelectedItem.ToString());
        }

        

      
        private void btnShowItemList_Click(object sender, EventArgs e)
        {
            dataGridViewItem.Show();
            dataGridViewRentalRecord.Hide();
            if (listBoxShowcaseID.SelectedItem == null)
            {
                MessageBox.Show("Select a Showcase ID");
            }

            UpdateItemDataGridView(listBoxShowcaseID.SelectedItem.ToString());
        }

        private void dataGridViewItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
