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
    public partial class FrmQLBan : Form
    {
        public static string mail;
        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        iQLMenuService _qlMeniu;
        List<BanAn> _lstBanAn;
        IQLNhanVienService _qlNhanVien;
        int _IdBan;
        HoaDon _hoadon;
        int _soLuong;
        int _tongTien;
        int _IdHoaDon;
        int _idFood;
        int _IdHdCt;
        NhanVien _nhanVien;
        HoaDonChiTiet _hoadonCT;
        Form _f;
        public FrmQLBan()
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _lstBanAn = new List<BanAn>();
            _qlHoaDon = new QLHoaDon();
            _qlMeniu = new QLMenuService();
            _qlNhanVien = new QLNhanVienService();
            _lstBanAn = _qlBanAn.GetTablesFromDB();
            LoadTableT1();
            LoadTableT2();
            LoadMeniu();
            LoadMangVe();
            Lbl_TongTien.Visible = false;
            //Lbl_GioVao.Text = DateTime.Now.ToString()            
            _nhanVien = _qlNhanVien.getlstNhanViens().FirstOrDefault(c=>c.Email==mail);
        }
        
        void LoadMangVe()
        {
            FlPanl_MangVe.Controls.Clear();
            foreach (HoaDon x in _qlHoaDon.GetBillsFromDB().Where(c => c.DichVu == 2 && c.Status == true))
            {
                Button btn1 = new Button() { Width = 70, Height = 70 };
                btn1.Text = "Mang Về";
                btn1.Click += Btn1_Click1;
                btn1.Tag = x;
                btn1.BackColor = Color.Aqua;
                FlPanl_MangVe.Controls.Add(btn1);
            }

        }        

        private void Btn1_Click1(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as HoaDon).Id;
            _IdHoaDon = id;
            _IdBan = 0;
            Lbl_ViTriBan.Text = "Mang Về";
            Lbl_TongTien.Visible = true;
            _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
            Lbl_TongTien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon).TotalMoney.ToString();
            Lbl_GioVao.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon).DateCheckIn.ToString();
            LoadHoaDonMangVe(_IdHoaDon);

        }
        void LoadHoaDonMangVe(int hoadon)
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "nut";
            Bitmap b = new Bitmap(@"C:\Users\XAPE\Desktop\TestGit-master\RestaurantApp\Resources\001-close.png");
            img.Image = b;

            Dgid_HoaDon.ColumnCount = 4;
            Dgid_HoaDon.Columns[0].Name = "Tên món";
            Dgid_HoaDon.Columns[1].Name = "Số lượng";
            Dgid_HoaDon.Columns[2].Name = "Đơn giá";
            Dgid_HoaDon.Columns[3].Name = "thành tiền";
            Dgid_HoaDon.Columns.Add(img);
            Dgid_HoaDon.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Id == hoadon && c.hoaDon.Status == true))
            {
                Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Name).FirstOrDefault(), x.hoaDonChiTiet.Count,
                    _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault(),
                    x.hoaDonChiTiet.Count * _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            }
        }

        public void LoadTableT1()
        {
            FLPenal.Controls.Clear();
            foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1))
            {
                Button btn = new Button() { Width = x.Rong, Height = x.Cao };
                //Bitmap b = new Bitmap(@"C:\Users\XAPE\Desktop\TestGit-master\RestaurantApp\Resources\caiBan.png");                
                //btn.Image= b;
                btn.Text = x.Name + Environment.NewLine + (x.TinhTrang == 1 ? "Trống" : "Có người");
                btn.Click += Btn_Click;
                btn.Tag = x;
                switch (x.TinhTrang)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                FLPenal.Controls.Add(btn);

            }
            //â
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            _IdHoaDon = 0;
            FrmChuyenBan._IdBanCu = id;
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            LoadHoaDon(id);
            Lbl_ViTriBan.Text = "Tầng 1 - " + banAn.Name;
            Lbl_TongTien.Visible = true;
            if (_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1) == null)
            {
                Lbl_TongTien.Text = "0";
                Lbl_GioVao.Text = "00:00:00 00/00/2021";
            }
            else
            {
                Lbl_TongTien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).TotalMoney.ToString();
                Lbl_GioVao.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).DateCheckIn.ToString();
            }

        }

        public void LoadTableT2()
        {
            FlPanel2.Controls.Clear();
            foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 2))
            {
                Button btn1 = new Button() { Width = x.Rong, Height = x.Cao };
                btn1.Text = x.Name + Environment.NewLine + (x.TinhTrang == 1 ? "Trống" : "Có người");

                btn1.Click += Btn1_Click;
                btn1.Tag = x;
                switch (x.TinhTrang)
                {
                    case 1:
                        btn1.BackColor = Color.Aqua;
                        break;
                    default:
                        btn1.BackColor = Color.LightPink;
                        break;
                }
                FlPanel2.Controls.Add(btn1);
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            _IdHoaDon = 0;
            FrmChuyenBan._IdBanCu = id;
            LoadHoaDon(id);
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            Lbl_ViTriBan.Text = "Tầng 2 - " + banAn.Name;
            Lbl_TongTien.Visible = true;
            if (_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1) == null)
            {
                Lbl_TongTien.Text = "0";
                Lbl_GioVao.Text = "00:00:00 00/00/2021";
            }
            else
            {
                Lbl_TongTien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).TotalMoney.ToString();
                Lbl_GioVao.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).DateCheckIn.ToString();
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            BanAn ban = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1).Select(c => c.Id).Max());
            MessageBox.Show(_qlBanAn.DeleteBanAn(ban), "Thông báo");
            LoadTableT1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BanAn ban = new BanAn();
            ban.Id = (_qlBanAn.GetTablesFromDB().Count() + 1);
            ban.Name = "Bàn " + (_qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1).Count() + 1);
            ban.Floor = 1;
            ban.Busy = "a";
            ban.Status = true;
            ban.TinhTrang = 1;
            ban.Rong = 70;
            ban.Cao = 70;
            MessageBox.Show(_qlBanAn.AddBanAn(ban), "Thông báo");
            LoadTableT1();
        }

        private void Btn_ThemBanT2_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_XoaBanT2_Click(object sender, EventArgs e)
        {
            BanAn ban = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 2).Select(c => c.Id).Max());
            MessageBox.Show(_qlBanAn.DeleteBanAn(ban), "Thông báo");
            LoadTableT2();
        }
        void LoadMeniu()
        {
            DataGridViewButtonColumn Them = new DataGridViewButtonColumn();
            Them.Name = "Them";
            Them.HeaderText = "Thêm món";
            Them.UseColumnTextForButtonValue = true;
            Them.Text = "Thêm";

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "số lượng";
            cmb.Items.Add("1");
            cmb.Items.Add("2");
            cmb.Items.Add("3");
            cmb.Items.Add("4");
            cmb.Items.Add("5");
            cmb.Name = "combobox";

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "nut";
            Bitmap b = new Bitmap(@"C:\Users\XAPE\Desktop\TestGit-master\RestaurantApp\Resources\003-signs.png");
            img.Image = b;


            Dgid_Meniu.ColumnCount = 2;
            Dgid_Meniu.Columns[0].Name = "Tên món";
            Dgid_Meniu.Columns[1].Name = "Giá tiền";
            Dgid_Meniu.Columns.Add(img);
            Dgid_Meniu.Rows.Clear();
            foreach (var x in _qlMeniu.GetViewMenus())
            {
                Dgid_Meniu.Rows.Add(x.details.Name, x.details.Price);
            }

        }

        private void Dgid_Meniu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlMeniu.GetMonAnChiTiets().Count) || rowIndex == -1) return;
            _idFood = _qlMeniu.GetMonAnChiTiets().Where(c => c.Name == Dgid_Meniu.Rows[rowIndex].Cells[0].Value.ToString()).Select(c => c.Id).FirstOrDefault();
            if (e.ColumnIndex == Dgid_Meniu.Columns["nut"].Index)
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
                button.Click += Button_Click;
                _f.ShowDialog();

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _soLuong = Convert.ToInt32(_f.Controls[0].Text);
            if (_IdBan != 0 && _IdHoaDon == 0)
            {
                if (_qlBanAn.GetTablesFromDB().Where(c => c.Id == _IdBan).Select(c => c.TinhTrang).FirstOrDefault() == 1)
                {
                    NhanVien nhanVien = new NhanVien();

                    _hoadon = new HoaDon();
                    _hoadon.Id = (_qlHoaDon.GetBillsFromDB().Count()) + 1;
                    _hoadon.DateCheckIn = DateTime.Now;
                    _hoadon.DateCheckOut = DateTime.Now;
                    _hoadon.Idtable = _IdBan;
                    _hoadon.Status = true;
                    _hoadon.TotalMoney = 0;
                    //_hoadon.IdnhanVien == _nhanVien.Id;
                    _hoadon.IdnhanVien = 1;
                    _hoadon.DichVu = 1;
                    _qlHoaDon.AddHoaDon(_hoadon);
                    BanAn ban = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                    ban.TinhTrang = 0;
                    _qlBanAn.UpdateBanAn(ban);
                    LoadHoaDon(_IdBan);
                    _hoadonCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idbill == _hoadon.Id && _idFood == c.Idfood);

                }
                else if (_qlBanAn.GetTablesFromDB().Where(c => c.Id == _IdBan).Select(c => c.TinhTrang).FirstOrDefault() == 0)
                {
                    _hoadon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBan && c.Status == true).FirstOrDefault();
                    _hoadonCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idbill == _hoadon.Id && _idFood == c.Idfood);
                }

                if (_hoadonCT == null)
                {
                    HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                    hoaDonChiTiet.Id = (_qlHoaDon.GetHoaDonCTFromDB().Count()) + 1;
                    hoaDonChiTiet.Idbill = _hoadon.Id;
                    hoaDonChiTiet.Idfood = _idFood;
                    hoaDonChiTiet.Count = _soLuong;
                    hoaDonChiTiet.Price = _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                    hoaDonChiTiet.Status = true;
                    _qlHoaDon.AddHoaDonCT(hoaDonChiTiet);

                    _hoadon.TotalMoney += hoaDonChiTiet.Price;
                    _qlHoaDon.UpdateHoaDon(_hoadon);
                    LoadHoaDon(_IdBan);
                    LoadTableT1();
                    LoadTableT2();
                    _f.Close();
                    Lbl_TongTien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).TotalMoney.ToString();


                }//ád
                else if (_hoadonCT != null)
                {

                    if (_idFood == _hoadonCT.Idfood)
                    {
                        _hoadon.TotalMoney = 0;
                        _qlHoaDon.UpdateHoaDon(_hoadon);
                        HoaDonChiTiet hoaDonChiTiet1 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idfood == _idFood && c.Idbill == _hoadon.Id);
                        hoaDonChiTiet1.Count += _soLuong;
                        hoaDonChiTiet1.Price += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                        _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet1);

                        _hoadon.TotalMoney += hoaDonChiTiet1.Price;
                        _qlHoaDon.UpdateHoaDon(_hoadon);
                        LoadHoaDon(_IdBan);
                        LoadTableT1();
                        LoadTableT2();
                        _f.Close();
                        Lbl_TongTien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).TotalMoney.ToString();
                    }
                }

            }
            else if (_IdHoaDon != 0 && _IdBan == 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                hoaDonChiTiet.Id = (_qlHoaDon.GetHoaDonCTFromDB().Count()) + 1;
                hoaDonChiTiet.Idbill = _hoadon.Id;
                hoaDonChiTiet.Idfood = _idFood;
                hoaDonChiTiet.Count = _soLuong;
                hoaDonChiTiet.Price = _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                hoaDonChiTiet.Status = true;
                _qlHoaDon.AddHoaDonCT(hoaDonChiTiet);

                _hoadon.TotalMoney += hoaDonChiTiet.Price;
                _qlHoaDon.UpdateHoaDon(_hoadon);
                LoadHoaDonMangVe(_hoadon.Id);
                _f.Close();
            }
        }

        private void Tp_Tang1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MangVe_Click(object sender, EventArgs e)
        {
            _f = new Form();
            TextBox textBox1 = new TextBox();
            textBox1.Width = 250;
            TextBox textBox2 = new TextBox();
            textBox2.Width = 250;
            Button button123 = new Button();
            Label label = new Label();
            Label label1 = new Label();
            label.Text = "Địa chỉ:";
            label1.Text = "Số Đt:";
            button123.Text = "Thêm";
            _f.Controls.Add(textBox1);
            _f.Controls.Add(button123);
            _f.Controls.Add(label);
            _f.Controls.Add(textBox2);
            _f.Controls.Add(label1);
            _f.Controls[3].Left = 80;
            _f.Controls[3].Top = 50;
            _f.Controls[4].Left = 10;
            _f.Controls[4].Top = 53;
            _f.Controls[2].Left = 10;
            _f.Controls[2].Top = 13;
            _f.Controls[0].Left = 80;
            _f.Controls[1].Left = 150;
            _f.Controls[0].Top = 10;
            _f.Controls[1].Top = 90;
            _f.Size = new Size(400, 180);
            button123.Click += Button123_Click;
            _f.ShowDialog();

        }

        private void Button123_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.DateCheckIn = DateTime.Now;
            hoaDon.DateCheckOut = DateTime.Now;
            hoaDon.Id = (_qlHoaDon.GetBillsFromDB().Count()) + 1;
            hoaDon.Idtable = 1;
            //hoaDon.IdnhanVien = _nhanVien.Id;
            hoaDon.IdnhanVien = 1;
            hoaDon.SoDT = _f.Controls[3].Text;
            hoaDon.Status = true;
            hoaDon.DiaChi = _f.Controls[0].Text;
            hoaDon.DichVu = 2;
            hoaDon.GhiChu = null;
            hoaDon.TotalMoney = 0;
            _qlHoaDon.AddHoaDon(hoaDon);
            LoadMangVe();
            _f.Close();
        }

        private void Btn_HuyBan_Click(object sender, EventArgs e)
        {
            if (_IdBan != 0 || _IdHoaDon != 0)
            {
                _f = new Form();
                TextBox textBox = new TextBox();
                textBox.Width = 250;
                Button button12 = new Button();
                Label label = new Label();
                label.Text = "Lý do:";
                button12.Text = "Hủy";
                _f.Controls.Add(textBox);
                _f.Controls.Add(button12);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 150;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;
                _f.Size = new Size(400, 120);
                button12.Click += Button12_Click;
                _f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa bọn bàn nào", "Thông báo");
                return;
            }

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable==_IdBan && c.Status==true);
            if (_IdBan==0 && _IdHoaDon!=0)
            {
                _hoadon.Status = false;
                _hoadon.GhiChu = _f.Controls[0].Text;
                _qlHoaDon.UpdateHoaDon(_hoadon);
                LoadMangVe();
                _f.Close();
            }
            else if (_IdBan != 0 && _IdHoaDon == 0)
            {
                _hoadon.Status = false;
                _hoadon.GhiChu = _f.Controls[0].Text;
                _qlHoaDon.UpdateHoaDon(_hoadon);

                BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                banAn.TinhTrang = 1;
                _qlBanAn.UpdateBanAn(banAn);
                LoadTableT1();
                LoadTableT2();
                _f.Close();
            }
        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
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
            button.Click += Button_Click1;
            //_f.ShowDialog();


            if (_IdHoaDon != 0 && _IdBan == 0)
            {

                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
                _hoadon.Status = false;
                _hoadon.DateCheckOut = DateTime.Now;
                _qlHoaDon.UpdateHoaDon(_hoadon);
                label1.Text = "Mang về";
                label3.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney.ToString();
                LoadMangVe();
                LoadHoaDonMangVe(_hoadon.Id);
                _f.ShowDialog();
                Lbl_TongTien.Text = "0";

            }
            else if (_IdHoaDon == 0 && _IdBan != 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBan && c.Status == true).FirstOrDefault();
                _hoadon.Status = false;
                _hoadon.DateCheckOut = DateTime.Now;
                _qlHoaDon.UpdateHoaDon(_hoadon);
                BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                banAn.TinhTrang = 1;
                label1.Text = "Bàn " + _hoadon.Idtable.ToString();
                label3.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney.ToString();
                _qlBanAn.UpdateBanAn(banAn);
                LoadHoaDon(banAn.Id);
                LoadTableT1();
                LoadTableT2();
                _f.ShowDialog();
                Lbl_TongTien.Text = "0";
            }
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            _f.Close();
        }
        void LoadHoaDon(int idban)
        {
            var abc = (from a in _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == idban && c.Status == true && c.DichVu == 1)
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

            Dgid_HoaDon.ColumnCount = 5;
            Dgid_HoaDon.Columns[0].Name = "Tên món";
            Dgid_HoaDon.Columns[1].Name = "Số lượng";
            Dgid_HoaDon.Columns[2].Name = "Đơn giá";
            Dgid_HoaDon.Columns[3].Name = "thành tiền";
            Dgid_HoaDon.Columns[4].Name = "Id";
            Dgid_HoaDon.Columns[4].Visible = false;
            Dgid_HoaDon.Columns.Add(img);
            Dgid_HoaDon.Rows.Clear();
            //foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == bill && c.hoaDon.Status == true && c.hoaDon.DichVu == 1))
            //{
            //    Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Name).FirstOrDefault(), x.hoaDonChiTiet.Count,
            //        _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault(),
            //        x.hoaDonChiTiet.Count * _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            //}
            foreach (var x in abc)
            {
                Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Name).FirstOrDefault(), x.SoLuong,
                    _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault(),
                    _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault() * x.SoLuong, x.IDHDCT);
            }

        }
        private void Dgid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlHoaDon.GetHoaDonCTFromDB().Count) || rowIndex == -1) return;
            _IdHdCt = Convert.ToInt32(Dgid_HoaDon.Rows[rowIndex].Cells[4].Value.ToString());
            if (e.ColumnIndex == Dgid_HoaDon.Columns["xoa"].Index)
            {
                _f = new Form();
                TextBox textBox31 = new TextBox();
                textBox31.Width = 150;
                Button Btn_XoaMon = new Button();
                Label label = new Label();
                label.Text = "Số Lượng:";
                Btn_XoaMon.Text = "Xác Nhận";
                _f.Controls.Add(textBox31);
                _f.Controls.Add(Btn_XoaMon);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 100;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;
                _f.Size = new Size(300, 120);
                Btn_XoaMon.Click += Btn_XoaMon_Click;
                _f.ShowDialog();
            }
        }

        private void Btn_XoaMon_Click(object sender, EventArgs e)
        {
            _hoadon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).FirstOrDefault();            
            int giatru;
            _soLuong = Convert.ToInt32(_f.Controls[0].Text);
            HoaDonChiTiet hoaDonChiTiet = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _IdHdCt);            
            hoaDonChiTiet.Count -= _soLuong;
            hoaDonChiTiet.Price -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
            giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault()));
            _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet);
            //List<HoaDonChiTiet> lstHDCT = _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Idbill == _hoadon.Id).ToList();
            //foreach (var x in lstHDCT)
            //{
            //    _hoadon.TotalMoney += x.Price;
            //}
            _hoadon.TotalMoney -= giatru;
            _qlHoaDon.UpdateHoaDon(_hoadon);
            LoadHoaDon(_IdBan);
            Lbl_TongTien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).TotalMoney.ToString();
            _f.Close();
        }

        private void Btn_ThemBanT2_Click_1(object sender, EventArgs e)
        {
            BanAn ban = new BanAn();
            ban.Id = (_qlBanAn.GetTablesFromDB().Count() + 1);
            ban.Name = "Bàn " + (_qlBanAn.GetTablesFromDB().Where(c => c.Floor == 2).Count() + 1);
            ban.Floor = 2;
            ban.Busy = "a";
            ban.Status = true;
            ban.TinhTrang = 1;
            ban.Rong = 60;
            ban.Cao = 60;
            MessageBox.Show(_qlBanAn.AddBanAn(ban), "Thông báo");
            LoadTableT2();
        }

        private void Btn_ChuyenBan_Click(object sender, EventArgs e)
        {
            FrmChuyenBan frmChuyenBan = new FrmChuyenBan(this);
            frmChuyenBan.reloadBan += FrmChuyenBan_reloadBan;
            frmChuyenBan.Show();
        }

        private void FrmChuyenBan_reloadBan()
        {
            FLPenal.Controls.Clear();
            LoadTableT1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLPenal.Controls.Clear();
        }

        private void Btn_TachHoaDon_Click(object sender, EventArgs e)
        {
            FrmTachHoaDon frmTachHoaDon = new FrmTachHoaDon();
            frmTachHoaDon.Show();
        }
    }
}
