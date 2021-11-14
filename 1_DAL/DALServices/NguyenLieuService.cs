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
    public class NguyenLieuService : iNguyenLieuService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<NguyenLieu> _lstTables;
        public string AddNguyenLieu(NguyenLieu NguyenLieu)
        {
            _dbContext.NguyenLieus.Add(NguyenLieu);
            return "Thêm thành công";
        }
        public string UpdateNguyenLieu(NguyenLieu NguyenLieu)
        {
            _dbContext.NguyenLieus.Update(NguyenLieu);
            return "Sửa thành công";
        }
        public string DeleteNguyenLieu(NguyenLieu NguyenLieu)
        {
            _dbContext.NguyenLieus.Remove(NguyenLieu);
            return "Xóa thành công";
        }
        public string SaveNguyenLieu()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<NguyenLieu> GetIngredientsFromDB()
        {
            return _lstTables = _dbContext.NguyenLieus.ToList();
        }
    }
}
