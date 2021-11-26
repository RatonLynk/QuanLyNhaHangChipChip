
namespace _3_GUI
{
    partial class FrmQLBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLBan));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgid_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Lbl_GioRa = new System.Windows.Forms.Label();
            this.Lbl_GioVao = new System.Windows.Forms.Label();
            this.Lbl_ViTriBan = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.Btn_TachBan = new System.Windows.Forms.Button();
            this.Btn_GopBan = new System.Windows.Forms.Button();
            this.Btn_ChuyenBan = new System.Windows.Forms.Button();
            this.Btn_HuyBan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dgid_Meniu = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_XuatBill = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_TongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tp_Tang1 = new System.Windows.Forms.TabPage();
            this.FLPenal = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_ThemBanT1 = new System.Windows.Forms.Button();
            this.Btn_XoaBanT1 = new System.Windows.Forms.Button();
            this.Tp_Tang2 = new System.Windows.Forms.TabPage();
            this.Btn_ThemBanT2 = new System.Windows.Forms.Button();
            this.FlPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_XoaBanT2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_MangVe = new System.Windows.Forms.Button();
            this.FlPanl_MangVe = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_HoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_Meniu)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tp_Tang1.SuspendLayout();
            this.Tp_Tang2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Dgid_HoaDon);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(398, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(457, 319);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách món đã gọi";
            // 
            // Dgid_HoaDon
            // 
            this.Dgid_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgid_HoaDon.Location = new System.Drawing.Point(5, 23);
            this.Dgid_HoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.Dgid_HoaDon.Name = "Dgid_HoaDon";
            this.Dgid_HoaDon.RowHeadersWidth = 51;
            this.Dgid_HoaDon.RowTemplate.Height = 25;
            this.Dgid_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgid_HoaDon.Size = new System.Drawing.Size(448, 276);
            this.Dgid_HoaDon.TabIndex = 23;
            this.Dgid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgid_HoaDon_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.Lbl_GioRa);
            this.groupBox3.Controls.Add(this.Lbl_GioVao);
            this.groupBox3.Controls.Add(this.Lbl_ViTriBan);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.Btn_TachBan);
            this.groupBox3.Controls.Add(this.Btn_GopBan);
            this.groupBox3.Controls.Add(this.Btn_ChuyenBan);
            this.groupBox3.Controls.Add(this.Btn_HuyBan);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(418, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(433, 170);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // Lbl_GioRa
            // 
            this.Lbl_GioRa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_GioRa.AutoSize = true;
            this.Lbl_GioRa.ForeColor = System.Drawing.Color.White;
            this.Lbl_GioRa.Location = new System.Drawing.Point(153, 76);
            this.Lbl_GioRa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_GioRa.Name = "Lbl_GioRa";
            this.Lbl_GioRa.Size = new System.Drawing.Size(108, 13);
            this.Lbl_GioRa.TabIndex = 29;
            this.Lbl_GioRa.Text = "00:00:00 00/00/2021";
            // 
            // Lbl_GioVao
            // 
            this.Lbl_GioVao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_GioVao.AutoSize = true;
            this.Lbl_GioVao.ForeColor = System.Drawing.Color.White;
            this.Lbl_GioVao.Location = new System.Drawing.Point(153, 50);
            this.Lbl_GioVao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_GioVao.Name = "Lbl_GioVao";
            this.Lbl_GioVao.Size = new System.Drawing.Size(108, 13);
            this.Lbl_GioVao.TabIndex = 28;
            this.Lbl_GioVao.Text = "00:00:00 00/00/2021";
            // 
            // Lbl_ViTriBan
            // 
            this.Lbl_ViTriBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_ViTriBan.AutoSize = true;
            this.Lbl_ViTriBan.ForeColor = System.Drawing.Color.White;
            this.Lbl_ViTriBan.Location = new System.Drawing.Point(196, 13);
            this.Lbl_ViTriBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ViTriBan.Name = "Lbl_ViTriBan";
            this.Lbl_ViTriBan.Size = new System.Drawing.Size(26, 13);
            this.Lbl_ViTriBan.TabIndex = 27;
            this.Lbl_ViTriBan.Text = "Bàn";
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.button12.Location = new System.Drawing.Point(307, 72);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 27);
            this.button12.TabIndex = 26;
            this.button12.Text = "Kết thúc";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Btn_TachBan
            // 
            this.Btn_TachBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_TachBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_TachBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_TachBan.Location = new System.Drawing.Point(276, 121);
            this.Btn_TachBan.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_TachBan.Name = "Btn_TachBan";
            this.Btn_TachBan.Size = new System.Drawing.Size(92, 35);
            this.Btn_TachBan.TabIndex = 25;
            this.Btn_TachBan.Text = "Tách bàn";
            this.Btn_TachBan.UseVisualStyleBackColor = false;
            // 
            // Btn_GopBan
            // 
            this.Btn_GopBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_GopBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_GopBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_GopBan.Location = new System.Drawing.Point(184, 121);
            this.Btn_GopBan.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_GopBan.Name = "Btn_GopBan";
            this.Btn_GopBan.Size = new System.Drawing.Size(88, 35);
            this.Btn_GopBan.TabIndex = 24;
            this.Btn_GopBan.Text = "Gộp bàn";
            this.Btn_GopBan.UseVisualStyleBackColor = false;
            // 
            // Btn_ChuyenBan
            // 
            this.Btn_ChuyenBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ChuyenBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ChuyenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_ChuyenBan.Location = new System.Drawing.Point(60, 121);
            this.Btn_ChuyenBan.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ChuyenBan.Name = "Btn_ChuyenBan";
            this.Btn_ChuyenBan.Size = new System.Drawing.Size(99, 35);
            this.Btn_ChuyenBan.TabIndex = 23;
            this.Btn_ChuyenBan.Text = "Chuyển bàn";
            this.Btn_ChuyenBan.UseVisualStyleBackColor = false;
            // 
            // Btn_HuyBan
            // 
            this.Btn_HuyBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_HuyBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_HuyBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_HuyBan.Location = new System.Drawing.Point(307, 19);
            this.Btn_HuyBan.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_HuyBan.Name = "Btn_HuyBan";
            this.Btn_HuyBan.Size = new System.Drawing.Size(61, 28);
            this.Btn_HuyBan.TabIndex = 3;
            this.Btn_HuyBan.Text = "Hủy Bàn";
            this.Btn_HuyBan.UseVisualStyleBackColor = false;
            this.Btn_HuyBan.Click += new System.EventHandler(this.Btn_HuyBan_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ ra:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giờ vào:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vị trí bàn:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.Dgid_Meniu);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(19, 507);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(805, 224);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 21);
            this.textBox1.TabIndex = 1;
            // 
            // Dgid_Meniu
            // 
            this.Dgid_Meniu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgid_Meniu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgid_Meniu.Location = new System.Drawing.Point(11, 40);
            this.Dgid_Meniu.Margin = new System.Windows.Forms.Padding(2);
            this.Dgid_Meniu.Name = "Dgid_Meniu";
            this.Dgid_Meniu.RowHeadersWidth = 51;
            this.Dgid_Meniu.RowTemplate.Height = 25;
            this.Dgid_Meniu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgid_Meniu.Size = new System.Drawing.Size(790, 168);
            this.Dgid_Meniu.TabIndex = 0;
            this.Dgid_Meniu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgid_Meniu_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_XuatBill);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.Btn_ThanhToan);
            this.groupBox5.Controls.Add(this.Lbl_TongTien);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(835, 507);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(353, 224);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // Btn_XuatBill
            // 
            this.Btn_XuatBill.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_XuatBill.ForeColor = System.Drawing.Color.Black;
            this.Btn_XuatBill.Image = ((System.Drawing.Image)(resources.GetObject("Btn_XuatBill.Image")));
            this.Btn_XuatBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_XuatBill.Location = new System.Drawing.Point(7, 117);
            this.Btn_XuatBill.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_XuatBill.Name = "Btn_XuatBill";
            this.Btn_XuatBill.Size = new System.Drawing.Size(97, 27);
            this.Btn_XuatBill.TabIndex = 27;
            this.Btn_XuatBill.Text = "Xuất bill";
            this.Btn_XuatBill.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(64, 75);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 21);
            this.textBox4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phụ phí:";
            // 
            // Lbl_TongTien
            // 
            this.Lbl_TongTien.AutoSize = true;
            this.Lbl_TongTien.ForeColor = System.Drawing.Color.White;
            this.Lbl_TongTien.Location = new System.Drawing.Point(120, 122);
            this.Lbl_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TongTien.Name = "Lbl_TongTien";
            this.Lbl_TongTien.Size = new System.Drawing.Size(60, 13);
            this.Lbl_TongTien.TabIndex = 4;
            this.Lbl_TongTien.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 21);
            this.textBox2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tp_Tang1);
            this.tabControl1.Controls.Add(this.Tp_Tang2);
            this.tabControl1.Location = new System.Drawing.Point(19, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 492);
            this.tabControl1.TabIndex = 24;
            // 
            // Tp_Tang1
            // 
            this.Tp_Tang1.Controls.Add(this.FLPenal);
            this.Tp_Tang1.Controls.Add(this.Btn_ThemBanT1);
            this.Tp_Tang1.Controls.Add(this.Btn_XoaBanT1);
            this.Tp_Tang1.Location = new System.Drawing.Point(4, 21);
            this.Tp_Tang1.Margin = new System.Windows.Forms.Padding(2);
            this.Tp_Tang1.Name = "Tp_Tang1";
            this.Tp_Tang1.Padding = new System.Windows.Forms.Padding(2);
            this.Tp_Tang1.Size = new System.Drawing.Size(365, 467);
            this.Tp_Tang1.TabIndex = 0;
            this.Tp_Tang1.Text = "Tầng 1";
            this.Tp_Tang1.UseVisualStyleBackColor = true;
            this.Tp_Tang1.Click += new System.EventHandler(this.Tp_Tang1_Click);
            // 
            // FLPenal
            // 
            this.FLPenal.Location = new System.Drawing.Point(7, 7);
            this.FLPenal.Margin = new System.Windows.Forms.Padding(2);
            this.FLPenal.Name = "FLPenal";
            this.FLPenal.Size = new System.Drawing.Size(352, 410);
            this.FLPenal.TabIndex = 29;
            // 
            // Btn_ThemBanT1
            // 
            this.Btn_ThemBanT1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_ThemBanT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_ThemBanT1.Location = new System.Drawing.Point(202, 426);
            this.Btn_ThemBanT1.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ThemBanT1.Name = "Btn_ThemBanT1";
            this.Btn_ThemBanT1.Size = new System.Drawing.Size(75, 27);
            this.Btn_ThemBanT1.TabIndex = 28;
            this.Btn_ThemBanT1.Text = "Thêm bàn";
            this.Btn_ThemBanT1.UseVisualStyleBackColor = false;
            this.Btn_ThemBanT1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_XoaBanT1
            // 
            this.Btn_XoaBanT1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_XoaBanT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_XoaBanT1.Location = new System.Drawing.Point(285, 426);
            this.Btn_XoaBanT1.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_XoaBanT1.Name = "Btn_XoaBanT1";
            this.Btn_XoaBanT1.Size = new System.Drawing.Size(75, 27);
            this.Btn_XoaBanT1.TabIndex = 27;
            this.Btn_XoaBanT1.Text = "Xóa bàn";
            this.Btn_XoaBanT1.UseVisualStyleBackColor = false;
            this.Btn_XoaBanT1.Click += new System.EventHandler(this.button20_Click);
            // 
            // Tp_Tang2
            // 
            this.Tp_Tang2.Controls.Add(this.Btn_ThemBanT2);
            this.Tp_Tang2.Controls.Add(this.FlPanel2);
            this.Tp_Tang2.Controls.Add(this.Btn_XoaBanT2);
            this.Tp_Tang2.Location = new System.Drawing.Point(4, 21);
            this.Tp_Tang2.Margin = new System.Windows.Forms.Padding(2);
            this.Tp_Tang2.Name = "Tp_Tang2";
            this.Tp_Tang2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tp_Tang2.Size = new System.Drawing.Size(365, 467);
            this.Tp_Tang2.TabIndex = 1;
            this.Tp_Tang2.Text = "Tầng 2";
            this.Tp_Tang2.UseVisualStyleBackColor = true;
            // 
            // Btn_ThemBanT2
            // 
            this.Btn_ThemBanT2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ThemBanT2.Location = new System.Drawing.Point(204, 426);
            this.Btn_ThemBanT2.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ThemBanT2.Name = "Btn_ThemBanT2";
            this.Btn_ThemBanT2.Size = new System.Drawing.Size(75, 27);
            this.Btn_ThemBanT2.TabIndex = 29;
            this.Btn_ThemBanT2.Text = "Thêm bàn";
            this.Btn_ThemBanT2.UseVisualStyleBackColor = false;
            this.Btn_ThemBanT2.Click += new System.EventHandler(this.Btn_ThemBanT2_Click_1);
            // 
            // FlPanel2
            // 
            this.FlPanel2.Location = new System.Drawing.Point(6, 7);
            this.FlPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.FlPanel2.Name = "FlPanel2";
            this.FlPanel2.Size = new System.Drawing.Size(355, 410);
            this.FlPanel2.TabIndex = 36;
            // 
            // Btn_XoaBanT2
            // 
            this.Btn_XoaBanT2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_XoaBanT2.Location = new System.Drawing.Point(288, 426);
            this.Btn_XoaBanT2.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_XoaBanT2.Name = "Btn_XoaBanT2";
            this.Btn_XoaBanT2.Size = new System.Drawing.Size(75, 27);
            this.Btn_XoaBanT2.TabIndex = 35;
            this.Btn_XoaBanT2.Text = "Xóa bàn";
            this.Btn_XoaBanT2.UseVisualStyleBackColor = false;
            this.Btn_XoaBanT2.Click += new System.EventHandler(this.Btn_XoaBanT2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.Btn_MangVe);
            this.groupBox1.Controls.Add(this.FlPanl_MangVe);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(859, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(329, 496);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn mang về";
            // 
            // Btn_MangVe
            // 
            this.Btn_MangVe.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_MangVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_MangVe.Location = new System.Drawing.Point(196, 461);
            this.Btn_MangVe.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_MangVe.Name = "Btn_MangVe";
            this.Btn_MangVe.Size = new System.Drawing.Size(129, 27);
            this.Btn_MangVe.TabIndex = 0;
            this.Btn_MangVe.Text = "Thêm mang về";
            this.Btn_MangVe.UseVisualStyleBackColor = false;
            this.Btn_MangVe.Click += new System.EventHandler(this.Btn_MangVe_Click);
            // 
            // FlPanl_MangVe
            // 
            this.FlPanl_MangVe.Location = new System.Drawing.Point(13, 21);
            this.FlPanl_MangVe.Margin = new System.Windows.Forms.Padding(2);
            this.FlPanl_MangVe.Name = "FlPanl_MangVe";
            this.FlPanl_MangVe.Size = new System.Drawing.Size(312, 436);
            this.FlPanl_MangVe.TabIndex = 0;
            // 
            // Btn_ThanhToan
            // 
            this.Btn_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ThanhToan.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_ThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_ThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ThanhToan.Image")));
            this.Btn_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ThanhToan.Location = new System.Drawing.Point(239, 163);
            this.Btn_ThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ThanhToan.Name = "Btn_ThanhToan";
            this.Btn_ThanhToan.Size = new System.Drawing.Size(110, 57);
            this.Btn_ThanhToan.TabIndex = 26;
            this.Btn_ThanhToan.Text = "Thanh Toán";
            this.Btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ThanhToan.UseVisualStyleBackColor = false;
            this.Btn_ThanhToan.Click += new System.EventHandler(this.Btn_ThanhToan_Click);
            // 
            // FrmQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1199, 742);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQLBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bàn";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_HoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_Meniu)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Tp_Tang1.ResumeLayout(false);
            this.Tp_Tang2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgid_HoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Btn_TachBan;
        private System.Windows.Forms.Button Btn_GopBan;
        private System.Windows.Forms.Button Btn_ChuyenBan;
        private System.Windows.Forms.Button Btn_HuyBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Dgid_Meniu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_XuatBill;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_TongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tp_Tang1;
        private System.Windows.Forms.TabPage Tp_Tang2;
        private System.Windows.Forms.Button Btn_ThemBanT1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel FLPenal;
        private System.Windows.Forms.FlowLayoutPanel FlPanel2;
        private System.Windows.Forms.Label Lbl_GioRa;
        private System.Windows.Forms.Label Lbl_GioVao;
        private System.Windows.Forms.Label Lbl_ViTriBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel FlPanl_MangVe;
        private System.Windows.Forms.Button Btn_ThanhToan;
        private System.Windows.Forms.Button Btn_XoaBanT1;
        private System.Windows.Forms.Button Btn_ThemBanT2;
        private System.Windows.Forms.Button Btn_XoaBanT2;
        private System.Windows.Forms.Button Btn_MangVe;
    }
}