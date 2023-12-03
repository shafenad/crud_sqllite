namespace crud_database
{
    partial class Form1
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
            panel1 = new Panel();
            tblMhs = new DataGridView();
            btnTambahdata = new Button();
            btnHapus = new Button();
            btnUbahdata = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblMhs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 0;
            label1.Text = "Data Admin";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tblMhs);
            panel1.Location = new Point(36, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 223);
            panel1.TabIndex = 1;
            // 
            // tblMhs
            // 
            tblMhs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMhs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblMhs.BackgroundColor = SystemColors.ControlLight;
            tblMhs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMhs.Location = new Point(0, 0);
            tblMhs.Name = "tblMhs";
            tblMhs.RowHeadersWidth = 51;
            tblMhs.RowTemplate.Height = 29;
            tblMhs.Size = new Size(718, 220);
            tblMhs.TabIndex = 0;
            tblMhs.CellContentClick += tblMhs_CellContentClick;
            // 
            // btnTambahdata
            // 
            btnTambahdata.BackColor = SystemColors.Highlight;
            btnTambahdata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambahdata.ForeColor = SystemColors.HighlightText;
            btnTambahdata.Location = new Point(36, 330);
            btnTambahdata.Name = "btnTambahdata";
            btnTambahdata.Size = new Size(147, 37);
            btnTambahdata.TabIndex = 2;
            btnTambahdata.Text = "Tambah data";
            btnTambahdata.UseVisualStyleBackColor = false;
            btnTambahdata.Click += btnTambahdata_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = SystemColors.Highlight;
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHapus.ForeColor = SystemColors.HighlightText;
            btnHapus.Location = new Point(607, 330);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(147, 37);
            btnHapus.TabIndex = 3;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUbahdata
            // 
            btnUbahdata.BackColor = SystemColors.Highlight;
            btnUbahdata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUbahdata.ForeColor = SystemColors.HighlightText;
            btnUbahdata.Location = new Point(36, 385);
            btnUbahdata.Name = "btnUbahdata";
            btnUbahdata.Size = new Size(147, 37);
            btnUbahdata.TabIndex = 4;
            btnUbahdata.Text = "Ubah data";
            btnUbahdata.UseVisualStyleBackColor = false;
            btnUbahdata.Click += btnUbahdata_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUbahdata);
            Controls.Add(btnHapus);
            Controls.Add(btnTambahdata);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblMhs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView tblMhs;
        private Button btnTambahdata;
        private Button btnHapus;
        private Button btnUbahdata;
    }
}