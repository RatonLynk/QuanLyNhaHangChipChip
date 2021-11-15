using _1_DAL.Models;
using _2_BUS.BUSServices;
using _2_BUS.iBUSServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class FrmDoiMatKhau : Form
    {
        private IQLNhanVienService _qlnv;
        private IQuenMatKhau QMK = new QuenMatKhau();
        private NhanVien _nv;
        public static string passcu;
        public FrmDoiMatKhau()
        {
            _qlnv = new QLNhanVienService();
            InitializeComponent();
            _nv = new NhanVien();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {       
                if (txtPass.Text != FrmDoiMatKhau.passcu) 
                {
                    MessageBox.Show("Mật khẩu cũ của bạn nhập không chính xác", "Thông báo");
                }else if (txtNewPass.Text != txtNewPass2.Text)
                {
                MessageBox.Show("Nhập lại mật khẩu không chính xác", "Thông báo");
                }
                else
                {

                _nv = _qlnv.getlstNhanViens().Where(c => c.Email == FrmHome.mail).FirstOrDefault();
                _nv = QMK.nhanViens(FrmHome.mail);
                _nv.Password = txtNewPass.Text;         
                MessageBox.Show(QMK.UpdatePass(_nv), "Thông báo", MessageBoxButtons.OK);
                this.Close();
          
                }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
