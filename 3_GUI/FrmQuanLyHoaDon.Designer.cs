
namespace _3_GUI
{
    partial class FrmQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyHoaDon));
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbbMonAnVaBan = new System.Windows.Forms.ComboBox();
            this.dgvMonAnVaban = new System.Windows.Forms.DataGridView();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudTienTra = new System.Windows.Forms.NumericUpDown();
            this.nudTienMat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ltvThanhTien = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ltvTenSanPham = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAnVaban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Danh sách món";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(730, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mã bàn";
            // 
            // btnChon
            // 
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(925, 397);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(117, 33);
            this.btnChon.TabIndex = 35;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // cbbMonAnVaBan
            // 
            this.cbbMonAnVaBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMonAnVaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonAnVaBan.FormattingEnabled = true;
            this.cbbMonAnVaBan.Location = new System.Drawing.Point(798, 400);
            this.cbbMonAnVaBan.Name = "cbbMonAnVaBan";
            this.cbbMonAnVaBan.Size = new System.Drawing.Size(121, 28);
            this.cbbMonAnVaBan.TabIndex = 34;
            // 
            // dgvMonAnVaban
            // 
            this.dgvMonAnVaban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAnVaban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMonAnVaban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonAnVaban.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMonAnVaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAnVaban.Location = new System.Drawing.Point(640, 66);
            this.dgvMonAnVaban.Name = "dgvMonAnVaban";
            this.dgvMonAnVaban.RowHeadersWidth = 51;
            this.dgvMonAnVaban.Size = new System.Drawing.Size(442, 264);
            this.dgvMonAnVaban.TabIndex = 33;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(483, 440);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(117, 33);
            this.btnInHoaDon.TabIndex = 32;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(483, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 33);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(483, 358);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 33);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // nudTienTra
            // 
            this.nudTienTra.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTienTra.Location = new System.Drawing.Point(209, 450);
            this.nudTienTra.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTienTra.Name = "nudTienTra";
            this.nudTienTra.ReadOnly = true;
            this.nudTienTra.Size = new System.Drawing.Size(173, 27);
            this.nudTienTra.TabIndex = 29;
            this.nudTienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienTra.ThousandsSeparator = true;
            // 
            // nudTienMat
            // 
            this.nudTienMat.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTienMat.Location = new System.Drawing.Point(209, 409);
            this.nudTienMat.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTienMat.Name = "nudTienMat";
            this.nudTienMat.Size = new System.Drawing.Size(173, 27);
            this.nudTienMat.TabIndex = 28;
            this.nudTienMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienMat.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tiền Mặt";
            // 
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(209, 368);
            this.nudTongTien.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.ReadOnly = true;
            this.nudTongTien.Size = new System.Drawing.Size(173, 27);
            this.nudTongTien.TabIndex = 26;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTongTien.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tổng Tiền";
            // 
            // ltvThanhTien
            // 
            this.ltvThanhTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvThanhTien.FormattingEnabled = true;
            this.ltvThanhTien.ItemHeight = 20;
            this.ltvThanhTien.Location = new System.Drawing.Point(388, 66);
            this.ltvThanhTien.Name = "ltvThanhTien";
            this.ltvThanhTien.Size = new System.Drawing.Size(246, 264);
            this.ltvThanhTien.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thành Tiền";
            // 
            // ltvTenSanPham
            // 
            this.ltvTenSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvTenSanPham.FormattingEnabled = true;
            this.ltvTenSanPham.ItemHeight = 20;
            this.ltvTenSanPham.Location = new System.Drawing.Point(104, 66);
            this.ltvTenSanPham.Name = "ltvTenSanPham";
            this.ltvTenSanPham.Size = new System.Drawing.Size(278, 264);
            this.ltvTenSanPham.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên Món Ăn";
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbMonAnVaBan);
            this.Controls.Add(this.dgvMonAnVaban);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudTienTra);
            this.Controls.Add(this.nudTienMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ltvThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltvTenSanPham);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLyHoaDon";
            this.Text = "Quản lý in hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAnVaban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cbbMonAnVaBan;
        private System.Windows.Forms.DataGridView dgvMonAnVaban;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nudTienTra;
        private System.Windows.Forms.NumericUpDown nudTienMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ltvThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltvTenSanPham;
        private System.Windows.Forms.Label label1;
    }
}