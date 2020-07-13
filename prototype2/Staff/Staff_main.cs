using SDP_SE1A_Group2.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2
{
    public partial class Staff_main : Form
    {
        Form opener;
        //Peter start
        String staffID, StaffType;
        //peter end

        public Staff_main(Form parentForm, String staffID, String StaffType)
        {
            InitializeComponent();
            opener = parentForm;
            this.Text = string.Empty;
            this.ControlBox = false;
            //Peter start
            this.staffID = staffID;
            this.StaffType = StaffType;
            //peter end
        }

        

        //Drag From Control 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //Title bar END
        private void label1_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        private void lblMinBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        
        private Form activeForm;
        private void openForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;

            childForm.BringToFront();
            panelChildForm.Controls.Add(childForm);
            childForm.Show();

        }
        private void btnAttendence_Click(object sender, EventArgs e)
        {
            Staff_Attendance staff_attendance = new Staff_Attendance();
            openForm(staff_attendance);
        }


        private void btnReserve_Click(object sender, EventArgs e)
        {
            Staff_showcaseManagment staff_reserve = new Staff_showcaseManagment();
            openForm(staff_reserve);
        }

        private void btnSalesRecord_Click(object sender, EventArgs e)
        {
            Staff_SalesRecord staff_salesrecord = new Staff_SalesRecord();
            openForm(staff_salesrecord);
        }

        private void Staff_main_Load(object sender, EventArgs e)
        {

        }

        
        //Peter start


        private void btnPOS_Click(object sender, EventArgs e)
        {
            Staff_POS staff_pos = new Staff_POS(this);
            openForm(staff_pos);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            openForm(addStaff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editStaffInfo setting = new editStaffInfo(this, staffID);
            openForm(setting);

        }

       
        internal void closeForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }


        public void btnLogOut_Click(object sender, EventArgs e)
        {

            logout();
        }

       

        public void logout()
        {
            this.Close();
            opener.Show();
        }

        //Peter END


    }
}
