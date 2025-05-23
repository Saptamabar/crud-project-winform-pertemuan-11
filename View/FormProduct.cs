using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud_project_winform.Controller;
using crud_project_winform.Model;

namespace crud_project_winform
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nama_produk = textNamaProduk.Text;
            int harga = Convert.ToInt32(textHargaProduct.Text);
            string deskripsi = textDeskripsi.Text;

            ProductModel product = new ProductModel
            {
                nama_produk = nama_produk,
                harga = harga,
                deskripsi = deskripsi
            };

            ProductController.InsertProducts(product);

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
