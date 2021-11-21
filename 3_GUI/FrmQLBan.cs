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
using System.Drawing.Imaging;
using _3_GUI.Properties;

namespace _3_GUI
{
    public partial class FrmQLBan : Form
    {
        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        iQLMenuService _qlMeniu;
        List<BanAn> _lstBanAn;
        int _IdBan;
        HoaDon _hoadon;
        int _soLuong;
        int _tongTien;
        int _IdHoaDon;
        int _idFood;
        public FrmQLBan()
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _lstBanAn = new List<BanAn>();
            _qlHoaDon = new QLHoaDon();
            _qlMeniu = new QLMenuService();
            _lstBanAn = _qlBanAn.GetTablesFromDB();
            LoadTableT1();
            LoadTableT2();
            LoadMeniu();
            LoadMangVe();
            //Lbl_GioVao.Text = DateTime.Now.ToString();
        }
        void LoadMangVe()
        {
            FlPanl_MangVe.Controls.Clear();
            foreach (HoaDon x in _qlHoaDon.GetBillsFromDB().Where(c=>c.DichVu==2))
            {
                Button btn = new Button() { Width = 70, Height = 70 };
                btn.Text = "Mang Về";
                btn.Click += Btn_Click1;
                btn.Tag = x;
                btn.BackColor = Color.Aqua;
                FlPanl_MangVe.Controls.Add(btn);
            }

        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            _IdHoaDon = ((sender as Button).Tag as HoaDon).Id;
            LoadHoaDonMangVe(_IdHoaDon);
            Lbl_ViTriBan.Text = "Mang Về";

        }
        void LoadHoaDonMangVe(int hoadon)
        {
            DataGridViewButtonColumn Xoa = new DataGridViewButtonColumn();
            Xoa.Name = "Xoa";
            Xoa.HeaderText = "Xóa món";
            Xoa.UseColumnTextForButtonValue = true;
            Xoa.Text = "Xóa";

            Dgid_HoaDon.ColumnCount = 4;
            Dgid_HoaDon.Columns[0].Name = "Tên món";
            Dgid_HoaDon.Columns[1].Name = "Số lượng";
            Dgid_HoaDon.Columns[2].Name = "Đơn giá";
            Dgid_HoaDon.Columns[3].Name = "thành tiền";
            Dgid_HoaDon.Columns.Add(Xoa);
            Dgid_HoaDon.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Id==hoadon))
            {
                Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Name).FirstOrDefault(), x.hoaDonChiTiet.Count, x.hoaDonChiTiet.Price,
                    x.hoaDonChiTiet.Count * x.hoaDonChiTiet.Price);
            }
        }

        void LoadTableT1()
        {
            FLPenal.Controls.Clear();
            foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1))
            {
                Button btn = new Button() { Width = x.Rong, Height = x.Cao };
                //btn.Image = Resources.download;
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
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            LoadHoaDon(id);
            Lbl_ViTriBan.Text = "Tầng 1 - " + banAn.Name;
        }

        void LoadTableT2()
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
            LoadHoaDon(id);
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            Lbl_ViTriBan.Text = "Tầng 2 - " + banAn.Name;
        }

        void LoadHoaDon(int bill)
        {

            DataGridViewButtonColumn Xoa = new DataGridViewButtonColumn();
            Xoa.Name = "Xoa";
            Xoa.HeaderText = "Xóa món";
            Xoa.UseColumnTextForButtonValue = true;
            Xoa.Text = "Xóa";

            Dgid_HoaDon.ColumnCount = 4;
            Dgid_HoaDon.Columns[0].Name = "Tên món";
            Dgid_HoaDon.Columns[1].Name = "Số lượng";
            Dgid_HoaDon.Columns[2].Name = "Đơn giá";
            Dgid_HoaDon.Columns[3].Name = "thành tiền";
            Dgid_HoaDon.Columns.Add(Xoa); 
            Dgid_HoaDon.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == bill && c.hoaDon.Status == true && c.hoaDon.DichVu==1))
            {
                Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c=>c.Id==x.hoaDonChiTiet.Idfood).Select(c=>c.Name).FirstOrDefault(),x.hoaDonChiTiet.Count,x.hoaDonChiTiet.Price,
                    x.hoaDonChiTiet.Count*x.hoaDonChiTiet.Price);
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

            DataGridViewTextBoxColumn txt = new DataGridViewTextBoxColumn();
            txt.Name = "Txt";
            

            Dgid_Meniu.ColumnCount = 2;
            Dgid_Meniu.Columns[0].Name = "Tên món";
            Dgid_Meniu.Columns[1].Name = "Giá tiền";            
            Dgid_Meniu.Columns.Add(Them);
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
            if (e.ColumnIndex == Dgid_Meniu.Columns["Them"].Index)
            {
                Form f = new Form();
                TextBox textBox = new TextBox();
                textBox.Width = 150;
                Button button = new Button();
                Label label = new Label();
                label.Text = "Số Lượng:";
                button.Text = "Xác Nhận";
                f.Controls.Add(textBox);
                f.Controls.Add(button);
                f.Controls.Add(label);
                f.Controls[2].Left = 10;
                f.Controls[2].Top = 13;
                f.Controls[0].Left = 80;
                f.Controls[1].Left = 100;
                f.Controls[0].Top = 10;
                f.Controls[1].Top = 50;
                f.Size = new Size(300, 120);                
                f.ShowDialog();
                f.Controls[1].Click += FrmQLBan_Click;

                _soLuong = Convert.ToInt32(f.Controls[0].Text);           


            }
        }

        private void FrmQLBan_Click(object sender, EventArgs e)
        {
            if (_qlBanAn.GetTablesFromDB().Where(c => c.Id == _IdBan).Select(c => c.TinhTrang).FirstOrDefault() == 1)
            {
                _hoadon = new HoaDon();
                _hoadon.Id = (_qlHoaDon.GetBillsFromDB().Count()) + 1;
                _hoadon.DateCheckIn = DateTime.Now;
                _hoadon.DateCheckOut = DateTime.Now;
                _hoadon.Idtable = _IdBan;
                _hoadon.Status = true;
                _hoadon.TotalMoney = 0;
                _hoadon.IdnhanVien = 1;
                _hoadon.DichVu = 1;
                _qlHoaDon.AddHoaDon(_hoadon);
                BanAn ban = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                ban.TinhTrang = 0;
                _qlBanAn.UpdateBanAn(ban);
                LoadHoaDon(_IdBan);

            }
            else if (_qlBanAn.GetTablesFromDB().Where(c => c.Id == _IdBan).Select(c => c.TinhTrang).FirstOrDefault() == 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan);
            }

            HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
            hoaDonChiTiet.Id = (_qlHoaDon.GetHoaDonCTFromDB().Count()) + 1;
            hoaDonChiTiet.Idbill = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBan).Select(c => c.Id).FirstOrDefault();
            hoaDonChiTiet.Idfood = _idFood;
            hoaDonChiTiet.Count = _soLuong;
            hoaDonChiTiet.Price = _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
            hoaDonChiTiet.Status = true;
            _qlHoaDon.AddHoaDonCT(hoaDonChiTiet);

            _hoadon.TotalMoney += hoaDonChiTiet.Price;
            _qlHoaDon.UpdateHoaDon(_hoadon);
            LoadHoaDon(_IdBan);
        }

        private void Tp_Tang1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MangVe_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.DateCheckIn = DateTime.Now;
            hoaDon.DateCheckOut = DateTime.Now;
            hoaDon.Id=(_qlHoaDon.GetBillsFromDB().Count())+1;
            hoaDon.Idtable = null;
            hoaDon.IdnhanVien = 1;
            hoaDon.SoDT = null;
            hoaDon.Status = true;
            hoaDon.DiaChi = null;
            hoaDon.DichVu = 2;
            hoaDon.GhiChu = null;
            hoaDon.TotalMoney = 0;
            _qlHoaDon.AddHoaDon(hoaDon);
            LoadMangVe();
            //CustomControl customControl = new CustomControl();          

        }
    }
}
