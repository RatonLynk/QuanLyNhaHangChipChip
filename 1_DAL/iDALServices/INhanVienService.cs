using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _1_DAL.iDALServices
{
    public interface INhanVienService
    {
        public string AddNV(NhanVien nhanVien);
        public string EditNV(NhanVien nhanVien);
        public string remoteNV(NhanVien nhanVien);
        public string Save();
        public List<NhanVien> GetLstNVfromDB();
    }
}
