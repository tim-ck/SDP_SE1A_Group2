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
        pt_workinghours attendance = new pt_workinghours();
        public Staff_Attendance()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            attendence.staffID = int.Parse(txtStaffID.Text.Trim());
            attendence.month = DateTime.Parse(txtMonth.Text.Trim());
            attendence.hour = int.Parse(txtWorkHour.Text.Trim());

            using(DBEntities2 db = new DBEntities2())
=======
            attendance.staffID = txtStaffID.Text.Trim();
            attendance.month = int.Parse(txtMonth.Text.Trim());
            attendance.hour = int.Parse(txtWorkHour.Text.Trim());

            using(DBEntities1 db = new DBEntities1())
>>>>>>> parent of 8fcec7f... DIU
            {
                db.pt_workinghours.Add(attendance);
                db.SaveChanges();
            }

            MessageBox.Show("Submitted Successfully");

            
        }

        private void Staff_Attendance_Load(object sender, EventArgs e)
        {
            using (DBEntities2 print = new DBEntities2())
            {
                var atten = (from list in print.pt_workinghours
                             select list);    // select * from employees

                foreach (var atten2 in atten.ToList())
                {
                    dataGridView1.Rows.Add(atten2.staffID, atten2.month, atten2.hour);
                }
            }
        }


    }
}
