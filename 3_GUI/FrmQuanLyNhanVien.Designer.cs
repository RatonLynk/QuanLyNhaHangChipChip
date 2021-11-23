
namespace _3_GUI
{
    partial class FrmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNhanVien));
            this.label5 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtnHDnhanvien = new System.Windows.Forms.RadioButton();
            this.rbtnKHDnhanvien = new System.Windows.Forms.RadioButton();
            this.dgrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChiNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.chk_quanLi = new System.Windows.Forms.CheckBox();
            this.chk_nhanVien = new System.Windows.Forms.CheckBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_nam = new System.Windows.Forms.CheckBox();
            this.chk_nu = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Email :";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.a.ForeColor = System.Drawing.SystemColors.MenuText;
            this.a.Location = new System.Drawing.Point(8, 40);
            this.a.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(113, 20);
            this.a.TabIndex = 40;
            this.a.Text = "Mã nhân viên:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEmail.Location = new System.Drawing.Point(204, 150);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 27);
            this.txtEmail.TabIndex = 36;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaNV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMaNV.Location = new System.Drawing.Point(204, 40);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(204, 26);
            this.txtMaNV.TabIndex = 39;
            this.txtMaNV.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(8, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Trạng thái :";
            // 
            // rbtnHDnhanvien
            // 
            this.rbtnHDnhanvien.AutoSize = true;
            this.rbtnHDnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnHDnhanvien.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbtnHDnhanvien.Location = new System.Drawing.Point(204, 370);
            this.rbtnHDnhanvien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnHDnhanvien.Name = "rbtnHDnhanvien";
            this.rbtnHDnhanvien.Size = new System.Drawing.Size(91, 20);
            this.rbtnHDnhanvien.TabIndex = 42;
            this.rbtnHDnhanvien.TabStop = true;
            this.rbtnHDnhanvien.Text = "Hoạt động";
            this.rbtnHDnhanvien.UseVisualStyleBackColor = true;
            // 
            // rbtnKHDnhanvien
            // 
            this.rbtnKHDnhanvien.AutoSize = true;
            this.rbtnKHDnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnKHDnhanvien.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbtnKHDnhanvien.Location = new System.Drawing.Point(319, 370);
            this.rbtnKHDnhanvien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnKHDnhanvien.Name = "rbtnKHDnhanvien";
            this.rbtnKHDnhanvien.Size = new System.Drawing.Size(129, 20);
            this.rbtnKHDnhanvien.TabIndex = 41;
            this.rbtnKHDnhanvien.TabStop = true;
            this.rbtnKHDnhanvien.Text = "Không hoạt động";
            this.rbtnKHDnhanvien.UseVisualStyleBackColor = true;
            // 
            // dgrid_NhanVien
            // 
            this.dgrid_NhanVien.AllowUserToResizeRows = false;
            this.dgrid_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_NhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgrid_NhanVien.BackgroundColor = System.Drawing.Color.Silver;
            this.dgrid_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_NhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgrid_NhanVien.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrid_NhanVien.Location = new System.Drawing.Point(467, 51);
            this.dgrid_NhanVien.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgrid_NhanVien.MultiSelect = false;
            this.dgrid_NhanVien.Name = "dgrid_NhanVien";
            this.dgrid_NhanVien.ReadOnly = true;
            this.dgrid_NhanVien.RowHeadersVisible = false;
            this.dgrid_NhanVien.RowHeadersWidth = 51;
            this.dgrid_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_NhanVien.Size = new System.Drawing.Size(654, 506);
            this.dgrid_NhanVien.TabIndex = 43;
            this.dgrid_NhanVien.TabStop = false;
            this.dgrid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_NhanVien_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(8, 424);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 119;
            this.label10.Text = "Vai trò:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(7, 258);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 120;
            this.label11.Text = "Số điện thoại :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(8, 480);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 121;
            this.label12.Text = "Địa chỉ :";
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaHang.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblMaHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaHang.Location = new System.Drawing.Point(8, 98);
            this.lblMaHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(123, 20);
            this.lblMaHang.TabIndex = 122;
            this.lblMaHang.Text = "Tên nhân viên :";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SDT.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_SDT.Location = new System.Drawing.Point(204, 256);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(206, 27);
            this.txt_SDT.TabIndex = 111;
            // 
            // txt_DiaChiNV
            // 
            this.txt_DiaChiNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DiaChiNV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_DiaChiNV.Location = new System.Drawing.Point(204, 486);
            this.txt_DiaChiNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_DiaChiNV.Multiline = true;
            this.txt_DiaChiNV.Name = "txt_DiaChiNV";
            this.txt_DiaChiNV.Size = new System.Drawing.Size(216, 74);
            this.txt_DiaChiNV.TabIndex = 112;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenNV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_TenNV.Location = new System.Drawing.Point(204, 98);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(206, 27);
            this.txt_TenNV.TabIndex = 110;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Search.Location = new System.Drawing.Point(808, 12);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderText = "Mời nhập tên hoặc email để tìm kiếm";
            this.txt_Search.Size = new System.Drawing.Size(313, 31);
            this.txt_Search.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(702, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 123;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.Image")));
            this.btnXoaNV.Location = new System.Drawing.Point(840, 583);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(116, 49);
            this.btnXoaNV.TabIndex = 127;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.Image")));
            this.btnSuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNV.Location = new System.Drawing.Point(660, 583);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(116, 49);
            this.btnSuaNV.TabIndex = 126;
            this.btnSuaNV.Text = "Sửa ";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(467, 583);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(116, 49);
            this.btnThemNV.TabIndex = 125;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // chk_quanLi
            // 
            this.chk_quanLi.AutoSize = true;
            this.chk_quanLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_quanLi.Location = new System.Drawing.Point(204, 427);
            this.chk_quanLi.Margin = new System.Windows.Forms.Padding(4);
            this.chk_quanLi.Name = "chk_quanLi";
            this.chk_quanLi.Size = new System.Drawing.Size(74, 20);
            this.chk_quanLi.TabIndex = 128;
            this.chk_quanLi.Text = "Quản Lí";
            this.chk_quanLi.UseVisualStyleBackColor = true;
            this.chk_quanLi.CheckedChanged += new System.EventHandler(this.chk_quanLi_CheckedChanged_1);
            // 
            // chk_nhanVien
            // 
            this.chk_nhanVien.AutoSize = true;
            this.chk_nhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_nhanVien.Location = new System.Drawing.Point(303, 426);
            this.chk_nhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.chk_nhanVien.Name = "chk_nhanVien";
            this.chk_nhanVien.Size = new System.Drawing.Size(91, 20);
            this.chk_nhanVien.TabIndex = 129;
            this.chk_nhanVien.Text = "Nhân Viên";
            this.chk_nhanVien.UseVisualStyleBackColor = true;
            this.chk_nhanVien.CheckedChanged += new System.EventHandler(this.chk_nhanVien_CheckedChanged);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(1005, 583);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(116, 49);
            this.btn_Luu.TabIndex = 130;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMatKhau.Location = new System.Drawing.Point(204, 201);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ReadOnly = true;
            this.txtMatKhau.Size = new System.Drawing.Size(204, 26);
            this.txtMatKhau.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(8, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mật Khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(75, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(9, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 131;
            this.label3.Text = "Giới tính :";
            // 
            // chk_nam
            // 
            this.chk_nam.AutoSize = true;
            this.chk_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_nam.Location = new System.Drawing.Point(204, 317);
            this.chk_nam.Margin = new System.Windows.Forms.Padding(4);
            this.chk_nam.Name = "chk_nam";
            this.chk_nam.Size = new System.Drawing.Size(58, 20);
            this.chk_nam.TabIndex = 134;
            this.chk_nam.Text = "Nam";
            this.chk_nam.UseVisualStyleBackColor = true;
            // 
            // chk_nu
            // 
            this.chk_nu.AutoSize = true;
            this.chk_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_nu.Location = new System.Drawing.Point(303, 317);
            this.chk_nu.Margin = new System.Windows.Forms.Padding(4);
            this.chk_nu.Name = "chk_nu";
            this.chk_nu.Size = new System.Drawing.Size(46, 20);
            this.chk_nu.TabIndex = 135;
            this.chk_nu.Text = "Nữ";
            this.chk_nu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.chk_nu);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.chk_nam);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chk_nhanVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chk_quanLi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbtnHDnhanvien);
            this.groupBox1.Controls.Add(this.rbtnKHDnhanvien);
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.txt_DiaChiNV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblMaHang);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 600);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // FrmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_NhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnHDnhanvien;
        private System.Windows.Forms.RadioButton rbtnKHDnhanvien;
        private System.Windows.Forms.DataGridView dgrid_NhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DiaChiNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.CheckBox chk_quanLi;
        private System.Windows.Forms.CheckBox chk_nhanVien;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_nam;
        private System.Windows.Forms.CheckBox chk_nu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}