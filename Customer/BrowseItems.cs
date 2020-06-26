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
        CustomerMain opener;
        private String iteamID; // store  item id user added        
        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        public BrowseItems(CustomerMain opener)
        {
            InitializeComponent();
            this.opener = opener;
            //C# S1E4: DataGridView with Actionbutton and Onclick
            
          
            dataGridView1.Columns.Add("ItemID", "ID");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addButtonColumn();
            dataGridView1.Columns.Add(btn);
        }

        private void addButtonColumn() { }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //get Item ID
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opener.addItem("abc");
        }
    }
}
