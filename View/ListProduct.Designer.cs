namespace crud_project_winform
{
    partial class ListProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataProduk = new DataGridView();
            btnTambahProduk = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProduk).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 63);
            label1.Name = "label1";
            label1.Size = new Size(238, 46);
            label1.TabIndex = 0;
            label1.Text = "Daftar Produk";
            // 
            // dataProduk
            // 
            dataProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProduk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataProduk.ColumnHeadersHeight = 50;
            dataProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataProduk.Location = new Point(57, 149);
            dataProduk.Name = "dataProduk";
            dataProduk.RowHeadersWidth = 51;
            dataProduk.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataProduk.Size = new Size(983, 480);
            dataProduk.TabIndex = 1;
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.Location = new Point(888, 63);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(152, 45);
            btnTambahProduk.TabIndex = 2;
            btnTambahProduk.Text = "Tambah Produk";
            btnTambahProduk.UseVisualStyleBackColor = true;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // ListProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 685);
            Controls.Add(btnTambahProduk);
            Controls.Add(dataProduk);
            Controls.Add(label1);
            Name = "ListProduct";
            Text = "Form1";
            Load += ListProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataProduk;
        private Button btnTambahProduk;
    }
}
