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
        private CustomerMain opener;
        private int numOfItem=0; // store  number of item       
        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        
        public BrowseItems(CustomerMain opener,String cusName)
        {
            InitializeComponent();
            this.opener = opener;
            lblTitle.Text = "Welcome Customer " + cusName;
            cmbStore.SelectedIndex = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            //C# S1E4: DataGridView with Actionbutton and Onclick



        }

        private void btnShowShopItem_Click(object sender, EventArgs e)
        {
            
            if (opener.CartHvItem())
            {
                var confirmResult = MessageBox.Show("If you switch location now, your cart will be clear.", "", MessageBoxButtons.OKCancel);
                if(confirmResult == DialogResult.OK)
                {
                    opener.ClearCart();
                    dataGridView1.Rows.Clear();
                    addRows(opener.GetStoreName(cmbStore.SelectedIndex));
                }
                else
                {
                    return;
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                addRows(opener.GetStoreName(cmbStore.SelectedIndex));


            }

        }


        private void addRows(String storeName)
        {
           
            dataGridView1.Rows.Add("123",storeName, "akc123", 2, "itemName", "idk", "$30");
            DataGridViewComboBoxCell cmb = 
                (DataGridViewComboBoxCell)(dataGridView1.Rows[0].Cells["qty"]);
            cmb.DataSource = new string[] { "80", "100" };
            /*using (var notSoImportantVariable = new classicmodelsEntities())
            {
                var item = from items in notSoImportantVariable.item
                           from showcaseItem in notSoImportantVariable.showcase_item
                           where showcaseItem.showcaseID.Contains(storeName) && items.itemID == showcaseItem.itemID
                           select new
                           {
                               showcaseItem.itemID,
                               showcaseItem.showCaseID,
                               showcaseItem.availableQuantity,
                               items.itemName,
                               items.description,
                               items.UnitPrice
                           };
                foreach (var i in item.tolist())
                {
                    dataGridView1.Rows.Add(i.showcaseItem.itemID,
                                   i.showcaseItem.showCaseID,
                                   i.showcaseItem.availableQuantity,
                                   i.items.itemName,
                                   i.items.description,
                                   i.items.UnitPrice);
                    DataGridViewComboBoxCell cmb = 
                (DataGridViewComboBoxCell)(dataGridView1.Rows[numOfItem].Cells["qty"]);
                String[] qty = new string[i.showcaseItem.availableQuantity] ;
                for(int a =0; a<i.showcaseItem.availableQuantity;){
                    qty[a]=++a;
                }
                cmb.DataSource = qty;
                    numOfItem++;
                }


                //get item from SQl and Rows.add foreach
            }*/
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8&&e.RowIndex<= numOfItem)
                opener.addItem("abc123", "3");
        }



        

        
    }
}
