
namespace _3_GUI
{
    partial class FrmThemBan
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
            this.Btn_XacNhan = new System.Windows.Forms.Button();
            this.Txt_TenBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_Tang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_XacNhan
            // 
            this.Btn_XacNhan.Location = new System.Drawing.Point(107, 133);
            this.Btn_XacNhan.Name = "Btn_XacNhan";
            this.Btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.Btn_XacNhan.TabIndex = 0;
            this.Btn_XacNhan.Text = "Xác nhận";
            this.Btn_XacNhan.UseVisualStyleBackColor = true;
            this.Btn_XacNhan.Click += new System.EventHandler(this.Btn_XacNhan_Click);
            // 
            // Txt_TenBan
            // 
            this.Txt_TenBan.Location = new System.Drawing.Point(88, 27);
            this.Txt_TenBan.Name = "Txt_TenBan";
            this.Txt_TenBan.Size = new System.Drawing.Size(150, 23);
            this.Txt_TenBan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tầng:";
            // 
            // Cbx_Tang
            // 
            this.Cbx_Tang.FormattingEnabled = true;
            this.Cbx_Tang.Location = new System.Drawing.Point(88, 72);
            this.Cbx_Tang.Name = "Cbx_Tang";
            this.Cbx_Tang.Size = new System.Drawing.Size(150, 23);
            this.Cbx_Tang.TabIndex = 4;
            // 
            // FrmThemBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 186);
            this.Controls.Add(this.Cbx_Tang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_TenBan);
            this.Controls.Add(this.Btn_XacNhan);
            this.Name = "FrmThemBan";
            this.Text = "FrmThemBan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_XacNhan;
        private System.Windows.Forms.TextBox Txt_TenBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbx_Tang;
    }
}