
namespace _3_GUI
{
    partial class FrmQLMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_khongHoatDong = new System.Windows.Forms.RadioButton();
            this.rdo_hoatDong = new System.Windows.Forms.RadioButton();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_TenMon = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.danhMụcMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcMónĂnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đồTrênBờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồTrênTrờiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(732, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_khongHoatDong);
            this.groupBox1.Controls.Add(this.rdo_hoatDong);
            this.groupBox1.Controls.Add(this.lbl_TrangThai);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_Gia);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_TenMon);
            this.groupBox1.Controls.Add(this.lbl_Search);
            this.groupBox1.Controls.Add(this.tbx_Search);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí món ăn";
            // 
            // rdo_khongHoatDong
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(6, 173);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 34);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm món ăn";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // rdo_hoatDong
            // 
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(117, 173);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 34);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa món ăn";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(228, 173);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(105, 32);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa món ăn";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(142, 221);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(191, 29);
            this.tbx_Search.TabIndex = 3;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Search.Location = new System.Drawing.Point(6, 227);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(131, 17);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Tìm kiếm món ăn :";
            // 
            // lbl_TenMon
            // 
            this.lbl_TenMon.AutoSize = true;
            this.lbl_TenMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TenMon.Location = new System.Drawing.Point(17, 36);
            this.lbl_TenMon.Name = "lbl_TenMon";
            this.lbl_TenMon.Size = new System.Drawing.Size(85, 17);
            this.lbl_TenMon.TabIndex = 5;
            this.lbl_TenMon.Text = "Tên món ăn";
            // 
            // comboBox1
            // 
            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 29);
            this.textBox1.TabIndex = 6;
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gia.Location = new System.Drawing.Point(47, 72);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(30, 17);
            this.lbl_Gia.TabIndex = 7;
            this.lbl_Gia.Text = "Giá";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 29);
            this.textBox2.TabIndex = 8;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TrangThai.Location = new System.Drawing.Point(17, 122);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(79, 17);
            this.lbl_TrangThai.TabIndex = 9;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // rdo_hoatDong
            // 
            this.rdo_hoatDong.AutoSize = true;
            this.rdo_hoatDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_hoatDong.Location = new System.Drawing.Point(117, 109);
            this.rdo_hoatDong.Name = "rdo_hoatDong";
            this.rdo_hoatDong.Size = new System.Drawing.Size(94, 21);
            this.rdo_hoatDong.TabIndex = 10;
            this.rdo_hoatDong.TabStop = true;
            this.rdo_hoatDong.Text = "Hoạt động";
            this.rdo_hoatDong.UseVisualStyleBackColor = true;
            // 
            // rdo_khongHoatDong
            // 
            this.rdo_khongHoatDong.AutoSize = true;
            this.rdo_khongHoatDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_khongHoatDong.Location = new System.Drawing.Point(117, 136);
            this.rdo_khongHoatDong.Name = "rdo_khongHoatDong";
            this.rdo_khongHoatDong.Size = new System.Drawing.Size(142, 21);
            this.rdo_khongHoatDong.TabIndex = 11;
            this.rdo_khongHoatDong.TabStop = true;
            this.rdo_khongHoatDong.Text = "Không Hoạt động";
            this.rdo_khongHoatDong.UseVisualStyleBackColor = true;
            // 
            // FrmQLMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmQLMenu";
            this.Text = "FrmQLMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_TenMon;
        private System.Windows.Forms.RadioButton rdo_khongHoatDong;
        private System.Windows.Forms.RadioButton rdo_hoatDong;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMónĂnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMónĂnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đồTrênBờToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồTrênTrờiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}