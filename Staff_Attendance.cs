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
                
                var insertAttendance = "INSERT into tbl_staff (staffID,workHour) VALUES (id,hour)";

                using (SqlCommand querySaveStaff = new SqlCommand(insertAttendance))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@staffName", SqlDbType.VarChar, 30).Value = name;
                    .....
                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();
                }
            }
            */
        }
    }
}
