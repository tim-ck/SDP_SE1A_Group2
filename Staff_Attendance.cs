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
        public Staff_Attendance()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String id = txtStaffID.Text;
            int hour = int.Parse(txtWorkHour.Text);
            /*
            using (var classicContext = new classicmodelsEntities())
            {
                var insertAttendance = "INSERT INTO (table name) (staffID,workHour) VALUES (id,hour)";

                using (SqlCommand querySaveStaff = new SqlCommand(insertAttendance))
                {
                    
                }
            }
            */

            MessageBox.Show("Staff ID:"+id+"\r\n"+"Hour: "+hour + "\r\n"+"Submitted Successfully");
        }

        private void Staff_Attendance_Load(object sender, EventArgs e)
        {

        }
    }
}
