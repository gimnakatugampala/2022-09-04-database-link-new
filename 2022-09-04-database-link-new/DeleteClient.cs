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
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();
        }

        // SqlConnection con; // Initiate the Pipeline
        // SqlCommand cmd;     // Initiate the Capsule

        DBConnection obj = new DBConnection();

        private void DeleteClient_Load(object sender, EventArgs e)
        {
          //  con = new SqlConnection("Data Source=DESKTOP-0UJVAR6;Initial Catalog=Bank2;Integrated Security=True");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  con.Open();

            //  cmd = new SqlCommand("Delete from Client where Client_Id = '" + txt_id.Text + "' ", con); // con  - which pipline // sqlcmd is the the capsule

            // int i = cmd.ExecuteNonQuery();
            // if (i == 1)
            //   MessageBox.Show("User Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // else
            //   MessageBox.Show("User Cannot be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            // con.Close();

            string query = "Delete from Client where Client_Id = '" + txt_id.Text + "' ";
            int line = obj.Save_Update_Delete(query);
            if (line == 1)
              MessageBox.Show("User Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
             else
               MessageBox.Show("User Cannot be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
