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
    public partial class Staff_Attendance : Form
    {
        public Staff_Attendance()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            /* (connect database part)
            string constring = "database=[db name];port=[...];username=[...]";
            string sql = "INSERT INTO [db table name] VALUES []";
            SqlConnection conDataBase = new MySqlConnection(conString);
            SqlCommand cmdDataBase = new MySqlCommand(Query,conDataBase);
            MySqlDataReader myReader;
            try{
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader('"+this.txtStaffID.Text+"','"+this.txtWorkHour.Text"');
                    MessageBox.Show("Uploaded");
                while(myReader.Read()){
                
                }
            }catch(Exception e){

            }
            */
        }
    }
}
