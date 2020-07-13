﻿using SDP_SE1A_Group2.Customer;
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
            dataGridViewItem.Rows.Clear();
            using (var db = new sdpEntities())
            {
                var showcaseList = from showcase in db.showcase
                                   from rentinfo in db.rentinfo
                                   from store in db.store
                                   where showcase.showcaseid.Equals(showcaseID) && showcase.showcaseid == rentinfo.showcaseid && store.storeID == showcase.showcaseid
                                   orderby rentinfo.rentID ascending
                                   select new { store.storeAddress, showcase.showcaseid, showcase.size, showcase.status  };
               
                var showcaseDetail = showcaseList.ToList();
                txtStoreAddress.Text = showcaseDetail[0].storeAddress.ToString();
                txtShowCaseID.Text = showcaseDetail[0].showcaseid.ToString();
                txtShowcaseSize.Text = showcaseDetail[0].size.ToString();
                txtStatus.Text = showcaseDetail[0].status.ToString();

                foreach (var i in showcaseList.ToList())
                {
                    dataGridViewItem.Rows.Add(
                        );
                }
                
            }
        }
        private void UpdateItemDataGridView(String showcaseID)
        {
            dataGridViewItem.Rows.Clear();
            using (var db = new sdpEntities())
            {
                var showcaseList = from showcase in db.showcase
                                   from showcaseitem in db.showcaseitem
                                   from itemDetail in db.item
                                   from store in db.store
                                   where showcase.showcaseid.Equals(showcaseID) && showcase.showcaseid == showcaseitem .showcaseid&& itemDetail.itemID == showcaseitem.itemid && store.storeID == showcase.showcaseid
                                   orderby itemDetail.itemID ascending
                                   select new { store.storeAddress, showcase.showcaseid, showcase.size,showcase.status, showcaseitem.availableQty, showcaseitem.soldQty, showcaseitem.TotalQty, itemDetail};
                var showcaseDetail = showcaseList.ToList();
                txtStoreAddress.Text = showcaseDetail[0].storeAddress.ToString();
                txtShowCaseID.Text = showcaseDetail[0].showcaseid.ToString();
                txtShowcaseSize.Text = showcaseDetail[0].size.ToString();
                txtStatus.Text = showcaseDetail[0].status.ToString();

                foreach (var i in showcaseList.ToList())
                {
                    dataGridViewItem.Rows.Add(
                        i.itemDetail.itemID, i.itemDetail.itemName, i.itemDetail.itemDesc, i.itemDetail.unitPrice,i.availableQty,i.soldQty
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

        

      
        private void btnShowItemList_Click(object sender, EventArgs e)
        {
            UpdateItemDataGridView(listBoxShowcaseID.SelectedItem.ToString());
        }

        private void dataGridViewItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}