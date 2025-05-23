using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_project_winform.View
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            ViewDashboard viewDashboard = new ViewDashboard();
            panelcontent.Controls.Add(viewDashboard);
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panelcontent.Controls.Clear();
            ViewDashboard viewDashboard = new ViewDashboard();
            panelcontent.Controls.Add(viewDashboard);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelcontent.Controls.Clear();
            ViewProduk viewproduk = new ViewProduk();
            panelcontent.Controls.Add(viewproduk);
        }
    }
}
