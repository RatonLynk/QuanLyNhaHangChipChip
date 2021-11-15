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
        string ten;
        public static int session = 0;
        public static string mail;
        //FrmLogin dn;
        public FrmHome()
        {
            InitializeComponent();
            lblChao.Text = ten;
           
        }     
        //private void Resetvalue()
        //{
        //    if (session == 1)
        //    {
                
           

        //        btnQuanLyNhanVien.Enabled = true;
        //        if (dn.vaitro== false)
        //        {
        //            btnQuanLyNhanVien.Enabled = false;
        //        }


        //    }
        //    else
        //    {
        //        btnQuanLyNhanVien.Enabled = false;
          
        //    }
        //}
        private void timer_Tick(object sender, EventArgs e)
        {   
            labGio.Text = DateTime.Now.ToString("HH:mm");

            //test đ
        }

        private void btnQuanLyThucDon_Click(object sender, EventArgs e)
        {
     
            FrmQuanLyThucDon frm = new FrmQuanLyThucDon();
            frm.Show();
        }
        public string manv(string MaNv,string Ten)//khi cần hiện mã nv đang đăng nhập gọi nó ra(xem nhân viên nào xuất hoá đơn)
        {
            mnv = MaNv;
            ten = Ten;
            return Ten;
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
            FrmQuanLyNhanVien a = new FrmQuanLyNhanVien();
            a.ShowDialog();
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            FrmQuanLyHoaDon a = new FrmQuanLyHoaDon();
            a.ShowDialog();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            labNgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblChao.Text = " Chào: " + FrmHome.mail;
            //Resetvalue();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau a = new FrmDoiMatKhau();
            a.ShowDialog();
        }
    }
}
