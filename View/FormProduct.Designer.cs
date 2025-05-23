namespace crud_project_winform
{
    partial class FormProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textNamaProduk = new TextBox();
            textHargaProduct = new TextBox();
            label3 = new Label();
            textDeskripsi = new TextBox();
            label4 = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 36);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 0;
            label1.Text = "Form Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 111);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            // 
            // textNamaProduk
            // 
            textNamaProduk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNamaProduk.Location = new Point(64, 164);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(463, 38);
            textNamaProduk.TabIndex = 2;
            // 
            // textHargaProduct
            // 
            textHargaProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textHargaProduct.Location = new Point(64, 289);
            textHargaProduct.Name = "textHargaProduct";
            textHargaProduct.Size = new Size(463, 38);
            textHargaProduct.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 237);
            label3.Name = "label3";
            label3.Size = new Size(154, 31);
            label3.TabIndex = 3;
            label3.Text = "Harga Produk";
            // 
            // textDeskripsi
            // 
            textDeskripsi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDeskripsi.Location = new Point(64, 393);
            textDeskripsi.Multiline = true;
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(463, 197);
            textDeskripsi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 359);
            label4.Name = "label4";
            label4.Size = new Size(107, 31);
            label4.TabIndex = 5;
            label4.Text = "Deskripsi";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(222, 625);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(142, 50);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Tambah Produk";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(46, 36);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(116, 46);
            btnBack.TabIndex = 8;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 714);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(textDeskripsi);
            Controls.Add(label4);
            Controls.Add(textHargaProduct);
            Controls.Add(label3);
            Controls.Add(textNamaProduk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            Load += FormProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textNamaProduk;
        private TextBox textHargaProduct;
        private Label label3;
        private TextBox textDeskripsi;
        private Label label4;
        private Button btnSubmit;
        private Button btnBack;
    }
}