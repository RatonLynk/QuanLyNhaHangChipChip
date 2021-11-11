using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _1_DAL.iDALServices
{
   public interface IHoaDonChiTietService
    {
        public string AddHoaDon(HoaDonChiTiet HoaDon);
        public string UpdateHoaDon(HoaDonChiTiet HoaDon);
        public string DeleteHoaDon(HoaDonChiTiet HoaDon);
        public string SaveHoaDon();
        public List<HoaDonChiTiet> GetHoaDonCTFromDB();
    }
}
