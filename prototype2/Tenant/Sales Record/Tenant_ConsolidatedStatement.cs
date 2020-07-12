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
    public partial class TenantConsolidatedStatement : Form
    {
        DateTime now = DateTime.Now;
        public TenantConsolidatedStatement()
        {
            InitializeComponent();
        }

        private int calValidDay(DateTime sDate, int duration, int month, int year)
        {
            
            //Lease period should at least covers 1 st of selected month
            if (sDate.AddDays(duration) >= new DateTime(year, month, 01))
            {
                //Case1: Just rented in the current month (The statement will update daily within the selected month)
                if (sDate.Month == month && sDate.Year == year && sDate.AddDays(duration) > now)
                {
                    MessageBox.Show("Called case1: Just rented in the current month (The statement will update daily within the selected month)");
                    return now.Day;
                }
                //Case3: Lease period crossing months
                else if (sDate <= new DateTime(year, month, 01) && sDate.AddDays(duration).Month >= month)
                {
                    MessageBox.Show("3 called");
                    int endDayOfMonth = DateTime.DaysInMonth(year, month);
                    //Case3.1: The last day end before the end of the month
                    if (sDate.AddDays(duration).Month == month)
                    {
                        MessageBox.Show("Case3.1: The last day end by the end-day of the month(the whole period crossing month) ");
                        return sDate.AddDays(duration).Day -1;
                    }
                    //Case3.2: Lease period crosses the selected month
                    //else if (sDate.AddDays(duration).Day < endDayOfMonth && sDate.AddDays(duration).Month > month)
                    else
                    {
                        MessageBox.Show("Case3.2: Lease period crosses the selected month");
                        return DateTime.DaysInMonth(year, month);
                    }
                }
                //Case2: Lease start and end in the same month
                else if (sDate.Month == month && sDate.Year == year)
                {
                    MessageBox.Show("Case2: Lease start and end in the same month");
                    return sDate.AddDays(duration).Day - 1;
                }
                else
                {
                    MessageBox.Show("Have showcase but..");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("No renting record in this month:" + month + "/" + year);
                return 0;
            }




        }
            
              
        

        private void Tenant_ConsolidatedStatement_Load(object sender, EventArgs e)
        {
            // Populate CboYear
            using (var db = new sdpEntities())
            {

                var rs = from lsRentInfo in db.rentinfo
                         where lsRentInfo.tenantID.Contains(TenantMain.tenantID)
                         select lsRentInfo.startDate;
                if (rs.Any())
                {
                    foreach (var row in rs.ToList())
                    {

                        for (int i = row.Year; i <= DateTime.Now.Year; i++)
                        {
                            cboYear.Items.Add(i);
                        }
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("You do not have any renting record", "System Message");
                    btnView.Enabled = false;
                }
            }
        }

        private bool isRenting(DateTime sDate, int duration, int month, int year)
        {
            return ((sDate.Month == month && sDate.Year == year) || (sDate.AddDays(duration).Month == month && sDate.Year == year));
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.Items.Clear();
            //Populate cboMonth values
            if (int.Parse(cboYear.SelectedItem.ToString()) == now.Year)
            {
                for (int i = 1; i <= DateTime.Now.Month; i++)
                    cboMonth.Items.Add(i);
                cboMonth.SelectedIndex = 0;
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                    cboMonth.Items.Add(i);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(cboYear.Text);
            int selectedMonth = int.Parse(cboMonth.Text);


            //Load Overview: Rental
            using (var db = new sdpEntities())
            {
                var rs = from lsRentinfo in db.rentinfo
                         join lsShowcase in db.showcase on lsRentinfo.showcaseid equals lsShowcase.showcaseid
                         where lsRentinfo.tenantID.Contains(TenantMain.tenantID)
                         select new
                         {
                             lsRentinfo.startDate,
                             lsRentinfo.duration,
                             lsShowcase.rental
                         };



                int totalRental = 0;
                foreach (var row in rs.ToList())
                {
                    DateTime leaseStartDate = row.startDate;
                    DateTime leaseEndDate = leaseStartDate.AddDays(row.duration);

                    //Examine valid rent record in the selected month
                    totalRental += calValidDay(leaseStartDate, row.duration, selectedMonth, selectedYear) * (int)row.rental;
                }
                lblRental.Text = totalRental.ToString();


                //Load Overview: Renvenue
                float revenue = 0;
                var rs1 = from lsOrder in db.order
                          join lsOrderDetail in db.order_detail on lsOrder.orderID equals lsOrderDetail.orderID
                          select new
                          {
                              lsOrder.orderID,
                              lsOrder.orderDate,
                              lsOrderDetail.itemID,
                              lsOrderDetail.qty,
                              lsOrder.storeID
                          };

                var rs2 = from lsItem in db.item
                          join lsTenant in db.tenant on lsItem.tenantID equals lsTenant.tenantID
                          where lsItem.tenantID.Contains(TenantMain.tenantID)
                          select lsItem;


                double salecwb = 0;
                double salekwf = 0;
                double salemka = 0;
                double salemkb = 0;
                double salesht = 0;





                foreach (var row1 in rs1.ToList())
                {
                    if (row1.orderDate.Month == selectedMonth)
                    {
                        foreach (var row2 in rs2.ToList())
                        {
                            if (row2.itemID == row1.itemID)
                            {
                                revenue += row2.unitPrice * row1.qty;
                                //SD
                                if (row1.storeID.Equals("cwb"))
                                {
                                    salecwb += row2.unitPrice * row1.qty;
                                }else if (row1.storeID.Equals("kwf"))
                                {
                                    salekwf += row2.unitPrice * row1.qty;
                                }else if (row1.storeID.Equals("mka"))
                                {
                                    salemka += row2.unitPrice * row1.qty;
                                }else if (row1.storeID.Equals("mkb"))
                                {
                                    salemkb += row2.unitPrice * row1.qty;
                                }
                                else
                                {
                                    salesht += row2.unitPrice * row1.qty;
                                }
                            }
                        }
                    }
                }
                //SD
                if (revenue > 0)
                {
                    lblCwbSD.Text = (salecwb / revenue * 100).ToString();
                    lblMkaSD.Text = (salemka / revenue * 100).ToString();
                    lblMkbSD.Text = (salemkb / revenue * 100).ToString();
                    lblShtSD.Text = (salesht / revenue * 100).ToString();
                    lblKwfSD.Text = (salekwf / revenue * 100).ToString();
                }
                

                lblRevenue.Text = revenue.ToString();
                //Load Overview: Profit
                lblProfit.Text = (float.Parse(lblRevenue.Text) - float.Parse(lblRental.Text)).ToString();
                if (float.Parse(lblRevenue.Text) - float.Parse(lblRental.Text) > 0)
                {
                    lblProfit.ForeColor = Color.Green;
                }
                else
                {
                    lblProfit.ForeColor = Color.Red;
                }

                //Load Showcase Number
                int numCWB = 0;
                int numKWF = 0;
                int numMKA = 0;
                int numMKB = 0;
                int numSHT = 0;

                var rs3 = from lsRentInfo in db.rentinfo
                          where lsRentInfo.tenantID.Contains(TenantMain.tenantID)
                          select lsRentInfo;

                foreach (var row in rs3.ToList())
                {

                    if (isRenting(row.startDate, row.duration, selectedMonth, selectedYear))
                    {
                        if (row.storeID.Equals("cwb"))
                        {
                            MessageBox.Show("Add CWB");
                            numCWB++;
                        }
                        else if (row.storeID.Equals("kwf"))
                        {
                            numKWF++;
                        }
                        else if (row.storeID.Equals("mka"))
                        {
                            numMKA++;
                        }
                        else if (row.storeID.Equals("mkb"))
                        {
                            numMKB++;
                        }
                        else if (row.storeID.Equals("sht"))
                        {
                            numSHT++;
                        }
                        else
                        {
                            MessageBox.Show("Wrong StoreID: " + row.storeID);
                        }
                    }
                }
                lblCwbQty.Text = numCWB.ToString();
                lblKwfQty.Text = numKWF.ToString();
                lblMkaQty.Text = numMKA.ToString();
                lblMkbQty.Text = numMKB.ToString();
                lblShtQty.Text = numSHT.ToString();


                //Load dgv --> showcas, item, order, order detail
                var rs4 = from lsShowcaseItem in db.showcaseitem
                          join lsItem in db.item on lsShowcaseItem.itemid equals lsItem.itemID
                          where lsItem.tenantID.Contains(TenantMain.tenantID)

                          


                          
                          select new
                          {
                              lsShowcaseItem.showcaseid,
                              
                              lsItem.itemID,
                              lsItem.tenantID,
                              lsItem.itemName
                          };

                var rs5 = from lsOrder in db.order
                          join lsOrderDetail in db.order_detail on lsOrder.orderID equals lsOrderDetail.orderID
                          select new
                          {
                              lsOrderDetail.unitPrice,
                              lsOrderDetail.qty,
                              lsOrder.orderDate,
                          };


                int index;
                string location;
                string showcaseid;
                string itemid;
                string itemname;
                double unitprice;
                int qty;
                double subtotal;
                DateTime solddate;

                foreach(var row in rs4.ToList())
                {
                    foreach(var row2 in rs5.ToList())
                    {
                        if (row2.orderDate.Month == int.Parse(cboMonth.Text))
                        {
                            index = dataGridView1.Rows.Count + 1;
                            location = row.showcaseid.Substring(0, 3);
                            showcaseid = row.showcaseid;
                            itemid = row.itemID;
                            itemname = row.itemName;
                            unitprice = row2.unitPrice;
                            qty = row2.qty;
                            subtotal = unitprice * qty;
                            solddate = row2.orderDate;

                            dataGridView1.Rows.Add(index, location, showcaseid, itemid, itemname,
                                 unitprice, qty, subtotal, solddate);
                        }
                    }
                    
                    
                }


            }

        }

    }

}





    



