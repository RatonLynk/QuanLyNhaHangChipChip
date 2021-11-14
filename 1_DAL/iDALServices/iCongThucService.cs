using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iCongThucService
    {
        public string AddCongThuc(CongThuc CongThuc);
        public string UpdateCongThuc(CongThuc CongThuc);
        public string DeleteCongThuc(CongThuc CongThuc);
        public string SaveCongThuc();
        public List<CongThuc> GetRecipesFromDB();
    }
}
