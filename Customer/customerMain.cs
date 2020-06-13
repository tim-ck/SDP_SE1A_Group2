using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Customer
{
    public partial class CustomerMain : Form
    {
        Form opener;
        private Form activeForm = null;
        public CustomerMain(Form parentForm, String username)
        {
            InitializeComponent();
            opener = parentForm;
            this.Text
        }

       

        private void openChildForm(Form childForm)
        {
            if (activeForm!= null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            panelChildForm.Controls.Add(childForm);
            childForm.Show();
        }

        private void CustomerMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseItemPage_Click(object sender, EventArgs e)
        {
            BrowseItems browseItemForm = new BrowseItems();
            openChildForm(browseItemForm);
        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        
    }
}
