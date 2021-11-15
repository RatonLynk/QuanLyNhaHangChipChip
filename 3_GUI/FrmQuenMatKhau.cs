using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using _2_BUS.iBUSServices;
using _2_BUS.BUSServices;
using _1_DAL.Models;

namespace _3_GUI
{
    public partial class FrmQuenMatKhau : Form
    {
        private IQuenMatKhau QMK = new QuenMatKhau();
        private IQLNhanVienService nv = new QLNhanVienService();
        int _TimeNow, _Time;
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        NhanVien _NhanVien;
        private string mess = "Thông báo";
        private string _pass;
        private string _code;

        private int flag;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            Txt_XacNhan.Enabled = false;
            btn_XacNhan.Enabled = false;
        }
        //Hàm có nhiệm vụ lấy tham số truyền vào

        private void GetMessage(string Message)
        {
            txt_Email.Text = Message;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            _TimeNow = DateTime.Now.Minute;

            if (_TimeNow - _Time > 1)
            {
                MessageBox.Show("Đã quá thời gian 1 phút .\n Mã code đã vô hiệu hóa");

            }
            else if (flag == 3)
            {
                MessageBox.Show("Đã quá 3 lần xác nhân .\n Mã code đã vô hiệu hóa");

            }
            else if (Txt_XacNhan.Text == _code)
            {
                _NhanVien = new NhanVien();
                _NhanVien = nv.getlstNhanViens().FirstOrDefault(c => c.Email == txt_Email.Text);
                _NhanVien.Password = _pass;
                nv.Update(_NhanVien);
                nv.Save();
                this.Close();
                FrmLogin frm_DangNhap = new FrmLogin();
                frm_DangNhap.ShowDialog();
            }
            else
            {
                flag += 1;
                MessageBox.Show("Mã code không hợp lệ", mess);
            }
        }

        private void btn_SendtoEmail_Click(object sender, EventArgs e)
        {
            vadidatefrom();
            if (btn_SendtoEmail.Text == "Gửi")
            {
                flag = 0;
                txt_Email.Enabled = false;
                if (nv.getlstNhanViens().Any(c => c.Email == txt_Email.Text) == false)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống", mess);
                    txt_Email.Enabled = true;
                    return;
                }
                else
                {
                    var sendPassCode = QMK.SenderMail(txt_Email.Text);
                    if (sendPassCode == null)
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                    else
                    {
                        _pass = sendPassCode.pass;
                        _code = sendPassCode.code;

                    
                        MessageBox.Show("Mã Code đã được giử vào email", mess);
                        _Time = DateTime.Now.Minute;
                        Txt_XacNhan.Enabled = true;
                        btn_XacNhan.Enabled = true;
                        btn_SendtoEmail.Enabled = false;
                    }
                }
            }

            else if (btn_SendtoEmail.Text == "Xác nhận")
            {
                _TimeNow = DateTime.Now.Minute;

                if (_TimeNow - _Time > 1)
                {
                    MessageBox.Show("Đã quá thời gian 1 phút .\n Mã code đã vô hiệu hóa");

                }
                else if (flag == 3)
                {
                    MessageBox.Show("Đã quá 3 lần xác nhân .\n Mã code đã vô hiệu hóa");

                }
                else if (Txt_XacNhan.Text == _code)
                {
                    _NhanVien = new NhanVien();
                    _NhanVien = QMK.nhanViens(txt_Email.Text);
                    _NhanVien.Password = _pass;
                    _NhanVien.Status = false;
                    MessageBox.Show(QMK.UpdatePass(_NhanVien), mess);
                    this.Close();
                 
                }
                else
                {
                    flag += 1;
                    MessageBox.Show("Mã code không hợp lệ", mess);
                }
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        bool vadidatefrom()
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Không được để trống email ");
                return false;
            }
          
            return true;
        }

       

      







    }
}
