using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace _2022_09_04_database_link_new
{
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
        }

        // SqlConnection con; // Initiate the Pipeline
        // SqlCommand cmd;     // Initiate the Capsule

        DBConnection obj = new DBConnection();

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=DESKTOP-0UJVAR6;Initial Catalog=Bank2;Integrated Security=True");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //  con.Open();

            //  cmd = new SqlCommand("Update Client set Client_Name = '"+txt_name.Text+"' , Client_Address = '"+txt_address.Text+"' , Client_DOB = '"+dob_picker.Value+"' , Client_Age = '"+txt_age.Text+"' , Client_TP = '"+txt_tp.Text+"' where Client_Id = '"+txt_id.Text+"' ",con); // con  - which pipline // sqlcmd is the the capsule

            //  int i = cmd.ExecuteNonQuery();
            //  if (i == 1)
            //     MessageBox.Show("Data Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // else
            //   MessageBox.Show("Data Cannot be Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            // con.Close();
            string query = "Update Client set Client_Name = '" + txt_name.Text + "' , Client_Address = '" + txt_address.Text + "' , Client_DOB = '" + dob_picker.Value + "' , Client_Age = '" + txt_age.Text + "' , Client_TP = '" + txt_tp.Text + "' where Client_Id = '" + txt_id.Text + "' ";
            int line = obj.Save_Update_Delete(query);
              if (line == 1)
                 MessageBox.Show("Data Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
             else
               MessageBox.Show("Data Cannot be Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
