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
            int id = int.Parse(txtStaffID.Text.Trim());
            int month = int.Parse(cmbMonth.SelectedItem.ToString());

            using (DBEntities db = new DBEntities())
            {
                var atten = (from list in db.staff
                             select list.staffID);
                foreach (var atten2 in atten.ToList())
                {
                    if(atten2 == id)
                    {
                        attendence.month = month;
                        attendence.hour = int.Parse(txtWorkHour.Text.Trim());

                        db.attendence.Add(attendence);
                        db.SaveChanges();

                        MessageBox.Show("Submitted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Staff ID not found");
                    }
                }
            }         
        }

        private void Staff_Attendance_Load(object sender, EventArgs e)
        {
            using (DBEntities print = new DBEntities())
            {
                var atten = (from list in print.attendence
                             select list);    // select * from attendence

                foreach (var atten2 in atten.ToList())
                {
                    dataGridView1.Rows.Add(atten2.staffID, atten2.month, atten2.hour);
                }
            }
        }


    }
}
