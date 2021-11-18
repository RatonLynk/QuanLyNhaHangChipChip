namespace _3_GUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rbtn_HDthucdon = new System.Windows.Forms.RadioButton();
            this.rbtn_KHDthucdon = new System.Windows.Forms.RadioButton();
            this.txt_TimKiemThucDon = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbx_Meth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Cat = new System.Windows.Forms.ComboBox();
            this.cbx_Unit = new System.Windows.Forms.ComboBox();
            this.txt_Price = new System.Windows.Forms.NumericUpDown();
            this.dgvCongThuc = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaCP = new System.Windows.Forms.Button();
            this.btnThemCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_IngreName = new System.Windows.Forms.ComboBox();
            this.cbx_RecipeName = new System.Windows.Forms.ComboBox();
            this.btn_ConfigUnit = new System.Windows.Forms.Button();
            this.btn_ConfigMeth = new System.Windows.Forms.Button();
            this.btn_ConfigCat = new System.Windows.Forms.Button();
            this.btn_ConfigIngre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(54, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTenMonAn.Location = new System.Drawing.Point(132, 116);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(233, 26);
            this.txtTenMonAn.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên món ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(41, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Giá tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(423, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Đơn vị tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(289, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "VNĐ";
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
            this.dgvMonAn.Location = new System.Drawing.Point(41, 383);
            this.dgvMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(759, 572);
            this.dgvMonAn.TabIndex = 20;
            this.dgvMonAn.TabStop = false;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1923, 168);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "label14";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.Image")));
            this.btnXoaMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMon.Location = new System.Drawing.Point(556, 265);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(125, 49);
            this.btnXoaMon.TabIndex = 10;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMon.Image")));
            this.btnSuaMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaMon.Location = new System.Drawing.Point(365, 265);
            this.btnSuaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(125, 49);
            this.btnSuaMon.TabIndex = 9;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = true;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.Location = new System.Drawing.Point(177, 265);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(125, 49);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(421, 164);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Cách nấu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(41, 216);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Trạng thái :";
            // 
            // rbtn_HDthucdon
            // 
            this.rbtn_HDthucdon.AutoSize = true;
            this.rbtn_HDthucdon.Location = new System.Drawing.Point(147, 214);
            this.rbtn_HDthucdon.Name = "rbtn_HDthucdon";
            this.rbtn_HDthucdon.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HDthucdon.TabIndex = 35;
            this.rbtn_HDthucdon.TabStop = true;
            this.rbtn_HDthucdon.Text = "Hoạt động";
            this.rbtn_HDthucdon.UseVisualStyleBackColor = true;
            // 
            // rbtn_KHDthucdon
            // 
            this.rbtn_KHDthucdon.AutoSize = true;
            this.rbtn_KHDthucdon.Location = new System.Drawing.Point(269, 214);
            this.rbtn_KHDthucdon.Name = "rbtn_KHDthucdon";
            this.rbtn_KHDthucdon.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KHDthucdon.TabIndex = 35;
            this.rbtn_KHDthucdon.TabStop = true;
            this.rbtn_KHDthucdon.Text = "Không hoạt động";
            this.rbtn_KHDthucdon.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemThucDon
            // 
            this.txt_TimKiemThucDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TimKiemThucDon.ForeColor = System.Drawing.Color.Black;
            this.txt_TimKiemThucDon.Location = new System.Drawing.Point(575, 350);
            this.txt_TimKiemThucDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TimKiemThucDon.Name = "txt_TimKiemThucDon";
            this.txt_TimKiemThucDon.Size = new System.Drawing.Size(225, 26);
            this.txt_TimKiemThucDon.TabIndex = 0;
            this.txt_TimKiemThucDon.TextChanged += new System.EventHandler(this.txt_TimKiemThucDon_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(480, 353);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Tìm kiếm :";
            // 
            // cbx_Meth
            // 
            this.cbx_Meth.FormattingEnabled = true;
            this.cbx_Meth.Location = new System.Drawing.Point(514, 161);
            this.cbx_Meth.Name = "cbx_Meth";
            this.cbx_Meth.Size = new System.Drawing.Size(205, 28);
            this.cbx_Meth.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(421, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh mục";
            // 
            // cbx_Cat
            // 
            this.cbx_Cat.FormattingEnabled = true;
            this.cbx_Cat.Location = new System.Drawing.Point(514, 208);
            this.cbx_Cat.Name = "cbx_Cat";
            this.cbx_Cat.Size = new System.Drawing.Size(205, 28);
            this.cbx_Cat.TabIndex = 36;
            // 
            // cbx_Unit
            // 
            this.cbx_Unit.FormattingEnabled = true;
            this.cbx_Unit.Location = new System.Drawing.Point(514, 113);
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
            this.txt_Price.Location = new System.Drawing.Point(132, 166);
            this.txt_Price.Maximum = new decimal(new int[] {
            999000000,
            0,
            0,
            0});
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(150, 27);
            this.txt_Price.TabIndex = 37;
            // 
            // dgvCongThuc
            // 
            this.dgvCongThuc.AllowUserToResizeRows = false;
            this.dgvCongThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongThuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCongThuc.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCongThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCongThuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCongThuc.Location = new System.Drawing.Point(850, 381);
            this.dgvCongThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCongThuc.MultiSelect = false;
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.ReadOnly = true;
            this.dgvCongThuc.RowHeadersVisible = false;
            this.dgvCongThuc.RowHeadersWidth = 51;
            this.dgvCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongThuc.Size = new System.Drawing.Size(471, 574);
            this.dgvCongThuc.TabIndex = 55;
            this.dgvCongThuc.TabStop = false;
            this.dgvCongThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongThuc_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(875, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tên Nguyên Liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(905, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tên Món";
            // 
            // btnXoaCP
            // 
            this.btnXoaCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaCP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCP.Image")));
            this.btnXoaCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCP.Location = new System.Drawing.Point(1134, 265);
            this.btnXoaCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaCP.Name = "btnXoaCP";
            this.btnXoaCP.Size = new System.Drawing.Size(125, 49);
            this.btnXoaCP.TabIndex = 56;
            this.btnXoaCP.Text = "Xóa";
            this.btnXoaCP.UseVisualStyleBackColor = true;
            this.btnXoaCP.Click += new System.EventHandler(this.btnXoaCP_Click);
            // 
            // btnThemCP
            // 
            this.btnThemCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemCP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCP.Image")));
            this.btnThemCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCP.Location = new System.Drawing.Point(930, 265);
            this.btnThemCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemCP.Name = "btnThemCP";
            this.btnThemCP.Size = new System.Drawing.Size(125, 49);
            this.btnThemCP.TabIndex = 53;
            this.btnThemCP.Text = "Thêm";
            this.btnThemCP.UseVisualStyleBackColor = true;
            this.btnThemCP.Click += new System.EventHandler(this.btnThemCP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(850, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "CÔNG THỨC";
            // 
            // cbx_IngreName
            // 
            this.cbx_IngreName.FormattingEnabled = true;
            this.cbx_IngreName.Location = new System.Drawing.Point(1017, 188);
            this.cbx_IngreName.Name = "cbx_IngreName";
            this.cbx_IngreName.Size = new System.Drawing.Size(257, 28);
            this.cbx_IngreName.TabIndex = 62;
            // 
            // cbx_RecipeName
            // 
            this.cbx_RecipeName.FormattingEnabled = true;
            this.cbx_RecipeName.Location = new System.Drawing.Point(1017, 125);
            this.cbx_RecipeName.Name = "cbx_RecipeName";
            this.cbx_RecipeName.Size = new System.Drawing.Size(257, 28);
            this.cbx_RecipeName.TabIndex = 63;
            // 
            // btn_ConfigUnit
            // 
            this.btn_ConfigUnit.BackgroundImage = global::_3_GUI.Properties.Resources._568239;
            this.btn_ConfigUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConfigUnit.Location = new System.Drawing.Point(736, 113);
            this.btn_ConfigUnit.Name = "btn_ConfigUnit";
            this.btn_ConfigUnit.Size = new System.Drawing.Size(29, 29);
            this.btn_ConfigUnit.TabIndex = 64;
            this.btn_ConfigUnit.UseVisualStyleBackColor = true;
            this.btn_ConfigUnit.Click += new System.EventHandler(this.btn_ConfigUnit_Click);
            // 
            // btn_ConfigMeth
            // 
            this.btn_ConfigMeth.BackgroundImage = global::_3_GUI.Properties.Resources._568239;
            this.btn_ConfigMeth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConfigMeth.Location = new System.Drawing.Point(736, 161);
            this.btn_ConfigMeth.Name = "btn_ConfigMeth";
            this.btn_ConfigMeth.Size = new System.Drawing.Size(29, 29);
            this.btn_ConfigMeth.TabIndex = 64;
            this.btn_ConfigMeth.UseVisualStyleBackColor = true;
            this.btn_ConfigMeth.Click += new System.EventHandler(this.btn_ConfigMeth_Click);
            // 
            // btn_ConfigCat
            // 
            this.btn_ConfigCat.BackgroundImage = global::_3_GUI.Properties.Resources._568239;
            this.btn_ConfigCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConfigCat.Location = new System.Drawing.Point(736, 207);
            this.btn_ConfigCat.Name = "btn_ConfigCat";
            this.btn_ConfigCat.Size = new System.Drawing.Size(29, 29);
            this.btn_ConfigCat.TabIndex = 64;
            this.btn_ConfigCat.UseVisualStyleBackColor = true;
            this.btn_ConfigCat.Click += new System.EventHandler(this.btn_ConfigCat_Click);
            // 
            // btn_ConfigIngre
            // 
            this.btn_ConfigIngre.BackgroundImage = global::_3_GUI.Properties.Resources._568239;
            this.btn_ConfigIngre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConfigIngre.Location = new System.Drawing.Point(1292, 188);
            this.btn_ConfigIngre.Name = "btn_ConfigIngre";
            this.btn_ConfigIngre.Size = new System.Drawing.Size(29, 29);
            this.btn_ConfigIngre.TabIndex = 64;
            this.btn_ConfigIngre.UseVisualStyleBackColor = true;
            this.btn_ConfigIngre.Click += new System.EventHandler(this.btn_ConfigIngre_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_3_GUI.Properties.Resources.download;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 49);
            this.button1.TabIndex = 65;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmQuanLyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1359, 983);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ConfigCat);
            this.Controls.Add(this.btn_ConfigMeth);
            this.Controls.Add(this.btn_ConfigIngre);
            this.Controls.Add(this.btn_ConfigUnit);
            this.Controls.Add(this.cbx_RecipeName);
            this.Controls.Add(this.cbx_IngreName);
            this.Controls.Add(this.dgvCongThuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaCP);
            this.Controls.Add(this.btnThemCP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.cbx_Unit);
            this.Controls.Add(this.cbx_Cat);
            this.Controls.Add(this.cbx_Meth);
            this.Controls.Add(this.rbtn_KHDthucdon);
            this.Controls.Add(this.rbtn_HDthucdon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_TimKiemThucDon);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyThucDon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thực Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbtn_HDthucdon;
        private System.Windows.Forms.RadioButton rbtn_KHDthucdon;
        private System.Windows.Forms.TextBox txt_TimKiemThucDon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbx_Meth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Cat;
        private System.Windows.Forms.ComboBox cbx_Unit;
        private System.Windows.Forms.NumericUpDown txt_Price;
        private System.Windows.Forms.DataGridView dgvCongThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaCP;
        private System.Windows.Forms.Button btnThemCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_IngreName;
        private System.Windows.Forms.ComboBox cbx_RecipeName;
        private System.Windows.Forms.Button btn_ConfigUnit;
        private System.Windows.Forms.Button btn_ConfigMeth;
        private System.Windows.Forms.Button btn_ConfigCat;
        private System.Windows.Forms.Button btn_ConfigIngre;
        private System.Windows.Forms.Button button1;
    }
}