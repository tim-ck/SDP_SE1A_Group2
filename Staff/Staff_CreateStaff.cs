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
    public partial class Staff_CreateStaff : Form
    {
        public Staff_CreateStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtStaffID.Text);
            String pwd = txtPwd.Text;
            String email = txtEmail.Text;
            String name = txtName.Text;
            String staffType = cmbStaffType.SelectedText;
            float salary = float.Parse(txtSalary.Text);

            using (var context = new sdpEntities())
            {
                var std = new Student()
                {
                    FirstName = "Bill",
                    LastName = "Gates"
                };
                context.Students.Add(std);

                context.SaveChanges();
            }
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
