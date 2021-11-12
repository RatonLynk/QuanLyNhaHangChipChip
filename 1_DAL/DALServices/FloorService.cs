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
    public class FloorService : iFloorService
    {
        DatabaseContext _dbContext = new DatabaseContext();
        List<Floor> _lstTables;
        public string AddFloor(Floor Floor)
        {
            _dbContext.Floors.Add(Floor);
            return "Thêm thành công";
        }
        public string UpdateFloor(Floor Floor)
        {
            _dbContext.Floors.Update(Floor);
            return "Sửa thành công";
        }
        public string DeleteFloor(Floor Floor)
        {
            _dbContext.Floors.Remove(Floor);
            return "Xóa thành công";
        }
        public string SaveFloor()
        {
            _dbContext.SaveChanges();
            return "Lưu thành công";
        }
        public List<Floor> GetFloorsFromDB()
        {
            return _lstTables = _dbContext.Floors.ToList();
        }
    }
}
