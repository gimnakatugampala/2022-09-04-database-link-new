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
    public partial class ClientReport : Form
    {
        public ClientReport()
        {
            InitializeComponent();
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
