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
          //Load item info
            using (var db = new sdpEntities())
            {
                var rs = from lsShowcaseItem in db.showcaseitem
                          join lsItem in db.item on lsShowcaseItem.itemid equals lsItem.itemID
                          where lsShowcaseItem.itemid.Contains(itemID)
                          select new { lsItem.itemName,
                                       lsItem.unitPrice,
                                       lsItem.itemDesc,
                                       lsShowcaseItem.avalibleQty,
                                       lsShowcaseItem.availability
                                     };

                foreach (var row in rs.ToList())
                {
                    txtName.Text = row.itemName;
                    txtPrice.Text = row.unitPrice.ToString();
                    txtDescription.Text = row.itemDesc;
                    txtQty.Text = row.avalibleQty.ToString();

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
            //txtName.Text = "ID: " + itemID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
