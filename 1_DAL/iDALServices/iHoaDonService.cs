using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iHoaDonService
    {
        public string AddHoaDon(HoaDon HoaDon);
        public string UpdateHoaDon(HoaDon HoaDon);
        public string DeleteHoaDon(HoaDon HoaDon);
        public string SaveHoaDon();
        public List<HoaDon> GetBillsFromDB();
    }
}
