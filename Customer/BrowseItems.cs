using System;
using System.Collections;
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
    public partial class BrowseItems : Form
    {
        private String userID;
        private String iteamID; // store  item id user added        

        public BrowseItems(String userID, Stack item)
        {
            InitializeComponent();
            this.userID = userID;
            this.item = item;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //get Item ID
        }

        private void BrowseItems_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ItemID","ID");
            dataGridView1.Columns.Add("test", "test");
            dataGridView1.Rows.Add("123", "test1");
        }
    }
}
