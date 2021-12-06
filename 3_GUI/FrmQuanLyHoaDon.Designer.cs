
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
            this.Dgid_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_thongKe = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgrid_hdct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgid_HoaDon
            // 
            this.Dgid_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgid_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Dgid_HoaDon.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgid_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgid_HoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Dgid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgid_HoaDon.Location = new System.Drawing.Point(21, 63);
            this.Dgid_HoaDon.Name = "Dgid_HoaDon";
            this.Dgid_HoaDon.RowHeadersWidth = 51;
            this.Dgid_HoaDon.Size = new System.Drawing.Size(617, 558);
            this.Dgid_HoaDon.TabIndex = 33;
            this.Dgid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgid_HoaDon_CellClick);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_danhsach.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_danhsach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_danhsach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btn_danhsach.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhsach.Image")));
            this.btn_danhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_danhsach.Location = new System.Drawing.Point(855, 13);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_danhsach.Size = new System.Drawing.Size(117, 33);
            this.btn_danhsach.TabIndex = 31;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhsach.UseVisualStyleBackColor = false;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_thongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_thongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btn_thongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongKe.Image")));
            this.btn_thongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thongKe.Location = new System.Drawing.Point(521, 13);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_thongKe.Size = new System.Drawing.Size(117, 33);
            this.btn_thongKe.TabIndex = 30;
            this.btn_thongKe.Text = "Thống kê";
            this.btn_thongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongKe.UseVisualStyleBackColor = false;
            this.btn_thongKe.Click += new System.EventHandler(this.btn_thongKe_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 27);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(370, 17);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 27);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // dgrid_hdct
            // 
            this.dgrid_hdct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_hdct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_hdct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgrid_hdct.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgrid_hdct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_hdct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgrid_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hdct.Location = new System.Drawing.Point(682, 63);
            this.dgrid_hdct.Name = "dgrid_hdct";
            this.dgrid_hdct.RowHeadersWidth = 51;
            this.dgrid_hdct.Size = new System.Drawing.Size(442, 558);
            this.dgrid_hdct.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(289, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Đến ngày:";
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_hdct);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dgid_HoaDon);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_thongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLyHoaDon";
            this.Text = "Quản lý in hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgid_HoaDon;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_thongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgrid_hdct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}