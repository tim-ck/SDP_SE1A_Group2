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
    public partial class Staff_main : Form
    {
        public Staff_main()
        {
            InitializeComponent();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            Staff_Export staff_export = new Staff_Export();
            openForm(staff_export);
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
    }
}
