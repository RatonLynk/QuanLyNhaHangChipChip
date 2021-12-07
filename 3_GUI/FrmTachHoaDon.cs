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
using _2_BUS.iBUSServices;
using _1_DAL.Models;
using _2_BUS.Models;
using System.Drawing;
using _3_GUI.Properties;

namespace _3_GUI
{
    public partial class FrmTachHoaDon : Form
    {
        public static int _IdBanTachHD;
        public static int _IdHoaDon;
        public static string _EmailTachHD;
        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        IQLNhanVienService _qlNhanVien;
        int _idHD;
        int _idHDCT;
        iQLMenuService _qlMeniu;
        Form _f;
        int _soLuong;
        HoaDon _hoaDon;
        HoaDonChiTiet _HDCT;
        public FrmTachHoaDon()
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _qlHoaDon = new QLHoaDon();
            _qlNhanVien = new QLNhanVienService();
            _qlMeniu = new QLMenuService();
            LoadHDCu(_IdBanTachHD);
            Lbl_Tien.Visible = false;
        }
        void LoadHDCu(int id)
        {
            var abc = (from a in _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == id && c.Status == true && c.DichVu == 1 && c.Id!=_idHD)
                       join c in _qlHoaDon.GetHoaDonCTFromDB()
                       on a.Id equals c.Idbill
                       select new
                       {
                           IDHD = a.Id,
                           IdBan = a.Idtable,
                           TrangThai = a.Status,
                           DichVu = a.DichVu,
                           IDHDCT = c.Id,
                           IDFood = c.Idfood,
                           SoLuong = c.Count,

                       }).ToList();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "xoa";
            Bitmap b = new Bitmap(@"C:\Users\XAPE\Desktop\TestGit-master\RestaurantApp\Resources\001-close.png");
            img.Image = b;

            Dgrid_HDCu.ColumnCount = 5;
            Dgrid_HDCu.Columns[0].Name = "Tên món";
            Dgrid_HDCu.Columns[1].Name = "Số lượng";
            Dgrid_HDCu.Columns[2].Name = "Đơn giá";
            Dgrid_HDCu.Columns[3].Name = "thành tiền";
            Dgrid_HDCu.Columns[4].Name = "Id";
            Dgrid_HDCu.Columns[4].Visible = false;
            Dgrid_HDCu.Columns.Add(img);
            Dgrid_HDCu.Rows.Clear();
            foreach (var x in abc)
            {
                Dgrid_HDCu.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Name).FirstOrDefault(), x.SoLuong,
                    _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault(),
                    _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault() * x.SoLuong, x.IDHDCT);
            }
        }
        

        private void Btn_TaoHD_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            NhanVien nhanVien = _qlNhanVien.getlstNhanViens().FirstOrDefault(c => c.Email == _EmailTachHD);
            hoaDon.DateCheckIn = DateTime.Now;
            hoaDon.DateCheckOut = DateTime.Now;
            hoaDon.Id = (_qlHoaDon.GetBillsFromDB().Count()) + 1;
            hoaDon.Idtable = 1;
            //hoaDon.IdnhanVien = nhanVien.Id;
            hoaDon.IdnhanVien = 1;
            hoaDon.SoDT = null;
            hoaDon.Status = true;
            hoaDon.DiaChi = null;
            hoaDon.DichVu = 1;
            hoaDon.GhiChu = null;
            hoaDon.TotalMoney = 0;
            _qlHoaDon.AddHoaDon(hoaDon);
            _idHD = hoaDon.Id;
            MessageBox.Show("Tạo thành công","Thông báo");
            LoadHDMoi();

        }

        private void Dgrid_HDCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlHoaDon.GetHoaDonCTFromDB().Count) || rowIndex == -1) return;
            _idHDCT =Convert.ToInt32(Dgrid_HDCu.Rows[rowIndex].Cells[4].Value.ToString());
            if (e.ColumnIndex == Dgrid_HDCu.Columns["xoa"].Index)
            {
                _f = new Form();
                TextBox textBox = new TextBox();
                textBox.Width = 150;
                Button button = new Button();
                Label label = new Label();
                label.Text = "Số Lượng:";
                button.Text = "Xác Nhận";
                _f.Controls.Add(textBox);
                _f.Controls.Add(button);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 100;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;
                _f.Size = new Size(300, 120);
                //f.StartPosition=CenterToScreen();
                button.Click += Button_Click; ;
                _f.ShowDialog();

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            if (_idHD==0)
            {
                MessageBox.Show("Bạn chưa tạo hóa đơn mới");
                _f.Close();
                return;
            }
            else if (_idHD!=0)
            {
                HoaDon hoaDon1 = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
                if (hoaDon1.Status==false)
                {
                    MessageBox.Show("Bạn chưa tạo hóa đơn mới");
                    _f.Close();
                    return;
                }
            }
          
            HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
            _HDCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
            HoaDonChiTiet hoaDonChiTiet2 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c=>c.Idbill==_idHD && c.Idfood==_HDCT.Idfood);
            if (String.IsNullOrEmpty(_f.Controls[0].Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng","Thông báo");
                return;
            }
            if (_f.Controls[0].Text.All(char.IsDigit)==false)
            {
                MessageBox.Show("Số lượng không được nhập chữ","Thông báo");
                return;
            }
            _soLuong = Convert.ToInt32(_f.Controls[0].Text);
            if (_soLuong>_HDCT.Count)
            {
                MessageBox.Show("Số lượng lớn hơn rồi","Thông báo");
                return;
            }
            if (hoaDonChiTiet2==null)
            {
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                hoaDonChiTiet.Id = (_qlHoaDon.GetHoaDonCTFromDB().Count()) + 1;
                hoaDonChiTiet.Idbill = _idHD;
                hoaDonChiTiet.Idfood = _HDCT.Idfood;
                hoaDonChiTiet.Count = _soLuong;
                hoaDonChiTiet.Price = _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                hoaDonChiTiet.Status = true;
                _qlHoaDon.AddHoaDonCT(hoaDonChiTiet);
                hoaDon.TotalMoney += hoaDonChiTiet.Price;
                _qlHoaDon.UpdateHoaDon(hoaDon);
                _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanTachHD && c.Status == true && c.DichVu == 1 && c.Id!=_idHD).FirstOrDefault();
                int giatru;
                HoaDonChiTiet hoaDonChiTiet1 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
                if (hoaDonChiTiet1.Count == 0)
                {
                    _hoaDon.TotalMoney -= hoaDonChiTiet1.Price;
                    _qlHoaDon.DeleteHoaDonCT(hoaDonChiTiet1);
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                    return;
                }
                else if (hoaDonChiTiet1.Count!=0)
                {
                    hoaDonChiTiet1.Count -= _soLuong;
                    hoaDonChiTiet1.Price -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                    giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault()));
                    _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet1);
                    _hoaDon.TotalMoney -= giatru;
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                }
                
            }
            else if (hoaDonChiTiet2!=null)
            {
                hoaDonChiTiet2.Count += _soLuong;
                hoaDonChiTiet2.Price += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet2);                
                hoaDon.TotalMoney += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                _qlHoaDon.UpdateHoaDon(hoaDon);
                _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanTachHD && c.Status == true && c.DichVu == 1 && c.Id!=_idHD).FirstOrDefault();
                int giatru;
                HoaDonChiTiet hoaDonChiTiet1 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
                if (hoaDonChiTiet1.Count == 0)
                {
                    _hoaDon.TotalMoney -= hoaDonChiTiet1.Price;
                    _qlHoaDon.DeleteHoaDonCT(hoaDonChiTiet1);
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                    return;
                }
                else if (hoaDonChiTiet1.Count!=0)
                {
                    hoaDonChiTiet1.Count -= _soLuong;
                    hoaDonChiTiet1.Price -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                    giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault()));
                    _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet1);
                    _hoaDon.TotalMoney -= giatru;
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                }
                
            }
            Lbl_Tien.Visible = true;
            Lbl_Tien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD).TotalMoney.ToString() +",000 VND";
            LoadHDCu(_IdBanTachHD);
            LoadHDMoi();            
            _f.Close();
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
                _f = new Form();
                Label label1 = new Label();
                Label label2 = new Label();
                Label label3 = new Label();
                Button button = new Button();
                button.Text = "OK";
                label2.Text = "Tổng tiền:";
                label3.Text = "ăn cứt";
                _f.Controls.Add(label1);
                _f.Controls.Add(label2);
                _f.Controls.Add(label3);
                _f.Controls.Add(button);
                _f.Controls[3].Left = 130;
                _f.Controls[3].Top = 70;
                _f.Controls[0].Left = 130;
                _f.Controls[1].Left = 30;
                _f.Controls[1].Top = 30;
                _f.Controls[2].Left = 130;
                _f.Controls[2].Top = 30;
                _f.Size = new Size(350, 150);
                label1.Text = "Bàn " + _IdBanTachHD;
                label3.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoaDon.Id).TotalMoney.ToString();
                _hoaDon.Status = false;
                _hoaDon.DateCheckOut = DateTime.Now;
                _qlHoaDon.UpdateHoaDon(_hoaDon);
                button.Click += Button_Click1;
                LoadHDMoi();
                _f.ShowDialog();
            }
            
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            _f.Close();
        }
        void LoadHDMoi()
        {
            var abc = (from a in _qlHoaDon.GetBillsFromDB().Where(c => c.Id == _idHD && c.Status == true)
                       join c in _qlHoaDon.GetHoaDonCTFromDB()
                       on a.Id equals c.Idbill
                       select new
                       {
                           IDHD = a.Id,
                           IdBan = a.Idtable,
                           TrangThai = a.Status,
                           DichVu = a.DichVu,
                           IDHDCT = c.Id,
                           IDFood = c.Idfood,
                           SoLuong = c.Count,

                       }).ToList();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "xoa";
            Bitmap b = new Bitmap(@"C:\Users\XAPE\Desktop\TestGit-master\RestaurantApp\Resources\001-close.png");
            img.Image = b;

            Dgrid_HDMoi.ColumnCount = 5;
            Dgrid_HDMoi.Columns[0].Name = "Tên món";
            Dgrid_HDMoi.Columns[1].Name = "Số lượng";
            Dgrid_HDMoi.Columns[2].Name = "Đơn giá";
            Dgrid_HDMoi.Columns[3].Name = "thành tiền";
            Dgrid_HDMoi.Columns[4].Name = "Id";
            Dgrid_HDMoi.Columns[4].Visible = false;
            Dgrid_HDMoi.Columns.Add(img);
            Dgrid_HDMoi.Rows.Clear();
            //Convert.ToDecimal((Convert.ToInt32(Txt_TienKhachDua.Text) - decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney)).ToString()).ToString("#,##0")  + ".000 VND";
            foreach (var x in abc)
            {
                Dgrid_HDMoi.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Name).FirstOrDefault(), x.SoLuong,
                   decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault())+".000 VND",
                   decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault() * x.SoLuong).ToString()+ ".000 VND", x.IDHDCT);
            }
        }//as

        private void Dgrid_HDMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlHoaDon.GetHoaDonCTFromDB().Count) || rowIndex == -1) return;
            _idHDCT = Convert.ToInt32(Dgrid_HDCu.Rows[rowIndex].Cells[4].Value.ToString());
            if (e.ColumnIndex == Dgrid_HDMoi.Columns["xoa"].Index)
            {
                _f = new Form();
                TextBox textBox = new TextBox();
                textBox.Width = 150;
                Button button1 = new Button();
                Label label = new Label();
                label.Text = "Số Lượng:";
                button1.Text = "Xác Nhận";
                _f.Controls.Add(textBox);
                _f.Controls.Add(button1);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 100;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;
                _f.Size = new Size(300, 120);
                //f.StartPosition=CenterToScreen();
                button1.Click += Button1_Click;
                _f.ShowDialog();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_f.Controls[0].Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng","Thông báo");                
                return;
            }
            if (_f.Controls[0].Text.All(char.IsDigit)==false)
            {
                MessageBox.Show("Số lượng không được nhập chữ","Thông báo");
                return;
            }
            _soLuong = Convert.ToInt32(_f.Controls[0].Text);
            _hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBanTachHD && c.Status == true && c.DichVu == 1 && c.Id != _idHD);
            HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c=>c.Id==_idHD);
            HoaDonChiTiet hoaDonChiTiet = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
            _HDCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c=>c.Idbill==_hoaDon.Id && c.Idfood==hoaDonChiTiet.Idfood);
            if (_soLuong>hoaDonChiTiet.Count)
            {
                MessageBox.Show("Số lượng lớn hơn rồi","Thông báo");
                _f.Close();
                return;
            }
            int giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault()));
            hoaDonChiTiet.Count -= _soLuong;
            hoaDonChiTiet.Price -= giatru;
            _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet);
            hoaDon.TotalMoney -= hoaDonChiTiet.Price;
            _qlHoaDon.UpdateHoaDon(hoaDon);

            _HDCT.Count += _soLuong;
            _HDCT.Price+= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            _qlHoaDon.UpdateHoaDonCT(_HDCT);
            _hoaDon.TotalMoney += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            _qlHoaDon.UpdateHoaDon(_hoaDon);

            LoadHDCu(_IdBanTachHD);
            LoadHDMoi();
            Lbl_Tien.Visible = true;
            Lbl_Tien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD).TotalMoney.ToString()+",000 VND";
        }

        private void FrmTachHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
            if (hoaDon.Status==true)
            {
                if (MessageBox.Show("Hóa đơn vừa tách chưa thanh toán, bạn có muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
                    _f = new Form();
                    Label label1 = new Label();
                    Label label2 = new Label();
                    Label label3 = new Label();
                    Button button = new Button();
                    button.Text = "OK";
                    label2.Text = "Tổng tiền:";
                    label3.Text = "ăn cứt";
                    _f.Controls.Add(label1);
                    _f.Controls.Add(label2);
                    _f.Controls.Add(label3);
                    _f.Controls.Add(button);
                    _f.Controls[3].Left = 130;
                    _f.Controls[3].Top = 70;
                    _f.Controls[0].Left = 130;
                    _f.Controls[1].Left = 30;
                    _f.Controls[1].Top = 30;
                    _f.Controls[2].Left = 130;
                    _f.Controls[2].Top = 30;
                    _f.Size = new Size(350, 150);
                    label1.Text = "Bàn " + _IdBanTachHD;
                    label3.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoaDon.Id).TotalMoney.ToString();
                    _hoaDon.Status = false;
                    _hoaDon.DateCheckOut = DateTime.Now;
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                    button.Click += Button_Click2;
                    LoadHDMoi();
                    _f.ShowDialog();
                }
            }
           
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            _f.Close();
        }
    }
}
