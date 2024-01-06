namespace hqtcsdl
{
    partial class DangKi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.Label();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txussername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(247, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ngaysinh);
            this.panel1.Controls.Add(this.diachi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.hoten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pass2);
            this.panel1.Controls.Add(this.password2);
            this.panel1.Controls.Add(this.pass1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txussername);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(98, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 605);
            this.panel1.TabIndex = 1;
            // 
            // ngaysinh
            // 
            this.ngaysinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ngaysinh.Location = new System.Drawing.Point(21, 453);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(371, 22);
            this.ngaysinh.TabIndex = 12;
            // 
            // diachi
            // 
            this.diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.diachi.Location = new System.Drawing.Point(20, 552);
            this.diachi.MaxLength = 30;
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(369, 30);
            this.diachi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(17, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label.ForeColor = System.Drawing.Color.Blue;
            this.label.Location = new System.Drawing.Point(20, 420);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 24);
            this.label.TabIndex = 8;
            this.label.Text = "Ngày sinh";
            // 
            // hoten
            // 
            this.hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hoten.Location = new System.Drawing.Point(22, 353);
            this.hoten.MaxLength = 40;
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(369, 30);
            this.hoten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(19, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên";
            // 
            // pass2
            // 
            this.pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pass2.Location = new System.Drawing.Point(23, 251);
            this.pass2.MaxLength = 30;
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.Size = new System.Drawing.Size(369, 30);
            this.pass2.TabIndex = 5;
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.password2.ForeColor = System.Drawing.Color.Blue;
            this.password2.Location = new System.Drawing.Point(20, 220);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(173, 24);
            this.password2.TabIndex = 4;
            this.password2.Text = "Xác nhận mật khẩu";
            // 
            // pass1
            // 
            this.pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pass1.Location = new System.Drawing.Point(24, 149);
            this.pass1.MaxLength = 30;
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.Size = new System.Drawing.Size(368, 30);
            this.pass1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txussername
            // 
            this.txussername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txussername.Location = new System.Drawing.Point(24, 52);
            this.txussername.MaxLength = 10;
            this.txussername.Name = "txussername";
            this.txussername.Size = new System.Drawing.Size(368, 30);
            this.txussername.TabIndex = 1;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.username.ForeColor = System.Drawing.Color.Blue;
            this.username.Location = new System.Drawing.Point(21, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(218, 24);
            this.username.TabIndex = 0;
            this.username.Text = "Số điện thoại đăng nhập";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.back.Location = new System.Drawing.Point(119, 725);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(122, 56);
            this.back.TabIndex = 2;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signup.Location = new System.Drawing.Point(367, 725);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(122, 56);
            this.signup.TabIndex = 3;
            this.signup.Text = "Đăng kí";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 793);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DangKi";
            this.Text = "DangKi";
            this.Load += new System.EventHandler(this.DangKi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txussername;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ngaysinh;
    }
}