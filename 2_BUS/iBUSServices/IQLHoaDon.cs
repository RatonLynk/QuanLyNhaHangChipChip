using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using _2_BUS.Models;

namespace _2_BUS.iBUSServices
{
   public interface IQLHoaDon
    {
        public void AddHoaDon(HoaDon HoaDon);
        public void UpdateHoaDon(HoaDon HoaDon);
        public void DeleteHoaDon(HoaDon HoaDon);
        public string SaveHoaDon();
        public List<HoaDon> GetBillsFromDB();
        public string AddHoaDonCT(HoaDonChiTiet HoaDon);
        public string UpdateHoaDonCT(HoaDonChiTiet HoaDon);
        public string DeleteHoaDonCT(HoaDonChiTiet HoaDon);
        public string SaveHoaDonChiTiet();
        public List<HoaDonChiTiet> GetHoaDonCTFromDB();
        public List<ViewHoaDon> GetListDSHoaDon();
    }
}
