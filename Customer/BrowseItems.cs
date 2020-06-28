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
        private int LastSelectedIndex;
        public BrowseItems(CustomerMain opener,String cusName)
        {
            InitializeComponent();
            this.opener = opener;
            lblTitle.Text = "Welcome Customer " + cusName;
            
        }

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opener.CartHvItem()&& LastSelectedIndex != cmbStore.SelectedIndex)
            {
                var confirmResult = MessageBox.Show("If you switch location now, your cart will be clear.", "", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    opener.ClearCart();
                    LastSelectedIndex = cmbStore.SelectedIndex;
                }
                else
                {
                    cmbStore.SelectedIndex= LastSelectedIndex;
                }
            }
            opener.UpdateStore(cmbStore.SelectedIndex);
            LastSelectedIndex = cmbStore.SelectedIndex;

        }
        private void btnShowShopItem_Click(object sender, EventArgs e)
        {
            if (cmbStore.Text=="")
            {
                MessageBox.Show("Select Store First");
                return;
            }
            dataGridView1.Rows.Clear();
            addRows(opener.GetStoreName(cmbStore.SelectedIndex));
        }


        private void addRows(String storeName)
        {
           
            dataGridView1.Rows.Add("123",storeName, "akc123",  "itemName", "idk",30,100);numOfItem = dataGridView1.Rows.Count;
            DataGridViewComboBoxCell cmb = 
                (DataGridViewComboBoxCell)(dataGridView1.Rows[0].Cells["qty"]);
            String[] qty = new String[31];
            for (int a = 0; a <= 30;a++)
            {
                qty[a] = a.ToString();
            }
            cmb.DataSource = qty;
            dataGridView1.Rows[0].Cells["qty"].Value = "0";
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
                int count=0;
                foreach (var i in item.tolist())
                {
                    dataGridView1.Rows.Add(i.showcaseItem.itemID,
                                   i.showcaseItem.showCaseID,
                                   i.showcaseItem.availableQuantity,
                                   i.items.itemName,
                                   i.items.description,
                                   i.items.UnitPrice);
                    DataGridViewComboBoxCell cmb = 
                        (DataGridViewComboBoxCell)(dataGridView1.Rows[count].Cells["qty"]);
                    String[] qty = new string[i.showcaseItem.availableQuantity] ;
                    for(int a =0; a<i.showcaseItem.availableQuantity;a++){
                        qty[a]=a;
                    }
                    cmb.DataSource = qty;
                    count++;
                }numOfItem = dataGridView1.Rows.Count;


                //get item from SQl and Rows.add foreach
            }*/
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
            int row = e.RowIndex;
            if (colum == dataGridView1.Rows[e.RowIndex].Cells["AddToCart"].ColumnIndex && row < numOfItem)
            {
                if (dataGridView1.Rows[row].Cells["qty"].Value == "0")
                {
                    var confirmResult = MessageBox.Show("Choose quantity", "");
                    return;
                }

                String itemID = dataGridView1.Rows[row].Cells["itemID"].Value.ToString();
                String itemName = dataGridView1.Rows[row].Cells["itemName"].Value.ToString();
                String description = dataGridView1.Rows[row].Cells["description"].Value.ToString();
                int qty = int.Parse(dataGridView1.Rows[row].Cells["qty"].Value.ToString());
                int qtyRemain = int.Parse(dataGridView1.Rows[row].Cells["availableQty"].Value.ToString());
                int unitPrice = int.Parse(dataGridView1.Rows[row].Cells["UnitPrice"].Value.ToString());
                int totalPrice= int.Parse(dataGridView1.Rows[row].Cells["totalPrice"].Value.ToString());



                opener.addItem( itemID, itemName, description, qty, qtyRemain, unitPrice, totalPrice);

            }
        }

        
        //update Total price
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Rows[e.RowIndex].Cells["qty"].ColumnIndex)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["qty"].Value != null)
                {
                    var qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["qty"].Value.ToString());
                    var unitPrice = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString());
                    dataGridView1.Rows[e.RowIndex].Cells["totalPrice"].Value = (qty * unitPrice);
                }
            }
        }
    }
}
