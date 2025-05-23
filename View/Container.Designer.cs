namespace crud_project_winform.View
{
    partial class Container
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelcontent = new Panel();
            panelnavigasi = new FlowLayoutPanel();
            btndashboard = new Button();
            btnProduct = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelnavigasi.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(panelcontent, 1, 0);
            tableLayoutPanel1.Controls.Add(panelnavigasi, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1297, 652);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelcontent
            // 
            panelcontent.Dock = DockStyle.Fill;
            panelcontent.Location = new Point(262, 3);
            panelcontent.Name = "panelcontent";
            panelcontent.Size = new Size(1032, 646);
            panelcontent.TabIndex = 0;
            // 
            // panelnavigasi
            // 
            panelnavigasi.Controls.Add(btndashboard);
            panelnavigasi.Controls.Add(btnProduct);
            panelnavigasi.Dock = DockStyle.Fill;
            panelnavigasi.Location = new Point(3, 3);
            panelnavigasi.Name = "panelnavigasi";
            panelnavigasi.Size = new Size(253, 646);
            panelnavigasi.TabIndex = 1;
            // 
            // btndashboard
            // 
            btndashboard.Location = new Point(3, 3);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(250, 67);
            btndashboard.TabIndex = 0;
            btndashboard.Text = "Dashboard";
            btndashboard.UseVisualStyleBackColor = true;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(3, 76);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(250, 67);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Produk";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // Container
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 652);
            Controls.Add(tableLayoutPanel1);
            Name = "Container";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Container";
            tableLayoutPanel1.ResumeLayout(false);
            panelnavigasi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelcontent;
        private FlowLayoutPanel panelnavigasi;
        private Button btndashboard;
        private Button btnProduct;
    }
}