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
    public class CongThucService : iCongThucService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<CongThuc> _lstTables;

        public CongThucService()
        {
        }

        public string AddCongThuc(CongThuc CongThuc)
        {
            _dbContext.CongThucs.Add(CongThuc);
            return "Thêm thành công";
        }
        public string UpdateCongThuc(CongThuc CongThuc)
        {
            _dbContext.CongThucs.Update(CongThuc);
            return "Sửa thành công";
        }
        public string DeleteCongThuc(CongThuc CongThuc)
        {
            _dbContext.CongThucs.Remove(CongThuc);
            return "Xóa thành công";
        }
        public string SaveCongThuc()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<CongThuc> GetRecipesFromDB()
        {
            return _lstTables = _dbContext.CongThucs.ToList();
        }
    }
}
