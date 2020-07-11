using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_SE1A_Group2
{
    public partial class UpdateShowcaseItem : Form
    {
        String _itemID;
        InShowcase _owner;
        string fileName;
        string folder = "C:\\picture";
        string pathString;




        public UpdateShowcaseItem(String id, InShowcase owner)
        {
            InitializeComponent();
            _itemID = id;
            _owner = owner;
        }

        private void uploadImage()
        {
            using (var ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(fileName);
                }
                lblPath.Text = fileName;
            }
        }


        private void loadItemInfo()
        {
            //Load item info
            lblID.Text = _itemID;
            using (var db = new sdpEntities())
            {
                var rs = from lsShowcaseItem in db.showcaseitem
                         join lsItem in db.item on lsShowcaseItem.itemid equals lsItem.itemID
                         where lsShowcaseItem.itemid.Contains(_itemID)
                         select new
                         {
                             lsItem.itemName,
                             lsItem.unitPrice,
                             lsItem.itemDesc,
                             lsShowcaseItem.availableQty,
                             lsShowcaseItem.availability
                         };

                foreach (var row in rs.ToList())
                {
                    txtName.Text = row.itemName;
                    txtPrice.Text = row.unitPrice.ToString();
                    txtDescription.Text = row.itemDesc;
                    txtQty.Text = row.availableQty.ToString();

                    if (row.availability.Equals(1))
                    {
                        radAva.Checked = true;
                    }
                    else
                    {
                        radUava.Checked = true;
                    }
                }
                // Open Image locally using path from table: "itemimage".picture
                var rsImg = from lsItemimage in db.itemimage
                            where lsItemimage.itemID.Contains(_itemID)
                            select lsItemimage;

                foreach (var row in rsImg.ToList())
                {
                    //
                }
                
            }

        }



        

        private void UpdateShowcaseItem_Load(object sender, EventArgs e)
        {
            loadItemInfo();
        }

     

        private void btnImport_Click(object sender, EventArgs e)
        {
            pathString = Path.Combine(folder, fileName);
            //Update table: "item" / "ShowcaseItem"
            using (var db = new sdpEntities())
            {
                string newName = txtName.Text.ToString();
                string sql = "Update item set itemName ='" + newName + "' where itemID='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newPrice = txtPrice.Text.ToString();
                sql = "Update item set unitPrice ='" + newPrice + "' where itemID='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newQty = txtQty.Text.ToString();
                sql = "Update showcaseitem set availableQty ='" + newQty + "' where itemID='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                int newStatus = radAva.Checked ? 1 : 0;
                sql = "Update showcaseitem set availability ='" + newStatus + "' where itemID='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                string newDesc = txtDescription.Text.ToString();
                sql = "Update item set itemDesc ='" + newDesc + "' where itemID='" + _itemID + "'";
                db.Database.ExecuteSqlCommand(sql);

                //Insert image path to "Itemimage"
                pictureBox1.Image.Save(pathString, ImageFormat.Jpeg);
                string newID = (!db.itemimage.Any()) ? (newID = "001") : (int.Parse(db.itemimage.Max(p => p.itemImageID)) + 1).ToString("D3");
                sql = "Insert into itemimage(itemImageID, filename, picture, itemID) values('" + newID + "', '" + fileName.Replace(@"\", @"\\") + "', '" + pathString.Replace(@"\", @"\\") + "', '" + _itemID + "')";

                db.Database.ExecuteSqlCommand(sql);

                

                MessageBox.Show("Updated successfully!", "System Message");
                this.Close();
            }
        }

        private void UpdateShowcaseItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.clearDgv();
            _owner.loadDgv();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            uploadImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
