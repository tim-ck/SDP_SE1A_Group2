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
        public Staff_main(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        //Drag From Control 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //Title bar END
        private void lblCloseBtn_Click_1(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        private void lblMinBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void btnPOS_Click(object sender, EventArgs e)
        {
            Staff_POS staff_pos = new Staff_POS();
            openForm(staff_pos);
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
            Staff_Reserve staff_reserve = new Staff_Reserve();
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

        private void btnShowcase_Click(object sender, EventArgs e)
        {
            Staff_showcaseManagment showcase = new Staff_showcaseManagment();
            openForm(showcase);


        }
    }
}
