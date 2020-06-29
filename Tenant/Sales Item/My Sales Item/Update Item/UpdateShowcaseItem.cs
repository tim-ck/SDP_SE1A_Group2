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
    public partial class UpdateShowcaseItem : Form
    {
        String itemID;
        public UpdateShowcaseItem(String id)
        {
            InitializeComponent();

            itemID = id;


        }

        private void UpdateShowcaseItem_Load(object sender, EventArgs e)
        {
            using (var db = new spdEntities())
            {
                var rs = (from result in db.item
                          where result.itemID.Contains(itemID)
                                select result);    // select * from employees

                foreach (var row in rs.ToList())
                {
                    txtName.Text = row.itemName;
                    txtPrice.Text = row.unitPrice.ToString();
                    txtDescription.Text = row.itemDesc;
                    txtQty.Text = row.itemQty.ToString();

                    if (row.availability.Equals(1))
                    {
                        radAva.Checked = true;
                    }
                    else
                    {
                        radUava.Checked = true;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
