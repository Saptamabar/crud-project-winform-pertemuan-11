using crud_project_winform.Controller;

namespace crud_project_winform
{
    public partial class ListProduct : Form
    {
        public ListProduct()
        {
            InitializeComponent();
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            dataProduk.DataSource = ProductController.GetAllProducts();
            if (!dataProduk.Columns.Contains("edit"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "Edit";
                btnedit.Name = "Edit";
                btnedit.HeaderText = "Edit"; 
                btnedit.UseColumnTextForButtonValue = true;
                dataProduk.Columns.Add(btnedit);
            }

            if (!dataProduk.Columns.Contains("hapus"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "hapus";
                btnedit.Name = "hapus";
                btnedit.HeaderText = "hapus";
                btnedit.UseColumnTextForButtonValue = true;
                dataProduk.Columns.Add(btnedit);

            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            FormProduct formProduk = new FormProduct();
            formProduk.Show();
            this.Hide();
        }
    }
}
