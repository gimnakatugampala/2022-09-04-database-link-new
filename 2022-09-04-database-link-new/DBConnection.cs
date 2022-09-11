using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.net Class Library
using System.Data; // Data Table

namespace _2022_09_04_database_link_new
{
    class DBConnection
    {
        SqlConnection con; // Initiate the Pipline
        SqlCommand cmd; // Initiate the Capsule

        public DBConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-0UJVAR6;Initial Catalog=Bank3;Integrated Security=True");
        }

        public int Save_Update_Delete(string q)
        {
            con.Open();
            cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public DataTable Display(string q)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
