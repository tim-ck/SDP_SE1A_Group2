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
        public static String tenantID;
        public static String tenantName;


        public TenantMain(String id, String name)
        {
            InitializeComponent();
            tenantID = id;
            tenantName = name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome  " + tenantName;

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
            TenantMyShowcase form2myShowcase = new TenantMyShowcase();
            openChildForm(form2myShowcase);
        }

        private void btnRentShowcase_Click(object sender, EventArgs e)
        {
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

        private void btnMySalesItem_Click(object sender, EventArgs e)
        {
            TenantMySalesItem tenantMySalesItem = new TenantMySalesItem();
            openChildForm(tenantMySalesItem);
      
        }

        private void btnStockInItem_Click(object sender, EventArgs e)
        {
            TenantStockInItem tenantMySalesItem = new TenantStockInItem();
            openChildForm(tenantMySalesItem);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TenantShowcaseSalesRecord tenantCheckSalesRecord = new TenantShowcaseSalesRecord();
            openChildForm(tenantCheckSalesRecord);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TenantConsolidatedStatement tenantConsolidatedStatement = new TenantConsolidatedStatement();
            openChildForm(tenantConsolidatedStatement);
        }
    }
}
