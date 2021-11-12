using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.BUSServices;

namespace _3_GUI
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private IQLNhanVienService _iQlNhanVienService = new QLNhanVienService();
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
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
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "Chức năng";
            dgvCmb.Items.Add("Thêm");
            dgvCmb.Items.Add("Sửa");
            dgvCmb.Items.Add("Xóa");
            DataGridViewButtonColumn DBtn = new DataGridViewButtonColumn();
            DBtn.HeaderText = "Xác nhận";
            DBtn.Name = "Lưu";
            dgrid_NhanVien.Columns.Add(dgvCmb);
            dgrid_NhanVien.Columns.Add(DBtn);
            dgrid_NhanVien.Rows.Clear();
            foreach (var x in _iQlNhanVienService.getlstNhanViens())
            {
                dgrid_NhanVien.Rows.Add(x.Id, x.Name, x.Email, x.Password, x.Role == 1 ? "Nhân viên" : "Quản lí",
                    x.PhoneNo, x.Address, x.Status == false ? "Hoạt động" : "Không hoạt động", x.MaNv);

            }
        }
    }
}
