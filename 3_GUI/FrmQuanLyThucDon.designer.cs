﻿namespace _3_GUI
{
    partial class FrmQuanLyThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyThucDon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.dgvCachNau = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.btnXoaCongThuc = new System.Windows.Forms.Button();
            this.btnThemCongThuc = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnXoaNhom = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnSuaNhom = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtn_HDdanhmuc = new System.Windows.Forms.RadioButton();
            this.rbtn_KHDdanhmuc = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rbtn_HDthucdon = new System.Windows.Forms.RadioButton();
            this.rbtn_KHDthucdon = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rbtn_HDCachchebien = new System.Windows.Forms.RadioButton();
            this.rbtn_KHDCachchebien = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTimkiemDM = new System.Windows.Forms.TextBox();
            this.txt_TimKiemThucDon = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.txtTimKiemCongthucCB = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_MethID = new System.Windows.Forms.TextBox();
            this.txt_MethName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_Meth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Cat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_Unit = new System.Windows.Forms.ComboBox();
            this.txt_Price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachNau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(498, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1196, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CÁCH CHẾ BIÊN";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtMaDanhMuc.Location = new System.Drawing.Point(148, 81);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(224, 22);
            this.txtMaDanhMuc.TabIndex = 5;
            this.txtMaDanhMuc.TabStop = false;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtTenDanhMuc.Location = new System.Drawing.Point(148, 117);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(224, 22);
            this.txtTenDanhMuc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Danh Mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Danh Mục";
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtMaMonAn.Location = new System.Drawing.Point(687, 112);
            this.txtMaMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.ReadOnly = true;
            this.txtMaMonAn.Size = new System.Drawing.Size(205, 26);
            this.txtMaMonAn.TabIndex = 8;
            this.txtMaMonAn.TabStop = false;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTenMonAn.Location = new System.Drawing.Point(687, 168);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(180, 22);
            this.txtTenMonAn.TabIndex = 5;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaTien.ForeColor = System.Drawing.Color.Black;
            this.txtGiaTien.Location = new System.Drawing.Point(1029, 158);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(133, 26);
            this.txtGiaTien.TabIndex = 7;
            // 
            // txtDonViTinhtd
            // 
            this.txtDonViTinhtd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonViTinhtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDonViTinhtd.ForeColor = System.Drawing.Color.Black;
            this.txtDonViTinhtd.Location = new System.Drawing.Point(1029, 112);
            this.txtDonViTinhtd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonViTinhtd.Name = "txtDonViTinhtd";
            this.txtDonViTinhtd.Size = new System.Drawing.Size(192, 26);
            this.txtDonViTinhtd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(574, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã món ăn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(574, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên món ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(938, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Giá tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(821, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Đơn vị tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1184, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "VNĐ";
            // 
            // cbbTenMonAn
            // 
            this.cbbTenMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTenMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenMonAn.FormattingEnabled = true;
            this.cbbTenMonAn.Location = new System.Drawing.Point(1517, 103);
            this.cbbTenMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTenMonAn.Name = "cbbTenMonAn";
            this.cbbTenMonAn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbTenMonAn.Size = new System.Drawing.Size(201, 28);
            this.cbbTenMonAn.TabIndex = 11;
            // 
            // cbbTenNguyenLieu
            // 
            this.cbbTenNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTenNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNguyenLieu.FormattingEnabled = true;
            this.cbbTenNguyenLieu.Location = new System.Drawing.Point(1517, 145);
            this.cbbTenNguyenLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTenNguyenLieu.Name = "cbbTenNguyenLieu";
            this.cbbTenNguyenLieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbTenNguyenLieu.Size = new System.Drawing.Size(201, 28);
            this.cbbTenNguyenLieu.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1367, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tên món ăn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1367, 152);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tên nguyên liệu";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToResizeRows = false;
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMonAn.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonAn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMonAn.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMonAn.Location = new System.Drawing.Point(486, 289);
            this.dgvMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(664, 429);
            this.dgvMonAn.TabIndex = 20;
            this.dgvMonAn.TabStop = false;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            // 
            // dgvCachNau
            // 
            this.dgvCongThuc.AllowUserToResizeRows = false;
            this.dgvCongThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongThuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCongThuc.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCongThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCongThuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCongThuc.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCongThuc.Location = new System.Drawing.Point(1377, 383);
            this.dgvCongThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCongThuc.MultiSelect = false;
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.ReadOnly = true;
            this.dgvCongThuc.RowHeadersVisible = false;
            this.dgvCongThuc.RowHeadersWidth = 40;
            this.dgvCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongThuc.Size = new System.Drawing.Size(423, 574);
            this.dgvCongThuc.TabIndex = 20;
            this.dgvCongThuc.TabStop = false;
            // 
            // lblMaMonAn
            // 
            this.lblMaMonAn.BackColor = System.Drawing.Color.Transparent;
            this.lblMaMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMaMonAn.Location = new System.Drawing.Point(1745, 126);
            this.lblMaMonAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMonAn.Name = "lblMaMonAn";
            this.lblMaMonAn.Size = new System.Drawing.Size(55, 20);
            this.lblMaMonAn.TabIndex = 34;
            this.lblMaMonAn.Visible = false;
            // 
            // lblMaNguyenLieu
            // 
            this.lblMaNguyenLieu.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNguyenLieu.Location = new System.Drawing.Point(1745, 168);
            this.lblMaNguyenLieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNguyenLieu.Name = "lblMaNguyenLieu";
            this.lblMaNguyenLieu.Size = new System.Drawing.Size(55, 20);
            this.lblMaNguyenLieu.TabIndex = 34;
            this.lblMaNguyenLieu.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1683, 126);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "label14";
            // 
            // btnXoaCongThuc
            // 
            this.btnXoaCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaCongThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCongThuc.Image")));
            this.btnXoaCongThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCongThuc.Location = new System.Drawing.Point(1605, 267);
            this.btnXoaCongThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaCongThuc.Name = "btnXoaCongThuc";
            this.btnXoaCongThuc.Size = new System.Drawing.Size(109, 37);
            this.btnXoaCongThuc.TabIndex = 15;
            this.btnXoaCongThuc.Text = "Xóa";
            this.btnXoaCongThuc.UseVisualStyleBackColor = true;
            this.btnXoaCongThuc.Click += new System.EventHandler(this.btnXoaCongThuc_Click);
            // 
            // btnThemCongThuc
            // 
            this.btnThemCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemCongThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCongThuc.Image")));
            this.btnThemCongThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCongThuc.Location = new System.Drawing.Point(1433, 267);
            this.btnThemCongThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemCongThuc.Name = "btnThemCongThuc";
            this.btnThemCongThuc.Size = new System.Drawing.Size(109, 37);
            this.btnThemCongThuc.TabIndex = 14;
            this.btnThemCongThuc.Text = "Thêm";
            this.btnThemCongThuc.UseVisualStyleBackColor = true;
            this.btnThemCongThuc.Click += new System.EventHandler(this.btnThemCongThuc_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.Image")));
            this.btnXoaMon.Location = new System.Drawing.Point(1090, 267);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(109, 37);
            this.btnXoaMon.TabIndex = 10;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.Location = new System.Drawing.Point(340, 267);
            this.btnXoaNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(104, 37);
            this.btnXoaNhom.TabIndex = 4;
            this.btnXoaNhom.Text = "Xóa";
            this.btnXoaNhom.UseVisualStyleBackColor = true;
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMon.Image")));
            this.btnSuaMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaMon.Location = new System.Drawing.Point(770, 200);
            this.btnSuaMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(109, 37);
            this.btnSuaMon.TabIndex = 9;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = true;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnSuaNhom
            // 
            this.btnSuaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNhom.Image")));
            this.btnSuaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNhom.Location = new System.Drawing.Point(166, 200);
            this.btnSuaNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaNhom.Name = "btnSuaNhom";
            this.btnSuaNhom.Size = new System.Drawing.Size(109, 37);
            this.btnSuaNhom.TabIndex = 3;
            this.btnSuaNhom.Text = "Sửa";
            this.btnSuaNhom.UseVisualStyleBackColor = true;
            this.btnSuaNhom.Click += new System.EventHandler(this.btnSuaNhom_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.Location = new System.Drawing.Point(702, 267);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(109, 37);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhom.Location = new System.Drawing.Point(38, 200);
            this.btnThemNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(109, 37);
            this.btnThemNhom.TabIndex = 2;
            this.btnThemNhom.Text = "Thêm";
            this.btnThemNhom.UseVisualStyleBackColor = true;
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trạng thái :";
            // 
            // rbtn_HDdanhmuc
            // 
            this.rbtn_HDdanhmuc.AutoSize = true;
            this.rbtn_HDdanhmuc.Location = new System.Drawing.Point(161, 154);
            this.rbtn_HDdanhmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_HDdanhmuc.Name = "rbtn_HDdanhmuc";
            this.rbtn_HDdanhmuc.Size = new System.Drawing.Size(82, 19);
            this.rbtn_HDdanhmuc.TabIndex = 35;
            this.rbtn_HDdanhmuc.TabStop = true;
            this.rbtn_HDdanhmuc.Text = "Hoạt động";
            this.rbtn_HDdanhmuc.UseVisualStyleBackColor = true;
            // 
            // rbtn_KHDdanhmuc
            // 
            this.rbtn_KHDdanhmuc.AutoSize = true;
            this.rbtn_KHDdanhmuc.Location = new System.Drawing.Point(283, 154);
            this.rbtn_KHDdanhmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_KHDdanhmuc.Name = "rbtn_KHDdanhmuc";
            this.rbtn_KHDdanhmuc.Size = new System.Drawing.Size(118, 19);
            this.rbtn_KHDdanhmuc.TabIndex = 35;
            this.rbtn_KHDdanhmuc.TabStop = true;
            this.rbtn_KHDdanhmuc.Text = "Không hoạt động";
            this.rbtn_KHDdanhmuc.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(574, 215);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "Cách nấu";
            // 
            // txtCachNau
            // 
            this.txtCachNau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCachNau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCachNau.ForeColor = System.Drawing.Color.Black;
            this.txtCachNau.Location = new System.Drawing.Point(687, 212);
            this.txtCachNau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCachNau.Name = "txtCachNau";
            this.txtCachNau.Size = new System.Drawing.Size(205, 26);
            this.txtCachNau.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(932, 213);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "Trạng thái :";
            // 
            // rbtn_HDthucdon
            // 
            this.rbtn_HDthucdon.AutoSize = true;
            this.rbtn_HDthucdon.Location = new System.Drawing.Point(1038, 213);
            this.rbtn_HDthucdon.Name = "rbtn_HDthucdon";
            this.rbtn_HDthucdon.Size = new System.Drawing.Size(82, 19);
            this.rbtn_HDthucdon.TabIndex = 35;
            this.rbtn_HDthucdon.TabStop = true;
            this.rbtn_HDthucdon.Text = "Hoạt động";
            this.rbtn_HDthucdon.UseVisualStyleBackColor = true;
            // 
            // rbtn_KHDthucdon
            // 
            this.rbtn_KHDthucdon.AutoSize = true;
            this.rbtn_KHDthucdon.Location = new System.Drawing.Point(1020, 160);
            this.rbtn_KHDthucdon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_KHDthucdon.Name = "rbtn_KHDthucdon";
            this.rbtn_KHDthucdon.Size = new System.Drawing.Size(118, 19);
            this.rbtn_KHDthucdon.TabIndex = 35;
            this.rbtn_KHDthucdon.TabStop = true;
            this.rbtn_KHDthucdon.Text = "Không hoạt động";
            this.rbtn_KHDthucdon.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(1199, 154);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Trạng thái :";
            // 
            // rbtn_HDCachchebien
            // 
            this.rbtn_HDCachchebien.AutoSize = true;
            this.rbtn_HDCachchebien.Location = new System.Drawing.Point(1520, 202);
            this.rbtn_HDCachchebien.Name = "rbtn_HDCachchebien";
            this.rbtn_HDCachchebien.Size = new System.Drawing.Size(82, 19);
            this.rbtn_HDCachchebien.TabIndex = 35;
            this.rbtn_HDCachchebien.TabStop = true;
            this.rbtn_HDCachchebien.Text = "Hoạt động";
            this.rbtn_HDCachchebien.UseVisualStyleBackColor = true;
            // 
            // rbtn_KHDCachchebien
            // 
            this.rbtn_KHDCachchebien.AutoSize = true;
            this.rbtn_KHDCachchebien.Location = new System.Drawing.Point(1424, 154);
            this.rbtn_KHDCachchebien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_KHDCachchebien.Name = "rbtn_KHDCachchebien";
            this.rbtn_KHDCachchebien.Size = new System.Drawing.Size(118, 19);
            this.rbtn_KHDCachchebien.TabIndex = 35;
            this.rbtn_KHDCachchebien.TabStop = true;
            this.rbtn_KHDCachchebien.Text = "Không hoạt động";
            this.rbtn_KHDCachchebien.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(168, 268);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "Tìm kiếm :";
            // 
            // txtTimkiemDM
            // 
            this.txtTimkiemDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimkiemDM.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiemDM.Location = new System.Drawing.Point(251, 264);
            this.txtTimkiemDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemDM.Name = "txtTimkiemDM";
            this.txtTimkiemDM.Size = new System.Drawing.Size(197, 22);
            this.txtTimkiemDM.TabIndex = 0;
            this.txtTimkiemDM.TextChanged += new System.EventHandler(this.txtTimkiemDM_TextChanged);
            // 
            // txt_TimKiemThucDon
            // 
            this.txt_TimKiemThucDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TimKiemThucDon.ForeColor = System.Drawing.Color.Black;
            this.txt_TimKiemThucDon.Location = new System.Drawing.Point(954, 264);
            this.txt_TimKiemThucDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiemThucDon.Name = "txt_TimKiemThucDon";
            this.txt_TimKiemThucDon.Size = new System.Drawing.Size(197, 22);
            this.txt_TimKiemThucDon.TabIndex = 0;
            this.txt_TimKiemThucDon.TextChanged += new System.EventHandler(this.txt_TimKiemThucDon_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(871, 266);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "Tìm kiếm :";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhMuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDanhMuc.Location = new System.Drawing.Point(36, 287);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(412, 430);
            this.dgvDanhMuc.TabIndex = 4;
            this.dgvDanhMuc.TabStop = false;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // txtTimKiemCongthucCB
            // 
            this.txtTimKiemCongthucCB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemCongthucCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiemCongthucCB.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemCongthucCB.Location = new System.Drawing.Point(1599, 343);
            this.txtTimKiemCongthucCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiemCongthucCB.Name = "txtTimKiemCongthucCB";
            this.txtTimKiemCongthucCB.Size = new System.Drawing.Size(176, 22);
            this.txtTimKiemCongthucCB.TabIndex = 0;
            this.txtTimKiemCongthucCB.TextChanged += new System.EventHandler(this.txtTimKiemCongthucCB_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(1316, 262);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 16);
            this.label20.TabIndex = 5;
            this.label20.Text = "Tìm kiếm :";
            // 
            // txt_MethID
            // 
            this.txt_MethID.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_MethID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MethID.ForeColor = System.Drawing.Color.Black;
            this.txt_MethID.Location = new System.Drawing.Point(1495, 108);
            this.txt_MethID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MethID.Name = "txt_MethID";
            this.txt_MethID.ReadOnly = true;
            this.txt_MethID.Size = new System.Drawing.Size(256, 26);
            this.txt_MethID.TabIndex = 5;
            this.txt_MethID.TabStop = false;
            // 
            // txt_MethName
            // 
            this.txt_MethName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MethName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MethName.ForeColor = System.Drawing.Color.Black;
            this.txt_MethName.Location = new System.Drawing.Point(1495, 156);
            this.txt_MethName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MethName.Name = "txt_MethName";
            this.txt_MethName.Size = new System.Drawing.Size(256, 26);
            this.txt_MethName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1367, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã Cách Nấu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1367, 156);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cách Nấu";
            // 
            // cbx_Meth
            // 
            this.cbx_Meth.FormattingEnabled = true;
            this.cbx_Meth.Location = new System.Drawing.Point(682, 168);
            this.cbx_Meth.Name = "cbx_Meth";
            this.cbx_Meth.Size = new System.Drawing.Size(205, 28);
            this.cbx_Meth.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(569, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh mục";
            // 
            // cbx_Cat
            // 
            this.cbx_Cat.FormattingEnabled = true;
            this.cbx_Cat.Location = new System.Drawing.Point(682, 215);
            this.cbx_Cat.Name = "cbx_Cat";
            this.cbx_Cat.Size = new System.Drawing.Size(205, 28);
            this.cbx_Cat.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1528, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_Unit
            // 
            this.cbx_Unit.FormattingEnabled = true;
            this.cbx_Unit.Location = new System.Drawing.Point(1029, 115);
            this.cbx_Unit.Name = "cbx_Unit";
            this.cbx_Unit.Size = new System.Drawing.Size(205, 28);
            this.cbx_Unit.TabIndex = 36;
            // 
            // txt_Price
            // 
            this.txt_Price.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_Price.Location = new System.Drawing.Point(1029, 166);
            this.txt_Price.Maximum = new decimal(new int[] {
            999000000,
            0,
            0,
            0});
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(150, 27);
            this.txt_Price.TabIndex = 37;
            // 
            // FrmQuanLyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1805, 983);
            this.Controls.Add(this.rbtn_KHDCachchebien);
            this.Controls.Add(this.rbtn_KHDthucdon);
            this.Controls.Add(this.rbtn_HDCachchebien);
            this.Controls.Add(this.rbtn_HDthucdon);
            this.Controls.Add(this.rbtn_KHDdanhmuc);
            this.Controls.Add(this.rbtn_HDdanhmuc);
            this.Controls.Add(this.btnXoaCongThuc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvCachNau);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.btnThemCongThuc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTimKiemCongthucCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_TimKiemThucDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MethName);
            this.Controls.Add(this.txtTimkiemDM);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.txt_MethID);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnXoaNhom);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSuaNhom);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.btnThemNhom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuanLyThucDon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thực Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachNau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnSuaNhom;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnXoaNhom;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThemCongThuc;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.DataGridView dgvCachNau;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnXoaCongThuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtn_HDdanhmuc;
        private System.Windows.Forms.RadioButton rbtn_KHDdanhmuc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbtn_HDthucdon;
        private System.Windows.Forms.RadioButton rbtn_KHDthucdon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbtn_HDCachchebien;
        private System.Windows.Forms.RadioButton rbtn_KHDCachchebien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTimkiemDM;
        private System.Windows.Forms.TextBox txt_TimKiemThucDon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.TextBox txtTimKiemCongthucCB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_MethID;
        private System.Windows.Forms.TextBox txt_MethName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_Meth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Cat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_Unit;
        private System.Windows.Forms.NumericUpDown txt_Price;
    }
}