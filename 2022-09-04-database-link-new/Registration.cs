using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient; // ADO.net Class Library
using System.Windows.Forms;

namespace _2022_09_04_database_link_new
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        //SqlConnection con; // Initiate the Pipeline
        //SqlCommand cmd;     // Initiate the Capsule


        DBConnection obj = new DBConnection();
        // Now Default Construtor automatically runs

        private void Registration_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=DESKTOP-0UJVAR6;Initial Catalog=Bank2;Integrated Security=True");
         

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // string id, name, address;
            //DateTime dob;
            //int age, tp;

            //     id = txt_id.Text;
            //   name = txt_name.Text;
            // address = txt_address.Text;
            // dob = dob_picker.Value;

            //age = Convert.ToInt32(txt_age.Text);
            //tp = Convert.ToInt32(txt_tp.Text);

            //con.Open();

            //cmd = new SqlCommand("Insert into Client values ('"+txt_id.Text+"', '"+txt_name.Text+"', '"+txt_address.Text+"', '"+dob_picker.Value+"', '"+txt_age.Text+"', '"+txt_tp.Text+"')",con);
            //int i = cmd.ExecuteNonQuery();
            //if (i == 1)
            //  MessageBox.Show("Data Save Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //  MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //cmd.Parameters.AddWithValue("a",id);
            //cmd.Parameters.AddWithValue("b", name);
            //cmd.Parameters.AddWithValue("c", address);
            //cmd.Parameters.AddWithValue("d", dob);
            //cmd.Parameters.AddWithValue("e", age);
            //cmd.Parameters.AddWithValue("f", tp);



            // con.Close();


            string query = "Insert into Client values ('" + txt_id.Text + "', '" + txt_name.Text + "', '" + txt_address.Text + "', '" + dob_picker.Value + "', '" + txt_age.Text + "', '" + txt_tp.Text + "')";
            int line =  obj.Save_Update_Delete(query);

            if (line == 1)
             MessageBox.Show("Data Save Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
              MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void dob_picker_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dob_picker.Value.Year;
            txt_age.Text = age.ToString();

            txt_age.ReadOnly = true;
        }
    }
}
