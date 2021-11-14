using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iNguyenLieuService
    {
        public string AddNguyenLieu(NguyenLieu nguyenLieu);
        public string UpdateNguyenLieu(NguyenLieu nguyenLieu);
        public string DeleteNguyenLieu(NguyenLieu nguyenLieu);
        public string SaveNguyenLieu();
        public List<NguyenLieu> GetIngredientsFromDB();
    }
}
