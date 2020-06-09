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
    public partial class TenantMain : Form
    {
        public TenantMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        #region Hide/ShowSubMenu
        private void hideSubMenu()
        {
            panelShowcaseSubMenu.Visible = false;
            panelSalesItemSubMenu.Visible = false;
            panelRecordSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                hideSubMenu();
            else
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void btnShowcase_Click(object sender, EventArgs e)
        {
            showSubMenu(panelShowcaseSubMenu);
        }

        private void btnSalesItem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSalesItemSubMenu);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRecordSubMenu);
        }

        #endregion

        private void btnMyShowcase_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            TenantMyShowcase form2myShowcase = new TenantMyShowcase();
            openChildForm(form2myShowcase);
        }

        private void btnRentShowcase_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            TenantRentShowcase form2rentShowcase = new TenantRentShowcase();
            openChildForm(form2rentShowcase);
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
    }
}
