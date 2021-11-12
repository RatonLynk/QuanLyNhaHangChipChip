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
using System.Data.SqlClient;



namespace _3_GUI
{
    public partial class FrmQuanLyThucDon : Form
    {
        private iQLMenuService _iQLMenuService;
        private MonAnChiTiet _monCT;
        private DonVi _donVi;
        private DanhMucFood _dmFood;
        private CachCheBien _cachCB;
        private ThucDon _item;
        private Utilities _utilities;
        public FrmQuanLyThucDon()
        {
            //MaximizeBox = false;
            InitializeComponent();
            _iQLMenuService = new QLMenuService();
            FrmQuanLyThucDon_Load();
        }

        private void FrmQuanLyThucDon_Load()
        {
            dgvMonAn.ColumnCount = 7;
            dgvMonAn.Columns[0].Name = "Mã món ăn";
            dgvMonAn.Columns[1].Name = "Tên món";
            dgvMonAn.Columns[2].Name = "Giá";
            dgvMonAn.Columns[3].Name = "Danh mục";
            dgvMonAn.Columns[4].Name = "Cách chế biên";
            dgvMonAn.Columns[5].Name = "Đơn vị tính";
            dgvMonAn.Columns[6].Name = "Trạng thái";
            dgvMonAn.Rows.Clear();
            foreach(var x in _iQLMenuService.GetViewMenus())
            {
                dgvMonAn.Rows.Add(x.details.MaMon,x.details.Name, x.details.Price, x.cat.Name, x.method.Name, x.unit.Name, x.details.Status == 1 ? "Đang bán" : "Dừng bán");
            }
            dgvDanhMuc.ColumnCount = 3;
            dgvDanhMuc.Columns[0].Name = "Mã danh mục";
            dgvDanhMuc.Columns[0].Width = 100;
            dgvDanhMuc.Columns[1].Name = "Tên danh mục";
            dgvDanhMuc.Columns[2].Name = "Trạng thái";
            dgvDanhMuc.Rows.Clear();
            foreach(var x in _iQLMenuService.GetDanhMucFoods())
            {
                dgvDanhMuc.Rows.Add(x.Id, x.Name,x.Status==true?"Hoạt động":"Không hoạt động");
            }
            dgvCachNau.ColumnCount = 3;
            dgvCachNau.Columns[0].Name = "Mã danh mục";
            dgvCachNau.Columns[0].Width = 100;
            dgvCachNau.Columns[1].Name = "Tên danh mục";
            dgvCachNau.Columns[2].Name = "Trạng thái";
            dgvCachNau.Rows.Clear();
            foreach (var x in _iQLMenuService.GetCachCheBiens())
            {
                dgvCachNau.Rows.Add(x.Id, x.Name, x.Status == true ? "Hoạt động" : "Không hoạt động");
            }
            this.dgvCachNau.ClearSelection();
            this.dgvDanhMuc.ClearSelection();
            this.dgvMonAn.ClearSelection();
            LoadCBox();
        }

        private void LoadCBox()
        {
            foreach(var x in _iQLMenuService.GetCachCheBiens())
            {
                if(x.Status == true)
                cbx_Meth.Items.Add(x.Name);
            }
            foreach (var x in _iQLMenuService.GetDanhMucFoods())
            {
                if(x.Status == true)
                cbx_Cat.Items.Add(x.Name);
            }
            foreach (var x in _iQLMenuService.GetDonVis())
            {
                if (x.Status == true)
                    cbx_Unit.Items.Add(x.Name);
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (checknullMonAn())
                {

                    _monCT = new MonAnChiTiet();
                    _item = new ThucDon();
                    _monCT.MaMon = _iQLMenuService.GetMonAnChiTiets().Count;
                    _monCT.Name = txtTenMonAn.Text;
                    _monCT.Idunit = cbx_Unit.SelectedIndex;
                    _monCT.Idcategory = cbx_Cat.SelectedIndex;
                    _monCT.Idmethod = cbx_Cat.SelectedIndex;
                    _monCT.Price = txt_Price.Value;
                    _item.Id = _monCT.MaMon;
                    _item.Name = _monCT.Name;
                    _item.Price = _monCT.Price;
                    if (rbtn_HDthucdon.Checked)
                    {
                        _monCT.Status = 1;
                    }
                    else
                    {
                        _monCT.Status = 0;
                    }
                    _item.Status = _monCT.Status == 1 ? true : false;
                    _iQLMenuService.AddDetail(_monCT);
                    _iQLMenuService.AddItem(_item);
                    FrmQuanLyThucDon_Load();
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin");
                } 
            } else
            {
                return;
            }
            
            
        }
        private bool checknullMonAn()
        {
            if(txtTenMonAn.Text is null || cbx_Unit.Text is null || cbx_Cat.Text is null || cbx_Meth.Text is null || txt_Price.Value < 1000 || (!rbtn_HDthucdon.Checked && !rbtn_KHDthucdon.Checked))
            {
                return false;
            }
            return true;
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_monCT is null)
                {
                    MessageBox.Show("Chọn món muốn sửa");
                }
                else if (!checknullMonAn())
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
                else
                {
                    _monCT.MaMon = _iQLMenuService.GetMonAnChiTiets().Count;
                    _monCT.Name = txtTenMonAn.Text;
                    _monCT.Idunit = _utilities.GetDonViID(cbx_Unit.Text);
                    _monCT.Idcategory = _utilities.GetCategoryID(cbx_Cat.Text);
                    _monCT.Idmethod = _utilities.GetMethodID(cbx_Meth.Text);
                    _monCT.Price = txt_Price.Value;
                    _item.Id = _monCT.MaMon;
                    _item.Name = _monCT.Name;
                    _item.Price = _monCT.Price;
                    _iQLMenuService.UpdateDetail(_monCT);
                    _iQLMenuService.UpdateItem(_item);
                    FrmQuanLyThucDon_Load();
                } 
            }
            else
            {
                return;
            }
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if(index == _iQLMenuService.GetMonAnChiTiets().Count || index == -1)
            {
                txtTenMonAn.Text = null;
                cbx_Unit.Text = null;
                cbx_Cat.Text = null;
                cbx_Meth.Text = null;
                txt_Price.Value = 0;
                rbtn_HDthucdon.Checked = false;
                rbtn_KHDthucdon.Checked = false;
                return;
            }
            else
            {
                int ID = (int)dgvMonAn.Rows[index].Cells[0].Value;
                _monCT = _iQLMenuService.GetMonAnChiTiets().Where(c => c.MaMon == ID).FirstOrDefault();
                _item = _iQLMenuService.GetThucDons().Where(c => c.Id == _monCT.MaMon).FirstOrDefault();
                txtTenMonAn.Text = _monCT.Name;
                cbx_Unit.SelectedIndex = _monCT.Idunit;
                cbx_Cat.SelectedIndex = _monCT.Idcategory;
                cbx_Meth.SelectedIndex = _monCT.Idmethod;
                txt_Price.Value = 0;
                if (_monCT.Status == 1)
                {
                    rbtn_HDthucdon.Checked = true; 
                }
                else
                {
                    rbtn_KHDthucdon.Checked = true;
                }
            }
            

        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                if (_monCT != null)
                {
                    _iQLMenuService.DeleteItem(_item);
                    _iQLMenuService.DeleteDetail(_monCT); 
                }
                else
                {
                    MessageBox.Show("Chọn món để xóa");
                }
            }
        }

        private void txt_TimKiemThucDon_TextChanged(object sender, EventArgs e)
        {
            dgvMonAn.ColumnCount = 7;
            dgvMonAn.Columns[0].Name = "Mã món ăn";
            dgvMonAn.Columns[1].Name = "Tên món";
            dgvMonAn.Columns[2].Name = "Giá";
            dgvMonAn.Columns[3].Name = "Danh mục";
            dgvMonAn.Columns[4].Name = "Cách chế biên";
            dgvMonAn.Columns[5].Name = "Đơn vị tính";
            dgvMonAn.Columns[6].Name = "Trạng thái";
            dgvMonAn.Rows.Clear();
            foreach (var x in _iQLMenuService.TimKiem(txt_TimKiemThucDon.Text))
            {
                dgvMonAn.Rows.Add(x.details.MaMon, x.details.Name, x.details.Price, x.cat.Name, x.method.Name, x.unit.Name, x.details.Status == 1 ? "Đang bán" : "Dừng bán");
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thêm?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (checkNullCat())
                {
                    _dmFood = new DanhMucFood();
                    _dmFood.Id = _iQLMenuService.GetDanhMucFoods().Count;
                    _dmFood.Name = txtTenDanhMuc.Text;
                    if (rbtn_HDdanhmuc.Checked)
                    {
                        _dmFood.Status = true;
                    }
                    else
                    {
                        _dmFood.Status = false;
                    }
                    _iQLMenuService.AddCategory(_dmFood);
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
        private bool checkNullCat()
        {
            if(txtTenDanhMuc.Text is null || (!rbtn_HDdanhmuc.Checked && !rbtn_KHDdanhmuc.Checked))
            {
                return false;
            }
            return true;
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if(index == _iQLMenuService.GetDanhMucFoods().Count || index == -1)
            {
                txtMaDanhMuc.Text = null;
                txtTenDanhMuc.Text = null;
                rbtn_KHDdanhmuc.Checked = false;
                rbtn_HDdanhmuc.Checked = false;
            }
            else
            {
                int ID = (int)dgvDanhMuc.Rows[index].Cells[0].Value;
                _dmFood = _iQLMenuService.GetDanhMucFoods().Where(c => c.Id == ID).FirstOrDefault();
                txtMaDanhMuc.Text = _dmFood.Id.ToString();
                txtTenDanhMuc.Text = _dmFood.Name;
                if (_dmFood.Status == true)
                {
                    rbtn_HDdanhmuc.Checked = true;
                }
                else
                {
                    rbtn_KHDdanhmuc.Checked = true;
                }
            }
        }

        private void btnSuaNhom_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_monCT is null)
                {
                    MessageBox.Show("Chọn danh mục muốn sửa");
                }
                else if (!checkNullCat())
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
                else
                {
                    _dmFood.Name = txtTenDanhMuc.Text;
                    if (rbtn_KHDdanhmuc.Checked)
                    {
                        _dmFood.Status = false;
                    }
                    else
                    {
                        _dmFood.Status = true;
                    }
                    _iQLMenuService.UpdateCategory(_dmFood);
                    FrmQuanLyThucDon_Load();
                }
            }
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_dmFood != null)
                {
                    _iQLMenuService.DeleteCategory(_dmFood); 
                } else
                {
                    MessageBox.Show("Chọn danh mục để xóa");
                }
            }
        }

        private void txtTimkiemDM_TextChanged(object sender, EventArgs e)
        {
            dgvDanhMuc.ColumnCount = 3;
            dgvDanhMuc.Columns[0].Name = "Mã danh mục";
            dgvDanhMuc.Columns[0].Width = 100;
            dgvDanhMuc.Columns[1].Name = "Tên danh mục";
            dgvDanhMuc.Columns[2].Name = "Trạng thái";
            foreach (var x in _iQLMenuService.TimKiem(txtTimkiemDM.Text))
            {
                dgvDanhMuc.Rows.Add(x.cat.Id, x.cat.Name, x.cat.Status == true ? "Hoạt động" : "Không hoạt động");
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
                int ID = (int)dgvDanhMuc.Rows[index].Cells[0].Value;
                _cachCB = _iQLMenuService.GetCachCheBiens().Where(c => c.Id == ID).FirstOrDefault();
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
        private bool checkNullMeth()
        {
            if (txt_MethName.Text is null || (!rbtn_HDCachchebien.Checked && !rbtn_KHDCachchebien.Checked))
            {
                return false;
            }
            return true;
        }

        private void txtTimKiemCongthucCB_TextChanged(object sender, EventArgs e)
        {
            dgvCachNau.ColumnCount = 3;
            dgvCachNau.Columns[0].Name = "Mã danh mục";
            dgvCachNau.Columns[0].Width = 100;
            dgvCachNau.Columns[1].Name = "Tên danh mục";
            dgvCachNau.Columns[2].Name = "Trạng thái";
            foreach (var x in _iQLMenuService.TimKiem(txtTimKiemCongthucCB.Text))
            {
                dgvCachNau.Rows.Add(x.method.Id, x.method.Name, x.method.Status == true ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void btnThemCongThuc_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thêm?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (checkNullMeth())
                {
                    _cachCB = new CachCheBien();
                    _cachCB.Id = _iQLMenuService.GetCachCheBiens().Count;
                    _cachCB.Name = txt_MethName.Text;
                    if (rbtn_HDCachchebien.Checked)
                    {
                        _cachCB.Status = true;
                    }
                    else
                    {
                        _cachCB.Status = false;
                    }
                    _iQLMenuService.AddMethod(_cachCB);
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

        private void button1_Click(object sender, EventArgs e)
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
                    if (rbtn_KHDdanhmuc.Checked)
                    {
                        _cachCB.Status = false;
                    }
                    else
                    {
                        _cachCB.Status = true;
                    }
                    _iQLMenuService.UpdateMethod(_cachCB);
                    FrmQuanLyThucDon_Load();
                }
            }
        }

        private void btnXoaCongThuc_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_cachCB != null)
                {
                    _iQLMenuService.DeleteMethod(_cachCB);
                }
                else
                {
                    MessageBox.Show("Chọn cách chế biến để xóa");
                }
            }
        }
    }

}
