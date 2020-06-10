using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Account
{
    public partial class ForgotPasswordForm : Form
    {
        Form opener;
        public ForgotPasswordForm(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }
    }
}
