
namespace _3_GUI
{
    partial class FrmTachHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTachHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgrid_HDCu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgrid_HDMoi = new System.Windows.Forms.DataGridView();
            this.Btn_TaoHD = new System.Windows.Forms.Button();
            this.Btn_XacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_TongTien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDCu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgrid_HDCu);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(570, 679);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn cũ";
            // 
            // Dgrid_HDCu
            // 
            this.Dgrid_HDCu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_HDCu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgrid_HDCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_HDCu.Location = new System.Drawing.Point(7, 29);
            this.Dgrid_HDCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgrid_HDCu.Name = "Dgrid_HDCu";
            this.Dgrid_HDCu.RowHeadersWidth = 51;
            this.Dgrid_HDCu.RowTemplate.Height = 25;
            this.Dgrid_HDCu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_HDCu.Size = new System.Drawing.Size(555, 629);
            this.Dgrid_HDCu.TabIndex = 0;
            this.Dgrid_HDCu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_HDCu_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgrid_HDMoi);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(752, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(570, 679);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn mới";
            // 
            // Dgrid_HDMoi
            // 
            this.Dgrid_HDMoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_HDMoi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgrid_HDMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_HDMoi.Location = new System.Drawing.Point(24, 39);
            this.Dgrid_HDMoi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Dgrid_HDMoi.Name = "Dgrid_HDMoi";
            this.Dgrid_HDMoi.RowHeadersWidth = 51;
            this.Dgrid_HDMoi.RowTemplate.Height = 25;
            this.Dgrid_HDMoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_HDMoi.Size = new System.Drawing.Size(539, 629);
            this.Dgrid_HDMoi.TabIndex = 1;
            this.Dgrid_HDMoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_HDMoi_CellClick);
            // 
            // Btn_TaoHD
            // 
            this.Btn_TaoHD.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_TaoHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_TaoHD.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TaoHD.Image")));
            this.Btn_TaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TaoHD.Location = new System.Drawing.Point(602, 292);
            this.Btn_TaoHD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_TaoHD.Name = "Btn_TaoHD";
            this.Btn_TaoHD.Size = new System.Drawing.Size(127, 49);
            this.Btn_TaoHD.TabIndex = 2;
            this.Btn_TaoHD.Text = "Tạo Hóa Đơn";
            this.Btn_TaoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_TaoHD.UseVisualStyleBackColor = false;
            this.Btn_TaoHD.Click += new System.EventHandler(this.Btn_TaoHD_Click);
            // 
            // Btn_XacNhan
            // 
            this.Btn_XacNhan.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_XacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_XacNhan.Image = ((System.Drawing.Image)(resources.GetObject("Btn_XacNhan.Image")));
            this.Btn_XacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_XacNhan.Location = new System.Drawing.Point(1152, 711);
            this.Btn_XacNhan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_XacNhan.Name = "Btn_XacNhan";
            this.Btn_XacNhan.Size = new System.Drawing.Size(119, 49);
            this.Btn_XacNhan.TabIndex = 3;
            this.Btn_XacNhan.Text = "Xác nhận";
            this.Btn_XacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_XacNhan.UseVisualStyleBackColor = false;
            this.Btn_XacNhan.Click += new System.EventHandler(this.Btn_XacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(594, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền:";
            // 
            // Lbl_TongTien
            // 
            this.Lbl_TongTien.AutoSize = true;
            this.Lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TongTien.ForeColor = System.Drawing.Color.Red;
            this.Lbl_TongTien.Location = new System.Drawing.Point(697, 419);
            this.Lbl_TongTien.Name = "Lbl_TongTien";
            this.Lbl_TongTien.Size = new System.Drawing.Size(52, 21);
            this.Lbl_TongTien.TabIndex = 5;
            this.Lbl_TongTien.Text = "label2";
            // 
            // FrmTachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1338, 825);
            this.Controls.Add(this.Btn_XacNhan);
            this.Controls.Add(this.Btn_TaoHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmTachHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tách hóa đơn";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDCu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDMoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrid_HDCu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgrid_HDMoi;
        private System.Windows.Forms.Button Btn_TaoHD;
        private System.Windows.Forms.Button Btn_XacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_TongTien;
    }
}