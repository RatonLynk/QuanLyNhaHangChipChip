using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Context;
using _1_DAL.Models;
using _2_BUS.BUSServices;
using _2_BUS.Utilities;

namespace _3_GUI
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private IQLNhanVienService _iQlNhanVienService = new QLNhanVienService();
        private DatabaseContext _dbconContext;
        private Utilities _utilities;
        private int _id;
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            loadData();
            _utilities = new Utilities();
            dgrid_NhanVien.Columns["MANV"].Visible = false;
            rbtnHDnhanvien.Checked = true;
            chk_nhanVien.Checked = true;
            chk_nam.Checked = true;

        }
        void loadData()
        {
            _iQlNhanVienService.getlstNhanViens();
            dgrid_NhanVien.ColumnCount = 10;
            dgrid_NhanVien.Columns[0].Name = "Id";
            dgrid_NhanVien.Columns[1].Name = "Tên nhân viên";
            dgrid_NhanVien.Columns[2].Name = "Email";
            dgrid_NhanVien.Columns[3].Name = "Mật khẩu";
            dgrid_NhanVien.Columns[4].Name = "Vai trò";
            dgrid_NhanVien.Columns[5].Name = "Số điện thoại";
            dgrid_NhanVien.Columns[6].Name = "Giới tính";
            dgrid_NhanVien.Columns[7].Name = "Địa chỉ";
            dgrid_NhanVien.Columns[8].Name = "Trạng thái";
            dgrid_NhanVien.Columns[9].Name = "MANV";
            dgrid_NhanVien.Rows.Clear();
            foreach (var x in _iQlNhanVienService.getlstNhanViens())
            {
                dgrid_NhanVien.Rows.Add(x.Id, x.Name, x.Email, x.Password, x.Role == 1 ? "Nhân viên" : "Quản lí",
                    x.PhoneNo, x.Sex == true ? "Nam" : "Nữ", x.Address, x.Status == true ? "Hoạt động" : "Không hoạt động", x.MaNv);
            }
        }
        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _id = Convert.ToInt32(dgrid_NhanVien.Rows[rowindex].Cells[0].Value.ToString());
            txt_TenNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[1].Value.ToString();
            txtEmail.Text = dgrid_NhanVien.Rows[rowindex].Cells[2].Value.ToString();
            txtMatKhau.Text = _utilities.GetHash(dgrid_NhanVien.Rows[rowindex].Cells[3].Value.ToString());
            chk_nhanVien.Checked = dgrid_NhanVien.Rows[rowindex].Cells[4].Value.ToString() == "Nhân viên" ? true : false;
            chk_quanLi.Checked = dgrid_NhanVien.Rows[rowindex].Cells[4].Value.ToString() == "Quản lí" ? true : false;
            txt_SDT.Text = dgrid_NhanVien.Rows[rowindex].Cells[5].Value.ToString();
            chk_nam.Checked = dgrid_NhanVien.Rows[rowindex].Cells[6].Value.ToString() == "Nam" ? true : false;
            chk_nu.Checked = dgrid_NhanVien.Rows[rowindex].Cells[6].Value.ToString() == "Nữ" ? true : false;
            txt_DiaChiNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[7].Value.ToString();
            rbtnHDnhanvien.Checked = dgrid_NhanVien.Rows[rowindex].Cells[8].Value.ToString() == "Hoạt động" ? true : false;
            rbtnKHDnhanvien.Checked = dgrid_NhanVien.Rows[rowindex].Cells[8].Value.ToString() == "Không Hoạt động" ? true : false;
            txtMaNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[9].Value.ToString();
            var nv = _iQlNhanVienService.getlstNhanViens().Where(c => c.MaNv == txtMaNV.Text).FirstOrDefault();

            if (nv.Status == true)
            {
                rbtnHDnhanvien.Checked = true;
            }
            else
            {
                rbtnKHDnhanvien.Checked = true;
            }
            if (nv.Role == 1)
            {
                chk_nhanVien.Checked = true;
            }
            else
            {
                chk_quanLi.Checked = true;
            }


        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

            NhanVien NhanVien = new NhanVien();
            NhanVien.Id = dgrid_NhanVien.Rows.Cast<DataGridViewRow>()
                .Max(r => Convert.ToInt32(r.Cells["Id"].Value)) + 1;
            NhanVien.MaNv = "NV" + NhanVien.Id;
            NhanVien.Name = txt_TenNV.Text;
            NhanVien.Email = txtEmail.Text;
            NhanVien.Address = txt_DiaChiNV.Text;
            NhanVien.PhoneNo = txt_SDT.Text;
            NhanVien.Sex = Convert.ToBoolean(chk_nam.Checked ? true : false);
            NhanVien.Status = Convert.ToBoolean(rbtnHDnhanvien.Checked ? true : false);
            NhanVien.Password = _utilities.GetHash("123");
            NhanVien.Role = chk_quanLi.Checked ? 0 : 1;
            if ((MessageBox.Show("Bạn muốn thêm một nhân viên ?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlNhanVienService.Add(NhanVien);
                MessageBox.Show("Thêm thành công", "Thông báo");
                loadData();
            }
        }



        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            var nhanVien = _iQlNhanVienService.getlstNhanViens().FirstOrDefault(x => x.Id == _id);
            rbtnKHDnhanvien.Checked = true;
            //nhanVien.Role = 1;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlNhanVienService.Delete(nhanVien);
                _iQlNhanVienService.Save();
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadData();
            }
        }
       
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            var nhanVien = _iQlNhanVienService.getlstNhanViens().Where(c => c.MaNv == txtMaNV.Text).FirstOrDefault();
            nhanVien.Name = txt_TenNV.Text;
            nhanVien.Email = txtEmail.Text;
            nhanVien.Password = _utilities.GetHash(txtMatKhau.Text);
            nhanVien.Role = chk_quanLi.Checked ? 0 : 1;
            nhanVien.Address = txt_DiaChiNV.Text;
            nhanVien.PhoneNo = txt_SDT.Text;
            nhanVien.Sex = chk_nam.Checked ? true : false;
            nhanVien.Status = (bool)(rbtnHDnhanvien.Checked ? true : false);
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlNhanVienService.Update(nhanVien);
            }
            MessageBox.Show("Sửa thành công", "Thông báo");
            loadData();

        }

        private void chk_quanLi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chk_nhanVien.Checked)
            {
                chk_nhanVien.Checked = false;
            }
        }



        private void chk_nhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_quanLi.Checked)
            {
                chk_quanLi.Checked = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            _iQlNhanVienService.Save();
        }

        private void txt_TenNV_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_TenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên của bạn.");
                return;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email của bạn.");
                return;
            }
        }
        //clear form các thứ
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_TenNV.ResetText();
            txtEmail.ResetText();
            txt_SDT.ResetText();
            txt_DiaChiNV.ResetText();
            txtMatKhau.ResetText();
        }
    }
}
