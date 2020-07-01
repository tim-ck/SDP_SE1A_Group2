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
    public partial class TenantConsolidatedStatement : Form
    {
        public TenantConsolidatedStatement()
        {
            InitializeComponent();
        }

        private void Tenant_ConsolidatedStatement_Load(object sender, EventArgs e)
        {
            // Load CboYear
            using (var db = new sdpEntities())
            {
                var rs = from lsRentInfo in db.rentinfo
                         where lsRentInfo.tenantID.Contains(TenantMain.tenantID)
                         select lsRentInfo.startDate;


                foreach (var row in rs.ToList())
                {
                    
                    for(int i = row.Year; i <= DateTime.Now.Year; i++)
                    {
                        cboYear.Items.Add(i);
                    }
                    break;
                }



            }
                
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
