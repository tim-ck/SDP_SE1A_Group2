using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2.Staff
{
    public partial class ShowcaseManagement : Form
    {
        int count;
        public ShowcaseManagement()
        {
            InitializeComponent();
            importShowcase();
        }

        private void importShowcase()
        {
            using (var db = new sdpEntities())
            {
                var showcases = (from list in db.showcases
                                 select list);
                count = 0;
                foreach (var i in showcases.ToList())
                {
                    dataGridView1.Rows.Add(i.showcaseid,i.size,i.rental,i.status);
                    count++;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int row = e.RowIndex;
            if (colum == dataGridView1.Rows[row].Cells["btnRent"].ColumnIndex && row < count)
            {
                MessageBox.Show("");

            }

        }
    }
}

