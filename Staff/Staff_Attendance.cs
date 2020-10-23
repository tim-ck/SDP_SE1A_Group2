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
    public partial class Staff_Attendance : Form
    {
        staff staff = new staff();
        attendence attendence = new attendence();
        public Staff_Attendance()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string id = txtStaffID.Text;
            string month = dtpMonth.Value.ToString("yyyy-MM");

            using (sdpEntities db = new sdpEntities())
            {
                var result = db.attendences.SingleOrDefault(b => b.staffID == id && b.month == month);
                if (result != null)
                {
                    int h = int.Parse(txtWorkHour.Text.Trim());
                    result.hour += h;
                    result.month = month;
                    db.SaveChanges();
                    MessageBox.Show("Submitted Successfully");
                    updateDate();
                }
                else
                {
                    MessageBox.Show("Staff ID not found");
                }
            }
        }

        private void Staff_Attendance_Load(object sender, EventArgs e)
        {
            updateDate();
        }
        public void updateDate()
        {
            dataGridView1.Rows.Clear();
            using (sdpEntities print = new  sdpEntities())
            {
                var atten = (from list in print.attendences
                             select list);    // select * from attendence

                foreach (var atten2 in atten.ToList())
                {
                    dataGridView1.Rows.Add(atten2.staffID, atten2.month, atten2.hour);
                }
            }
        }


    }
}
