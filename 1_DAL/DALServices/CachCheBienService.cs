//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using _1_DAL.Context;
//using _1_DAL.iDALServices;
//using _1_DAL.Models;

//namespace _1_DAL.DALServices
//{
//    public class CachChebienService : iCachChebienService
//    {
//        DatabaseContext _dbContext;
//        List<CachChebien> _lstTables;
//        public string AddCachCheBien(CachChebien CachChebien)
//        {
//            _dbContext.CachChebiens.Add(CachChebien);
//            return "Thêm thành công";
//        }
//        public string UpdateCachCheBien(CachChebien CachChebien)
//        {
//            _dbContext.CachChebiens.Update(CachChebien);
//            return "Sửa thành công";
//        }
//        public string DeleteCachCheBien(CachChebien CachChebien)
//        {
//            _dbContext.CachChebiens.Remove(CachChebien);
//            return "Xóa thành công";
//        }
//        public string SaveCachCheBien()
//        {
//            _dbContext.SaveChanges();
//            return "Lưu thành công";
//        }
//        public List<CachChebien> GetMethodsFromDB()
//        {
//            return _lstTables = _dbContext.CachChebiens.ToList();
//        }
//    }
//}
