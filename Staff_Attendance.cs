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
        attendence attendence = new attendence();
        public Staff_Attendance()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            attendence.staffID = int.Parse(txtStaffID.Text.Trim());
            attendence.month = DateTime.Parse(txtMonth.Text.Trim());
            attendence.hour = int.Parse(txtWorkHour.Text.Trim());

            using(DBEntities2 db = new DBEntities2())
            {
                db.attendence.Add(attendence);
                db.SaveChanges();
            }

            MessageBox.Show("Submitted Successfully");

            
        }

        private void Staff_Attendance_Load(object sender, EventArgs e)
        {
            using (DBEntities2 print = new DBEntities2())
            {
                var atten = (from list in print.attendence
                             select list);    // select * from employees

                foreach (var atten2 in atten.ToList())
                {
                    dataGridView1.Rows.Add(atten2.staffID, atten2.month, atten2.hour);
                }
            }
        }


    }
}
