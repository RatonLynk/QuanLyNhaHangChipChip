using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace _3_GUI
{
    public partial class FrmHome : Form
    {
        string mnv;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labNgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer_Tick(object sender, EventArgs e)
        {   
            labGio.Text = DateTime.Now.ToString("HH:mm");
            //test đ
        }

        private void btnQuanLyThucDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyThucDon frm = new FrmQuanLyThucDon();
            frm.Show();
        }
        public void manv(string MaNv)//khi cần hiện mã nv đang đăng nhập gọi nó ra(xem nhân viên nào xuất hoá đơn)
        {
            mnv = MaNv;

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyNhanVien frmQuanLyNhanVien = new FrmQuanLyNhanVien();
            frmQuanLyNhanVien.ShowDialog();
            this.Close();
        }
    }
}
