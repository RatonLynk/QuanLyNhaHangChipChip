using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.iDALServices;
using _1_DAL.Models;

namespace _1_DAL.DALServices
{
    class MonAnChiTietService : iMonAnChiTietService
    {
        DatabaseContext _dbContext;
        List<MonAnChiTiet> _lstTables;
        public string AddMonAnChiTiet(MonAnChiTiet MonAnChiTiet)
        {
            _dbContext.MonAnChiTiets.Add(MonAnChiTiet);
            return "Thêm thành công";
        }
        public string UpdateMonAnChiTiet(MonAnChiTiet MonAnChiTiet)
        {
            _dbContext.MonAnChiTiets.Update(MonAnChiTiet);
            return "Sửa thành công";
        }
        public string DeleteMonAnChiTiet(MonAnChiTiet MonAnChiTiet)
        {
            _dbContext.MonAnChiTiets.Remove(MonAnChiTiet);
            return "Xóa thành công";
        }
        public string SaveMonAnChiTiet()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<MonAnChiTiet> GetDetailsFromDB()
        {
            return _lstTables = _dbContext.MonAnChiTiets.ToList();
        }
    }
}
