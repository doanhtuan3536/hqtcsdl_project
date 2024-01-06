namespace hqtcsdl
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btndangki = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(239, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.username.Location = new System.Drawing.Point(55, 18);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(141, 24);
            this.username.TabIndex = 1;
            this.username.Text = "Tên đăng nhập";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.password.Location = new System.Drawing.Point(55, 131);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 24);
            this.password.TabIndex = 2;
            this.password.Text = "Mật khẩu";
            // 
            // txUsername
            // 
            this.txUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txUsername.Location = new System.Drawing.Point(59, 59);
            this.txUsername.MaxLength = 40;
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(338, 28);
            this.txUsername.TabIndex = 3;
            // 
            // txPass
            // 
            this.txPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txPass.Location = new System.Drawing.Point(56, 172);
            this.txPass.MaxLength = 40;
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '*';
            this.txPass.Size = new System.Drawing.Size(341, 28);
            this.txPass.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.txPass);
            this.panel1.Controls.Add(this.txUsername);
            this.panel1.Controls.Add(this.password);
            this.panel1.Location = new System.Drawing.Point(113, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 244);
            this.panel1.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDangNhap.Location = new System.Drawing.Point(172, 373);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(124, 57);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btndangki
            // 
            this.btndangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btndangki.Location = new System.Drawing.Point(386, 373);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(124, 57);
            this.btndangki.TabIndex = 8;
            this.btndangki.Text = "Đăng kí";
            this.btndangki.UseVisualStyleBackColor = false;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 465);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btndangki;
    }
}