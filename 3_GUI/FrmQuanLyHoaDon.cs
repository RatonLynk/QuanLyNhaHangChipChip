using _2_BUS.BUSServices;
using _2_BUS.iBUSServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class FrmQuanLyHoaDon : Form
    {
        IQLHoaDon _qlHoaDon;
        int _idHoaDon;

        public FrmQuanLyHoaDon()
        {


            InitializeComponent();
            _qlHoaDon = new QLHoaDon();
            LoadHoaDon();

        }
        void LoadHoaDon()
        {

            Dgid_HoaDon.ColumnCount = 7;

            Dgid_HoaDon.Columns[0].Name = "Tên bàn";
            Dgid_HoaDon.Columns[1].Name = "tổng tiền";
            Dgid_HoaDon.Columns[2].Name = "date check in";
            Dgid_HoaDon.Columns[3].Name = "date check out";
            Dgid_HoaDon.Columns[4].Name = "tình trạng";
            Dgid_HoaDon.Columns[5].Name = "Nhân viên thêm";
            Dgid_HoaDon.Columns[6].Name = "id";
            Dgid_HoaDon.Columns[6].Visible = false;

            Dgid_HoaDon.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon())
            {
                Dgid_HoaDon.Rows.Add(_qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == x.banAn.Id).Select(c => c.banAn.Name).FirstOrDefault(), x.hoaDon.TotalMoney,
                    x.hoaDon.DateCheckIn, x.hoaDon.DateCheckOut, Convert.ToInt32(x.hoaDon.Status) == 0 ? "đã thanh toán" : Convert.ToInt32(x.hoaDon.Status) == 1 ? "chưa thanh toán" : "", _qlHoaDon.GetListDSHoaDon().Where(c => c.nhanVien.Id == x.hoaDon.IdnhanVien).Select(c => c.nhanVien.Name).FirstOrDefault(), x.hoaDon.Id);

            }

        }
        void LoadHoaDon(DateTime date1, DateTime date2)
        {
            Dgid_HoaDon.ColumnCount = 7;
            Dgid_HoaDon.Columns[0].Name = "Tên bàn";
            Dgid_HoaDon.Columns[1].Name = "tổng tiền";
            Dgid_HoaDon.Columns[2].Name = "date check in";
            Dgid_HoaDon.Columns[3].Name = "date check out";
            Dgid_HoaDon.Columns[4].Name = "tình trạng";
            Dgid_HoaDon.Columns[5].Name = "tình trạng";
            Dgid_HoaDon.Columns[6].Name = "id";
            Dgid_HoaDon.Columns[6].Visible = false;

            Dgid_HoaDon.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => (c.hoaDon.DateCheckIn >= date1.AddDays(-1) && c.hoaDon.DateCheckIn <= date2)))
            {
                Dgid_HoaDon.Rows.Add(_qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == x.banAn.Id).Select(c => c.banAn.Name).FirstOrDefault(), x.hoaDon.TotalMoney,
                    x.hoaDon.DateCheckIn, x.hoaDon.DateCheckOut, Convert.ToInt32(x.hoaDon.Status) == 0 ? "đã thanh toán" : Convert.ToInt32(x.hoaDon.Status) == 1 ? "chưa thanh toán" : "", _qlHoaDon.GetListDSHoaDon().Where(c => c.nhanVien.Id == x.hoaDon.IdnhanVien).Select(c => c.nhanVien.Name).FirstOrDefault(), x.hoaDon.Id);

            }

        }
        void LoadHoaDonChiTiet(int id)
        {
            dgrid_hdct.ColumnCount = 6;
            dgrid_hdct.Columns[0].Name = "tên món";
            dgrid_hdct.Columns[1].Name = "số lượng";
            dgrid_hdct.Columns[2].Name = "đơn giá";
            dgrid_hdct.Columns[3].Name = "thành tiền";
            dgrid_hdct.Columns[4].Name = "loại hình";
         
            dgrid_hdct.Columns[5].Name = "id";
            dgrid_hdct.Columns[5].Visible = false;

            dgrid_hdct.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Id == id))
            {
                dgrid_hdct.Rows.Add(_qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Id == x.hoaDonChiTiet.Idbill).Select(c => c.monAnChiTiet.Name).FirstOrDefault(), x.hoaDonChiTiet.Count,
                    x.hoaDonChiTiet.Price, x.hoaDon.TotalMoney,x.hoaDon.DichVu==1?"Tại bàn":"Mang về", x.hoaDonChiTiet.Id);

            }

        }

        private void Dgid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if ((rowIndex == _qlHoaDon.GetBillsFromDB().Count) || rowIndex == -1) return;
            _idHoaDon = Convert.ToInt32(Dgid_HoaDon.Rows[rowIndex].Cells[6].Value.ToString());
            LoadHoaDonChiTiet(_idHoaDon);
            //ádsdsasdsdff
        }
        

        private void btn_thongKe_Click_1(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;


            LoadHoaDon(date1, date2);
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
    }
}
       
