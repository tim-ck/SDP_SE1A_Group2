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
            if (sDate.AddDays(duration) >= new DateTime(year, month, 1))
            {
                //Case1: Just rented in the current month (The statement will update daily within the selected month)
                if (sDate.Month == month && sDate.Year == year && sDate.AddDays(duration) > now)
                {
                    MessageBox.Show("Called case1: Just rented in the current month (The statement will update daily within the selected month)");
                    return now.Day;
                }
                //Case2: Lease start and end in the same month
                else if (sDate.Month == month && sDate.Year == year)
                {
                    MessageBox.Show("Case2: Lease start and end in the same month");
                    return DateTime.DaysInMonth(year, month);
                }

                //Case3: Lease period crossing months
                else if (sDate <= new DateTime(year, month, 1) && sDate.AddDays(duration) >= new DateTime(year, month, 1))
                {
                    MessageBox.Show("3 called");
                    int endDayOfMonth = DateTime.DaysInMonth(year, month);
                    //Case3.1: Lease period end before the end of the month
                    if (sDate.AddDays(duration).Day <= endDayOfMonth && sDate.AddDays(duration).Month == month)
                    {
                        MessageBox.Show("Case3.1: Lease end by the end-day of the month");
                        return sDate.AddDays(duration).Day;
                    }
                    //Case3.2: Lease period crosses the selected month
                    else if (sDate.AddDays(duration).Day < endDayOfMonth && sDate.AddDays(duration).Month > month)
                    
                    {
                        MessageBox.Show("Case3.2: Lease period crosses the selected month");
                        return DateTime.DaysInMonth(year, month);
                    }
                }
            }
            return 0;
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

                    int selectedYear = int.Parse(cboYear.Text);
                    int selectedMonth = int.Parse(cboMonth.Text);

                    int totalRental = 0;
                    foreach (var row in rs.ToList())
                    {
                        DateTime leaseStartDate = row.startDate;
                        DateTime leaseEndDate = leaseStartDate.AddDays(row.duration);

                        //Examine valid rent record in the selected month
                        totalRental += calValidDay(leaseStartDate, row.duration, selectedMonth, selectedYear) * (int)row.rental;
                    }
                    lblRental.Text = totalRental.ToString();
                }
               
            }

        }

    }



    



