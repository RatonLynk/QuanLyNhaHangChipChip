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
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            loadData();
            _utilities = new Utilities();
            dgrid_NhanVien.Columns["MANV"].Visible = false;
            rbtnHDnhanvien.Checked = true;
            chk_nhanVien.Checked = true;

        }
        void loadData()
        {
            _iQlNhanVienService.getlstNhanViens();
            dgrid_NhanVien.ColumnCount = 9;
            dgrid_NhanVien.Columns[0].Name = "Id";
            dgrid_NhanVien.Columns[1].Name = "Tên nhân viên";
            dgrid_NhanVien.Columns[2].Name = "Email";
            dgrid_NhanVien.Columns[3].Name = "Mật khẩu";
            dgrid_NhanVien.Columns[4].Name = "Vai trò";
            dgrid_NhanVien.Columns[5].Name = "Số điện thoại";
            dgrid_NhanVien.Columns[6].Name = "Địa chỉ";
            dgrid_NhanVien.Columns[7].Name = "Trạng thái";
            dgrid_NhanVien.Columns[8].Name = "MANV";
            //DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            //dgvCmb.HeaderText = "Chức năng";
            //dgvCmb.Items.Add("Thêm");
            //dgvCmb.Items.Add("Sửa");
            //dgvCmb.Items.Add("Xóa");
            //DataGridViewButtonColumn DBtn = new DataGridViewButtonColumn();
            //DBtn.HeaderText = "Xác nhận";
            //DBtn.Name = "Lưu";
            //dgrid_NhanVien.Columns.Add(dgvCmb);
            //dgrid_NhanVien.Columns.Add(DBtn);
            dgrid_NhanVien.Rows.Clear();
            foreach (var x in _iQlNhanVienService.getlstNhanViens())
            {
                dgrid_NhanVien.Rows.Add(x.Id, x.Name, x.Email, x.Password, x.Role == 0 ? "Nhân viên" : "Quản lí",
                    x.PhoneNo, x.Address, x.Status == true ? "Hoạt động" : "Không hoạt động", x.MaNv);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVien NhanVien = new NhanVien();
            NhanVien.Id = dgrid_NhanVien.Rows.Cast<DataGridViewRow>()
                .Max(r => Convert.ToInt32(r.Cells["Id"].Value)) + 1;
            NhanVien.MaNv = 1 + NhanVien.Id;
            NhanVien.Name =  txt_TenNV.Text;
            NhanVien.Email = txtEmail.Text;
            NhanVien.Role = (byte)(chk_quanLi.Checked ? 1 : 0);
            NhanVien.Address = txt_DiaChiNV.Text;
            NhanVien.PhoneNo = txt_SDT.Text;
            NhanVien.Status = Convert.ToBoolean(rbtnHDnhanvien.Checked ? true : false);
            NhanVien.Password = _utilities.GetHash("123");
            NhanVien.Role = chk_quanLi.Checked?1:0;
            if ((MessageBox.Show("Bạn muốn thêm một nhân viên ?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlNhanVienService.Add(NhanVien);
                loadData();
            }
        }

        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtMaNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[8].Value.ToString();
            txt_TenNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[1].Value.ToString();
            txtEmail.Text = dgrid_NhanVien.Rows[rowindex].Cells[2].Value.ToString();
            txtMatKhau.Text = dgrid_NhanVien.Rows[rowindex].Cells[3].Value.ToString();
            txt_SDT.Text = dgrid_NhanVien.Rows[rowindex].Cells[5].Value.ToString();
            txt_DiaChiNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[6].Value.ToString();
            var nv = _iQlNhanVienService.getlstNhanViens().Where(c => c.MaNv == Convert.ToInt32(txtMaNV.Text) ).FirstOrDefault();
            if (nv.Role == 1)
            {
                chk_quanLi.Checked = true;
            }
            else
            {
                chk_nhanVien.Checked = true;
            }

            if (nv.Status == true)
            {
                rbtnHDnhanvien.Checked = true;
            }
            else
            {
                rbtnKHDnhanvien.Checked = true;
            }
        }



        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            var nhanVien = _iQlNhanVienService.getlstNhanViens().Where(c => c.MaNv == Convert.ToByte(txtMaNV) ).FirstOrDefault();
            rbtnKHDnhanvien.Checked = true;
            nhanVien.Role = 0;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlNhanVienService.Delete(nhanVien);
                loadData();
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            var nhanVien = _iQlNhanVienService.getlstNhanViens().Where(c => c.MaNv == Convert.ToByte(txtMaNV.Text)).FirstOrDefault();
            nhanVien.Name = txt_TenNV.Text;
            nhanVien.Email = txtEmail.Text;
            nhanVien.Password = _utilities.GetHash(txtMatKhau.Text);
            nhanVien.Role = (byte)(chk_nhanVien.Checked ? 1 : 0);
            nhanVien.Address = txt_DiaChiNV.Text;
            nhanVien.PhoneNo = txt_SDT.Text;
            nhanVien.PhoneNo = txt_SDT.Text;
            nhanVien.Status = (bool)(rbtnHDnhanvien.Checked ? false : true);
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlNhanVienService.Update(nhanVien);
                loadData();
            }
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
    }
}
