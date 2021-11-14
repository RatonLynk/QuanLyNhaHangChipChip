using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _2_BUS.BUSServices;

namespace _3_GUI
{
    

    public partial class FrmLogin : Form
    {
        private IQLNhanVienService _qlnv;

        string userName = "";
        string passWord = "";
        public FrmLogin()
        {
            _qlnv = new QLNhanVienService();
            InitializeComponent();
        }

        
      
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "User Name";
            txtUsername.ForeColor = Color.Gray;

            txtPassWord.PasswordChar = '\0';
            txtPassWord.Text = "Password";
            txtPassWord.ForeColor = Color.Gray;

            bool capsLock = Console.CapsLock;
            if (capsLock == true)
                lblCapsLock.Text = "Bạn đang bật Capslock";
            else
                lblCapsLock.Text = "";

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            userName = txtUsername.Text;
            if (userName.Equals("User Name"))
            {
                txtUsername.Text = "User Name";
                txtUsername.ForeColor = Color.Gray;
            }
            else
            {
                if (userName.Equals(""))
                {
                    txtUsername.Text = "User Name";
                    txtUsername.ForeColor = Color.Gray;
                }
                else
                {
                    txtUsername.Text = userName;
                    txtUsername.ForeColor = Color.Black;
                }
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.PasswordChar = '*';

        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            passWord = txtPassWord.Text;
            if (passWord.Equals("Password"))
            {
                txtPassWord.Text = "Password";
                txtPassWord.ForeColor = Color.Gray;
            }
            else
            {
                if (passWord.Equals(""))
                {
                    txtPassWord.PasswordChar = '\0';
                    txtPassWord.Text = "Password";
                    txtPassWord.ForeColor = Color.Gray;
                }
                else
                {
                    txtPassWord.PasswordChar = '*';
                    txtPassWord.Text = passWord;
                    txtPassWord.ForeColor = Color.Black;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.txtUsername.Focus();
                this.txtUsername.Select(0, this.txtUsername.Text.Length);
            }
            if(e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lblCapsLock.Text = "Bạn đang bật Capslock";
                else
                    lblCapsLock.Text = "";
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.txtPassWord.Focus();
                this.txtPassWord.Select(0, this.txtPassWord.Text.Length);
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lblCapsLock.Text = "Bạn đang bật Capslock";
                else
                    lblCapsLock.Text = "";
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lblCapsLock.Text = "Bạn đang bật Capslock";
                else
                    lblCapsLock.Text = "";
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (_qlnv.getlstNhanViens().Any(c =>  c.Status == true))
            {
                MessageBox.Show("Tài khoản hiện ngưng hoạt động, vui lòng đăng nhập bằng tài khoản khác ", "thông báo");

            }
            else if (_qlnv.getlstNhanViens().Any(c => c.Email != txtUsername.Text ))
            {
                MessageBox.Show("tài khoản đăng nhập không chính xác ", "thông báo");

            }
            else if (_qlnv.getlstNhanViens().Any(c =>  c.Password != txtPassWord.Text))
            {
                MessageBox.Show("Mật khẩu không chính xác ", "thông báo");

            }
            else if (_qlnv.getlstNhanViens().Any(c=>c.Email==txtUsername.Text&& c.Password==txtPassWord.Text && c.Status==false))
            {
                var nv1 = _qlnv.getlstNhanViens().FirstOrDefault(c => c.Email == txtUsername.Text && c.Password == txtPassWord.Text && c.Status == false);

                MessageBox.Show("Đăng nhập thành công ", "thông báo");
                this.Hide();
                FrmHome home = new FrmHome();
                home.manv(Convert.ToString(nv1.MaNv));//truy xuất được mã nv khi đăng nhập
                home.Show();
                
            }
        }

        private void linkQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Frm_QuenMatKhau qmk = new Frm_QuenMatKhau();
            qmk.Show();
           
        }
        //sdfg
    }

}
