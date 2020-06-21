using SDP_SE1A_Group2.Tenant.SalesItem;
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
    public partial class TenantMySalesItem : Form
    {
        public TenantMySalesItem()
        {
            InitializeComponent();
        }

        #region Open Form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            panelChildForm.Controls.Add(childForm);
            childForm.Show();
        }
        #endregion


        private void btnInShowcase_Click(object sender, EventArgs e)
        {
            InShowcase inShowcase = new InShowcase();
            openChildForm(inShowcase);
        }

        private void btnWaitForStockIn_Click(object sender, EventArgs e)
        {
            WaitForStockIn waitForStockIn = new WaitForStockIn();
            openChildForm(waitForStockIn);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
