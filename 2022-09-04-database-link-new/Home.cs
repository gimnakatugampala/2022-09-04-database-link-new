using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_09_04_database_link_new
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateClient obj = new UpdateClient();
            obj.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteClient obj = new DeleteClient();
            obj.ShowDialog();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            DisplayClient obj = new DisplayClient();
            obj.ShowDialog();
        }

        private void btn_ClientReport_Click(object sender, EventArgs e)
        {
            ClientReport obj = new ClientReport();
            obj.ShowDialog();
        }

        private void btn_ReportbyID_Click(object sender, EventArgs e)
        {
            ClientReportbyID obj = new ClientReportbyID();
            obj.ShowDialog();
        }

        private void btn_ReportbyDOB_Click(object sender, EventArgs e)
        {
            ClientReportbyDOB obj = new ClientReportbyDOB();
            obj.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
