namespace crud_project_winform.View
{
    partial class ViewProduk
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataproduct = new DataGridView();
            label1 = new Label();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dataproduct).BeginInit();
            SuspendLayout();
            // 
            // dataproduct
            // 
            dataproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataproduct.Location = new Point(98, 190);
            dataproduct.Name = "dataproduct";
            dataproduct.RowHeadersWidth = 51;
            dataproduct.Size = new Size(737, 314);
            dataproduct.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 89);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 1;
            label1.Text = "Produk";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(741, 94);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // ViewProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTambah);
            Controls.Add(label1);
            Controls.Add(dataproduct);
            Name = "ViewProduk";
            Size = new Size(961, 610);
            Load += ViewProduk_Load;
            ((System.ComponentModel.ISupportInitialize)dataproduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataproduct;
        private Label label1;
        private Button btnTambah;
    }
}
