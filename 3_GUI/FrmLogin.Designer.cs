
namespace _3_GUI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.lbl_taikhoan = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lbl_quenMatKhau = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_dangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dangNhap.Location = new System.Drawing.Point(156, 132);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(99, 33);
            this.btn_dangNhap.TabIndex = 0;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            // 
            // lbl_taikhoan
            // 
            this.lbl_taikhoan.AutoSize = true;
            this.lbl_taikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_taikhoan.Location = new System.Drawing.Point(12, 51);
            this.lbl_taikhoan.Name = "lbl_taikhoan";
            this.lbl_taikhoan.Size = new System.Drawing.Size(76, 19);
            this.lbl_taikhoan.TabIndex = 1;
            this.lbl_taikhoan.Text = "Tài khoản :";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(94, 51);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(161, 23);
            this.txt_taikhoan.TabIndex = 2;
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_matkhau.Location = new System.Drawing.Point(14, 92);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(74, 19);
            this.lbl_matkhau.TabIndex = 3;
            this.lbl_matkhau.Text = "Mật khẩu :";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(94, 92);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(161, 23);
            this.txt_matkhau.TabIndex = 4;
            // 
            // lbl_quenMatKhau
            // 
            this.lbl_quenMatKhau.AutoSize = true;
            this.lbl_quenMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_quenMatKhau.Location = new System.Drawing.Point(12, 139);
            this.lbl_quenMatKhau.Name = "lbl_quenMatKhau";
            this.lbl_quenMatKhau.Size = new System.Drawing.Size(112, 19);
            this.lbl_quenMatKhau.TabIndex = 5;
            this.lbl_quenMatKhau.Text = "Quên mật khẩu ?";
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(156, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_quenMatKhau);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.lbl_taikhoan);
            this.Controls.Add(this.btn_dangNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Label lbl_taikhoan;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lbl_quenMatKhau;
        private System.Windows.Forms.Button button1;
    }
}

