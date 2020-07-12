using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Customer
{
    public partial class Order : Form
    {
        private CustomerMain opener;
        private String cusName, cusID;
        private int numOfOrder,numsOfItem;
        public Order(CustomerMain opener,String cusName,String cusID)
        {
            InitializeComponent();
            this.opener = opener;
            this.cusName = cusName;
            this.cusID= cusID;

            lblTitle.Text = "Welcome Customer " + cusName;

            updateOrderIdList();
        }

        private void btnShowOrderDetail_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(listBoxOrderID.SelectedItem.ToString());

        }

        public void updateOrderIdList()
        {
            listBoxOrderID.Items.Clear();
            using(var db = new sdpEntities())
            {
                var orderList = from order in db.order
                                where order.customerID.Equals(cusID)
                                orderby order.orderID ascending
                                select new { order.orderID};

                foreach (var i in orderList.ToList()){  listBoxOrderID.Items.Add(i.orderID);}
                numOfOrder =listBoxOrderID.Items.Count;
            }
        }
        private void UpdateDataGridView(String orderID)
        {
            dataGridView2.Rows.Clear();
            using (var db = new sdpEntities())
            {
                var orderList = from order in db.order
                                from orderDetail in db.order_detail
                                from itemDetail in db.item
                                from store in db.store
                                where order.orderID.Equals(orderID) && order.orderID == orderDetail.orderID && itemDetail.itemID == orderDetail.itemID&& store.storeID == order.storeID
                                orderby order.orderID ascending
                                select new { order.orderID, store.storeAddress, order.orderDate, orderDetail.itemID, itemDetail.itemName,itemDetail.itemDesc, itemDetail.unitPrice, orderDetail.qty, orderDetail.totalPrice, order.orderTotalPrice };
                String storeName="";
                foreach (var i in orderList.ToList()) { 
                    storeName = i.storeAddress.ToString();
                    dataGridView2.Rows.Add(
                        i.orderID, i.storeAddress, i.orderDate, i.itemID, i.itemName, i.itemDesc, i.unitPrice, i.qty, i.totalPrice
                        );
                }
                txtStoreAddress.Text = "Store address: "+storeName;
            }
        }
    }
}
