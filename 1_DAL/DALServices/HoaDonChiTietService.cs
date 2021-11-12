using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using _1_DAL.Context;

namespace _1_DAL.DALServices
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        DatabaseContext _dbConText;
        public HoaDonChiTietService()
        {
            _dbConText = new DatabaseContext();
        }
        public string AddHoaDon(HoaDonChiTiet HoaDon)
        {
            _dbConText.HoaDonChiTiets.Add(HoaDon);
            return "Thêm thành công";
        }

        public string DeleteHoaDon(HoaDonChiTiet HoaDon)
        {
            _dbConText.HoaDonChiTiets.Update(HoaDon);
            return "Xóa thành công";
        }

        public List<HoaDonChiTiet> GetHoaDonCTFromDB()
        {
            return _dbConText.HoaDonChiTiets.ToList();
        }

        public string SaveHoaDon()
        {
            _dbConText.SaveChanges();
            return "Lưu thành công";
        }

        public string UpdateHoaDon(HoaDonChiTiet HoaDon)
        {
            _dbConText.HoaDonChiTiets.Update(HoaDon);
            return "Sửa thành công";
        }
    }
}
