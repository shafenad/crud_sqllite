namespace crud_database
{
    partial class ubahdata
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
            button1 = new Button();
            button_simpan = new Button();
            label4 = new Label();
            tbxpass = new TextBox();
            tbxemail = new TextBox();
            tbxid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(407, 383);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 18;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_simpan
            // 
            button_simpan.Location = new Point(216, 383);
            button_simpan.Name = "button_simpan";
            button_simpan.Size = new Size(173, 29);
            button_simpan.TabIndex = 17;
            button_simpan.Text = "Simpan";
            button_simpan.UseVisualStyleBackColor = true;
            button_simpan.Click += button_simpan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 41);
            label4.Name = "label4";
            label4.Size = new Size(245, 38);
            label4.TabIndex = 16;
            label4.Text = "Edit Data Admin";
            // 
            // tbxpass
            // 
            tbxpass.Location = new Point(35, 284);
            tbxpass.Name = "tbxpass";
            tbxpass.Size = new Size(246, 27);
            tbxpass.TabIndex = 15;
            // 
            // tbxemail
            // 
            tbxemail.Location = new Point(35, 198);
            tbxemail.Name = "tbxemail";
            tbxemail.Size = new Size(246, 27);
            tbxemail.TabIndex = 14;
            // 
            // tbxid
            // 
            tbxid.Location = new Point(35, 126);
            tbxid.Name = "tbxid";
            tbxid.Size = new Size(95, 27);
            tbxid.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 247);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 12;
            label3.Text = "Password ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 170);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 11;
            label2.Text = "Email ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 98);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 10;
            label1.Text = "ID ";
            // 
            // ubahdata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_simpan);
            Controls.Add(label4);
            Controls.Add(tbxpass);
            Controls.Add(tbxemail);
            Controls.Add(tbxid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ubahdata";
            Text = "ubahdata";
            Load += ubahdata_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button_simpan;
        private Label label4;
        private TextBox tbxpass;
        private TextBox tbxemail;
        private TextBox tbxid;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}