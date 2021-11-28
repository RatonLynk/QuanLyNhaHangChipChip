
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn cũ";
            // 
            // Dgrid_HDCu
            // 
            this.Dgrid_HDCu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_HDCu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgrid_HDCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_HDCu.Location = new System.Drawing.Point(6, 22);
            this.Dgrid_HDCu.Name = "Dgrid_HDCu";
            this.Dgrid_HDCu.RowHeadersWidth = 51;
            this.Dgrid_HDCu.RowTemplate.Height = 25;
            this.Dgrid_HDCu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_HDCu.Size = new System.Drawing.Size(425, 354);
            this.Dgrid_HDCu.TabIndex = 0;
            this.Dgrid_HDCu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_HDCu_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgrid_HDMoi);
            this.groupBox2.Location = new System.Drawing.Point(576, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn mới";
            // 
            // Dgrid_HDMoi
            // 
            this.Dgrid_HDMoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_HDMoi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgrid_HDMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_HDMoi.Location = new System.Drawing.Point(18, 22);
            this.Dgrid_HDMoi.Name = "Dgrid_HDMoi";
            this.Dgrid_HDMoi.RowHeadersWidth = 51;
            this.Dgrid_HDMoi.RowTemplate.Height = 25;
            this.Dgrid_HDMoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_HDMoi.Size = new System.Drawing.Size(413, 354);
            this.Dgrid_HDMoi.TabIndex = 1;
            this.Dgrid_HDMoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_HDMoi_CellClick);
            // 
            // Btn_TaoHD
            // 
            this.Btn_TaoHD.Location = new System.Drawing.Point(472, 164);
            this.Btn_TaoHD.Name = "Btn_TaoHD";
            this.Btn_TaoHD.Size = new System.Drawing.Size(89, 38);
            this.Btn_TaoHD.TabIndex = 2;
            this.Btn_TaoHD.Text = "Tạo Hóa Đơn";
            this.Btn_TaoHD.UseVisualStyleBackColor = true;
            this.Btn_TaoHD.Click += new System.EventHandler(this.Btn_TaoHD_Click);
            // 
            // Btn_XacNhan
            // 
            this.Btn_XacNhan.Location = new System.Drawing.Point(882, 400);
            this.Btn_XacNhan.Name = "Btn_XacNhan";
            this.Btn_XacNhan.Size = new System.Drawing.Size(99, 52);
            this.Btn_XacNhan.TabIndex = 3;
            this.Btn_XacNhan.Text = "Xác nhận";
            this.Btn_XacNhan.UseVisualStyleBackColor = true;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 464);
            this.Controls.Add(this.Lbl_TongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_XacNhan);
            this.Controls.Add(this.Btn_TaoHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTachHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTachHoaDon";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDCu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDMoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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