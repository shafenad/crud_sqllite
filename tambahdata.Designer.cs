namespace crud_database
{
    partial class tambahdata
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
            label3 = new Label();
            tbxid = new TextBox();
            tbxemail = new TextBox();
            tbxpass = new TextBox();
            label4 = new Label();
            button_simpan = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 87);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "ID ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 159);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Email ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 236);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Password ";
            label3.Click += label3_Click;
            // 
            // tbxid
            // 
            tbxid.Location = new Point(33, 115);
            tbxid.Name = "tbxid";
            tbxid.Size = new Size(95, 27);
            tbxid.TabIndex = 3;
            tbxid.TextChanged += tbxid_TextChanged;
            // 
            // tbxemail
            // 
            tbxemail.Location = new Point(33, 187);
            tbxemail.Name = "tbxemail";
            tbxemail.Size = new Size(246, 27);
            tbxemail.TabIndex = 4;
            tbxemail.TextChanged += tbxemail_TextChanged;
            // 
            // tbxpass
            // 
            tbxpass.Location = new Point(33, 273);
            tbxpass.Name = "tbxpass";
            tbxpass.Size = new Size(246, 27);
            tbxpass.TabIndex = 5;
            tbxpass.TextChanged += tbxpass_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 30);
            label4.Name = "label4";
            label4.Size = new Size(263, 38);
            label4.TabIndex = 6;
            label4.Text = "Form Admin Baru";
            label4.Click += label4_Click;
            // 
            // button_simpan
            // 
            button_simpan.Location = new Point(214, 372);
            button_simpan.Name = "button_simpan";
            button_simpan.Size = new Size(173, 29);
            button_simpan.TabIndex = 8;
            button_simpan.Text = "Simpan";
            button_simpan.UseVisualStyleBackColor = true;
            button_simpan.Click += button_simpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(405, 372);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 9;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tambahdata
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
            Name = "tambahdata";
            Text = "tambahdata";
            Load += tambahdata_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxid;
        private TextBox tbxemail;
        private TextBox tbxpass;
        private Label label4;
        private Button button_simpan;
        private Button button1;
    }
}