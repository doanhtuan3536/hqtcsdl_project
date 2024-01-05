namespace hqtcsdl
{
    partial class DatLichHen
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ngayhen = new System.Windows.Forms.DateTimePicker();
            this.giohen = new System.Windows.Forms.DateTimePicker();
            this.nhasiphuhop = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DatLich = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LocNhaSi = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhasiphuhop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(386, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết lịch hẹn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày hẹn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ngayhen);
            this.panel1.Controls.Add(this.giohen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(222, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 132);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giờ hẹn";
            // 
            // ngayhen
            // 
            this.ngayhen.Location = new System.Drawing.Point(114, 19);
            this.ngayhen.Name = "ngayhen";
            this.ngayhen.Size = new System.Drawing.Size(277, 22);
            this.ngayhen.TabIndex = 5;
            // 
            // giohen
            // 
            this.giohen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.giohen.Location = new System.Drawing.Point(114, 81);
            this.giohen.Name = "giohen";
            this.giohen.Size = new System.Drawing.Size(277, 22);
            this.giohen.TabIndex = 4;
            // 
            // nhasiphuhop
            // 
            this.nhasiphuhop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhasiphuhop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhasiphuhop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.nhasiphuhop.Location = new System.Drawing.Point(44, 300);
            this.nhasiphuhop.Name = "nhasiphuhop";
            this.nhasiphuhop.RowHeadersWidth = 51;
            this.nhasiphuhop.RowTemplate.Height = 24;
            this.nhasiphuhop.Size = new System.Drawing.Size(856, 205);
            this.nhasiphuhop.TabIndex = 4;
            this.nhasiphuhop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhasiphuhop_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(304, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Danh sách nha sĩ phù hợp với lịch hẹn";
            // 
            // DatLich
            // 
            this.DatLich.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatLich.Location = new System.Drawing.Point(361, 565);
            this.DatLich.Name = "DatLich";
            this.DatLich.Size = new System.Drawing.Size(190, 67);
            this.DatLich.TabIndex = 6;
            this.DatLich.Text = "Đặt lịch";
            this.DatLich.UseVisualStyleBackColor = true;
            this.DatLich.Click += new System.EventHandler(this.DatLich_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(314, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhấp vào mã nha sĩ để chọn nha sĩ";
            // 
            // LocNhaSi
            // 
            this.LocNhaSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LocNhaSi.Location = new System.Drawing.Point(721, 225);
            this.LocNhaSi.Name = "LocNhaSi";
            this.LocNhaSi.Size = new System.Drawing.Size(142, 69);
            this.LocNhaSi.TabIndex = 8;
            this.LocNhaSi.Text = "Lọc nha sĩ";
            this.LocNhaSi.UseVisualStyleBackColor = true;
            this.LocNhaSi.Click += new System.EventHandler(this.LocNhaSi_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nha sĩ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên nha sĩ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày sinh nha sĩ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số điện thoại nha sĩ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày trong tuần";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giờ làm việc";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giờ kết thúc";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // DatLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 660);
            this.Controls.Add(this.LocNhaSi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatLich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nhasiphuhop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatLichHen";
            this.Text = "Đặt lịch hẹn";
            this.Load += new System.EventHandler(this.DatLichHen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhasiphuhop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker giohen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ngayhen;
        private System.Windows.Forms.DataGridView nhasiphuhop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DatLich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LocNhaSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}