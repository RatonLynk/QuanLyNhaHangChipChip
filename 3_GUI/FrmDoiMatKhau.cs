using _2_BUS.BUSServices;
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
        public FrmDoiMatKhau()
        {
            _qlnv = new QLNhanVienService();
            InitializeComponent();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (_qlnv.getlstNhanViens().Any(c=>c.Email==txtEmail.Text && c.Password==txtPass.Text ))
            //{
            //    if (txtNewPass.Text != txtNewPass2.Text)
            //    {
            //        MessageBox.Show("Nhập lại mật khẩu không chính xác", "Thông báo");
            //    }
            //    else
            //    {
            //        var nhanv = _qlnv.getlstNhanViens().Where(c => c.Email == txtEmail.Text)
            //            .FirstOrDefault();
            //        nhanv.Password = txtNewPass.Text;

            //    }
            //}
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }
    }
}
