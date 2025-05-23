using crud_project_winform.Controller;
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
    public partial class ViewProduk : UserControl
    {
        public ViewProduk()
        {
            InitializeComponent();
        }

        private void ViewProduk_Load(object sender, EventArgs e)
        {
            dataproduct.DataSource = ProductController.GetAllProducts();
            if (!dataproduct.Columns.Contains("edit"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "Edit";
                btnedit.Name = "Edit";
                btnedit.HeaderText = "Edit";
                btnedit.UseColumnTextForButtonValue = true;
                dataproduct.Columns.Add(btnedit);
            }

            if (!dataproduct.Columns.Contains("hapus"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "hapus";
                btnedit.Name = "hapus";
                btnedit.HeaderText = "hapus";
                btnedit.UseColumnTextForButtonValue = true;
                dataproduct.Columns.Add(btnedit);

            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormProduct formproduct = new FormProduct();
            formproduct.Show();
        }
    }
}
