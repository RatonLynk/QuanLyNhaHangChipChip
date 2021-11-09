using _1_DAL.Context;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DALServices
{
    public class BanAnService : iBanAnService
    {
        DatabaseContext _dbContext;
        List<BanAn> _lstTables;
        public string AddBanAn(BanAn BanAn)
        {
            _dbContext.BanAns.Add(BanAn);
            return "Thêm thành công";
        }
        public string UpdateBanAn(BanAn BanAn)
        {
            _dbContext.BanAns.Update(BanAn);
            return "Sửa thành công";
        }
        public string DeleteBanAn(BanAn BanAn)
        {
            _dbContext.BanAns.Remove(BanAn);
            return "Xóa thành công";
        }
        public string SaveBanAn()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<BanAn> GetTablesFromDB()
        {
            return _lstTables = _dbContext.BanAns.ToList();
        }
    }
}
