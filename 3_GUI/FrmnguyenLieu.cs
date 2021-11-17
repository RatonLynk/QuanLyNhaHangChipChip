using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Models;
using _2_BUS.iBUSServices;
using _2_BUS.BUSServices;
using _2_BUS.Utilities;

namespace _3_GUI
{
    public partial class FrmNguyenLieu : Form
    {
        private iQLMenuService _iQLMenuService;
        private MonAnChiTiet _monCT;
        private DonVi _donVi;
        private DanhMucFood _dmFood;
        private NguyenLieu _cachCB;
        private ThucDon _item;
        private Utilities _utilities;
        FrmQuanLyThucDon frm = new FrmQuanLyThucDon();
        public FrmNguyenLieu()
        {
            InitializeComponent();
            _iQLMenuService = new QLMenuService();
            FrmQuanLyThucDon_Load();
        }
        private void FrmQuanLyThucDon_Load()
        {


            dgvCachNau.ColumnCount = 3;
            dgvCachNau.Columns[0].Name = "Mã danh mục";
            dgvCachNau.Columns[0].Width = 100;
            dgvCachNau.Columns[1].Name = "Tên danh mục";
            dgvCachNau.Columns[2].Name = "Trạng thái";
            dgvCachNau.Rows.Clear();
            foreach (var x in _iQLMenuService.GetNguyenLieus())
            {
                dgvCachNau.Rows.Add(x.Id, x.Name, x.Status == true ? "Hoạt động" : "Không hoạt động");
            }
            this.dgvCachNau.ClearSelection();
            frm.FrmQuanLyThucDon_Load();
            frm.LoadCBox();

        }
        private bool checkNullMeth()
        {
            if (txt_MethName.Text is null || (!rbtn_HDCachchebien.Checked && !rbtn_KHDCachchebien.Checked))
            {
                return false;
            }
            return true;
        }

        

        private void btnThemCongThuc_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thêm?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (checkNullMeth())
                {
                    _cachCB = new NguyenLieu();
                    _cachCB.Id = _iQLMenuService.GetNguyenLieus().Count;
                    _cachCB.Name = txt_MethName.Text;
                    if (rbtn_HDCachchebien.Checked)
                    {
                        _cachCB.Status = true;
                    }
                    else
                    {
                        _cachCB.Status = false;
                    }
                    _iQLMenuService.AddIngre(_cachCB);
                    FrmQuanLyThucDon_Load();
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
            }
            else
            {
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_cachCB is null)
                {
                    MessageBox.Show("Chọn cách nấu muốn sửa");
                }
                else if (!checkNullMeth())
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
                else
                {
                    _cachCB.Name = txt_MethName.Text;
                    if (rbtn_KHDCachchebien.Checked)
                    {
                        _cachCB.Status = false;
                    }
                    else
                    {
                        _cachCB.Status = true;
                    }
                    _iQLMenuService.UpdateIngre(_cachCB);
                    FrmQuanLyThucDon_Load();
                }
            }
        }

        private void btnXoaCongThuc_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_cachCB != null)
                {
                    _iQLMenuService.DeleteIngre(_cachCB);
                    FrmQuanLyThucDon_Load();
                }
                else
                {
                    MessageBox.Show("Chọn cách chế biến để xóa");
                }
            }
        }

        private void txtTimKiemCongthucCB_TextChanged_1(object sender, EventArgs e)
        {
            dgvCachNau.ColumnCount = 3;
            dgvCachNau.Columns[0].Name = "Mã danh mục";
            dgvCachNau.Columns[0].Width = 100;
            dgvCachNau.Columns[1].Name = "Tên danh mục";
            dgvCachNau.Columns[2].Name = "Trạng thái";
            foreach (var x in _iQLMenuService.TimKiem(txtTimKiemCongthucCB.Text))
            {
                dgvCachNau.Rows.Add(x.ingre.Id, x.ingre.Name, x.ingre.Status == true ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void dgvCachNau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index == _iQLMenuService.GetDanhMucFoods().Count || index == -1)
            {
                txt_MethID.Text = null;
                txt_MethName.Text = null;
                rbtn_HDCachchebien.Checked = false;
                rbtn_KHDCachchebien.Checked = false;
            }
            else
            {
                int ID = (int)dgvCachNau.Rows[index].Cells[0].Value;
                _cachCB = _iQLMenuService.GetNguyenLieus().Where(c => c.Id == ID).FirstOrDefault();
                txt_MethID.Text = _cachCB.Id.ToString();
                txt_MethName.Text = _cachCB.Name;
                if (_cachCB.Status == true)
                {
                    rbtn_HDCachchebien.Checked = true;
                }
                else
                {
                    rbtn_KHDCachchebien.Checked = true;
                }
            }
        }
    }
}
