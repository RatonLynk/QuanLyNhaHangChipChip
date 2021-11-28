
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
            this.Dgid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgid_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Dgid_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgid_HoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Dgid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgid_HoaDon.Location = new System.Drawing.Point(1, 96);
            this.Dgid_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgid_HoaDon.Name = "Dgid_HoaDon";
            this.Dgid_HoaDon.RowHeadersWidth = 51;
            this.Dgid_HoaDon.Size = new System.Drawing.Size(618, 471);
            this.Dgid_HoaDon.TabIndex = 33;
            this.Dgid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgid_HoaDon_CellClick);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_danhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhsach.Location = new System.Drawing.Point(975, 34);
            this.btn_danhsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(102, 25);
            this.btn_danhsach.TabIndex = 31;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_thongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongKe.Location = new System.Drawing.Point(528, 28);
            this.btn_thongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.Size = new System.Drawing.Size(102, 25);
            this.btn_thongKe.TabIndex = 30;
            this.btn_thongKe.Text = "Thống Kê";
            this.btn_thongKe.UseVisualStyleBackColor = true;
            this.btn_thongKe.Click += new System.EventHandler(this.btn_thongKe_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 23);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(327, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 23);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // dgrid_hdct
            // 
            this.dgrid_hdct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_hdct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgrid_hdct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_hdct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgrid_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hdct.Location = new System.Drawing.Point(710, 106);
            this.dgrid_hdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_hdct.Name = "dgrid_hdct";
            this.dgrid_hdct.RowHeadersWidth = 51;
            this.dgrid_hdct.Size = new System.Drawing.Size(426, 471);
            this.dgrid_hdct.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Đến ngày:";
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_hdct);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dgid_HoaDon);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_thongKe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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