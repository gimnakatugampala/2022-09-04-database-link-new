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
    public partial class DisplayClient : Form
    {
        public DisplayClient()
        {
            InitializeComponent();
        }

        // SqlConnection con; // Initiate the Pipeline
        // SqlDataAdapter da;     // Initiate the Busket

        DBConnection obj = new DBConnection();

        private void DisplayClient_Load(object sender, EventArgs e)
        {
           // con = new SqlConnection("Data Source=DESKTOP-0UJVAR6;Initial Catalog=Bank2;Integrated Security=True");
        }
                                                                    
        private void btn_view_Click(object sender, EventArgs e)
        {

            string query = "Select * from Client";
            dataGridView1.DataSource = obj.Display(query);
          //  con.Open();
          //  da = new SqlDataAdapter("Select * from Client",con);
           // DataTable dt = new DataTable();
           // da.Fill(dt);
           // dataGridView1.DataSource = dt;
           // con.Close();
        }
    }
}
