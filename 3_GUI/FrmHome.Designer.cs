namespace _3_GUI
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.labNgayGio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labGio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyThucDon = new System.Windows.Forms.Button();
            this.btnQuanLyHoaDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPhucVuKhachHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labNgayGio
            // 
            this.labNgayGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labNgayGio.Location = new System.Drawing.Point(-1, 140);
            this.labNgayGio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labNgayGio.Name = "labNgayGio";
            this.labNgayGio.Size = new System.Drawing.Size(213, 27);
            this.labNgayGio.TabIndex = 0;
            this.labNgayGio.Text = "Ngày tháng";
            this.labNgayGio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giờ hệ thống";
            // 
            // labGio
            // 
            this.labGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labGio.Location = new System.Drawing.Point(-1, 39);
            this.labGio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labGio.Name = "labGio";
            this.labGio.Size = new System.Drawing.Size(213, 93);
            this.labGio.TabIndex = 2;
            this.labGio.Text = "Giờ";
            this.labGio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labGio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labNgayGio);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 229);
            this.panel1.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, 544);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(445, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 259);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.Navy;
            this.btnQuanLyNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNhanVien.Image")));
            this.btnQuanLyNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(1130, 457);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(391, 188);
            this.btnQuanLyNhanVien.TabIndex = 0;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyThucDon
            // 
            this.btnQuanLyThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQuanLyThucDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyThucDon.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThucDon.Image")));
            this.btnQuanLyThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThucDon.Location = new System.Drawing.Point(1129, 259);
            this.btnQuanLyThucDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuanLyThucDon.Name = "btnQuanLyThucDon";
            this.btnQuanLyThucDon.Size = new System.Drawing.Size(391, 188);
            this.btnQuanLyThucDon.TabIndex = 0;
            this.btnQuanLyThucDon.Text = "Quản lý thực đơn";
            this.btnQuanLyThucDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyThucDon.UseVisualStyleBackColor = false;
            this.btnQuanLyThucDon.Click += new System.EventHandler(this.btnQuanLyThucDon_Click);
            // 
            // btnQuanLyHoaDon
            // 
            this.btnQuanLyHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuanLyHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyHoaDon.Image")));
            this.btnQuanLyHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHoaDon.Location = new System.Drawing.Point(731, 457);
            this.btnQuanLyHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            this.btnQuanLyHoaDon.Size = new System.Drawing.Size(391, 188);
            this.btnQuanLyHoaDon.TabIndex = 0;
            this.btnQuanLyHoaDon.Text = "Quản lý hóa đơn";
            this.btnQuanLyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyHoaDon.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1430, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chào bạn:";
            // 
            // btnPhucVuKhachHang
            // 
            this.btnPhucVuKhachHang.BackColor = System.Drawing.Color.Red;
            this.btnPhucVuKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhucVuKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhucVuKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPhucVuKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPhucVuKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucVuKhachHang.Image")));
            this.btnPhucVuKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhucVuKhachHang.Location = new System.Drawing.Point(731, 259);
            this.btnPhucVuKhachHang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPhucVuKhachHang.Name = "btnPhucVuKhachHang";
            this.btnPhucVuKhachHang.Size = new System.Drawing.Size(391, 188);
            this.btnPhucVuKhachHang.TabIndex = 0;
            this.btnPhucVuKhachHang.Text = "Phục vụ khách hàng\r\n";
            this.btnPhucVuKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhucVuKhachHang.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(819, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hệ thống quản lý nhà hàng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(751, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 105);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chip Chip";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Maroon;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(1589, 76);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(97, 37);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1566, 837);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuanLyNhanVien);
            this.Controls.Add(this.btnQuanLyThucDon);
            this.Controls.Add(this.btnQuanLyHoaDon);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnPhucVuKhachHang);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuanLyThucDon;
        private System.Windows.Forms.Button btnQuanLyHoaDon;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labNgayGio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labGio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPhucVuKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDangXuat;
    }
}

