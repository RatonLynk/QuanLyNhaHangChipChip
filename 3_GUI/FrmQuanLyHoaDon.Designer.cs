
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgrid_hdct = new System.Windows.Forms.DataGridView();
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
            this.btnXoa.Location = new System.Drawing.Point(582, 30);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 25);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(371, 29);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 25);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(753, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
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
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 568);
            this.Controls.Add(this.dgrid_hdct);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dgid_HoaDon);
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
            this.Name = "FrmQuanLyHoaDon";
            this.Text = "Quản lý in hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgid_HoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgrid_hdct;
    }
}