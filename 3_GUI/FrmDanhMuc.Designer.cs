
namespace _3_GUI
{
    partial class FrmDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMuc));
            this.rbtn_KHDdanhmuc = new System.Windows.Forms.RadioButton();
            this.rbtn_HDdanhmuc = new System.Windows.Forms.RadioButton();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimkiemDM = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.btnXoaNhom = new System.Windows.Forms.Button();
            this.btnSuaNhom = new System.Windows.Forms.Button();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_KHDdanhmuc
            // 
            this.rbtn_KHDdanhmuc.AutoSize = true;
            this.rbtn_KHDdanhmuc.Location = new System.Drawing.Point(447, 213);
            this.rbtn_KHDdanhmuc.Name = "rbtn_KHDdanhmuc";
            this.rbtn_KHDdanhmuc.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KHDdanhmuc.TabIndex = 48;
            this.rbtn_KHDdanhmuc.TabStop = true;
            this.rbtn_KHDdanhmuc.Text = "Không hoạt động";
            this.rbtn_KHDdanhmuc.UseVisualStyleBackColor = true;
            // 
            // rbtn_HDdanhmuc
            // 
            this.rbtn_HDdanhmuc.AutoSize = true;
            this.rbtn_HDdanhmuc.Location = new System.Drawing.Point(308, 212);
            this.rbtn_HDdanhmuc.Name = "rbtn_HDdanhmuc";
            this.rbtn_HDdanhmuc.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HDdanhmuc.TabIndex = 49;
            this.rbtn_HDdanhmuc.TabStop = true;
            this.rbtn_HDdanhmuc.Text = "Hoạt động";
            this.rbtn_HDdanhmuc.UseVisualStyleBackColor = true;
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
            this.dgvDanhMuc.Location = new System.Drawing.Point(165, 390);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(471, 574);
            this.dgvDanhMuc.TabIndex = 41;
            this.dgvDanhMuc.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(316, 365);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 20);
            this.label18.TabIndex = 43;
            this.label18.Text = "Tìm kiếm :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(167, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Trạng thái :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(165, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tên Danh Mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(165, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã Danh Mục";
            // 
            // txtTimkiemDM
            // 
            this.txtTimkiemDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimkiemDM.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiemDM.Location = new System.Drawing.Point(411, 359);
            this.txtTimkiemDM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimkiemDM.Name = "txtTimkiemDM";
            this.txtTimkiemDM.Size = new System.Drawing.Size(225, 26);
            this.txtTimkiemDM.TabIndex = 36;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtTenDanhMuc.Location = new System.Drawing.Point(293, 163);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(256, 26);
            this.txtTenDanhMuc.TabIndex = 37;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtMaDanhMuc.Location = new System.Drawing.Point(293, 115);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(256, 26);
            this.txtMaDanhMuc.TabIndex = 46;
            this.txtMaDanhMuc.TabStop = false;
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNhom.Location = new System.Drawing.Point(464, 274);
            this.btnXoaNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(125, 49);
            this.btnXoaNhom.TabIndex = 42;
            this.btnXoaNhom.Text = "Xóa";
            this.btnXoaNhom.UseVisualStyleBackColor = true;
            // 
            // btnSuaNhom
            // 
            this.btnSuaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNhom.Image")));
            this.btnSuaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNhom.Location = new System.Drawing.Point(314, 274);
            this.btnSuaNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaNhom.Name = "btnSuaNhom";
            this.btnSuaNhom.Size = new System.Drawing.Size(125, 49);
            this.btnSuaNhom.TabIndex = 40;
            this.btnSuaNhom.Text = "Sửa";
            this.btnSuaNhom.UseVisualStyleBackColor = true;
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhom.Location = new System.Drawing.Point(167, 274);
            this.btnThemNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(125, 49);
            this.btnThemNhom.TabIndex = 39;
            this.btnThemNhom.Text = "Thêm";
            this.btnThemNhom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(165, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "DANH MỤC";
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1026);
            this.Controls.Add(this.rbtn_KHDdanhmuc);
            this.Controls.Add(this.rbtn_HDdanhmuc);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimkiemDM);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.btnXoaNhom);
            this.Controls.Add(this.btnSuaNhom);
            this.Controls.Add(this.btnThemNhom);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanhMuc";
            this.Text = "FrmDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_KHDdanhmuc;
        private System.Windows.Forms.RadioButton rbtn_HDdanhmuc;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimkiemDM;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Button btnXoaNhom;
        private System.Windows.Forms.Button btnSuaNhom;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.Label label1;
    }
}