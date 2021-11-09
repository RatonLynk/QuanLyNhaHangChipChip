using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iCachChebienService
    {
        public string AddCachCheBien(CachChebien CachChebien);
        public string UpdateCachCheBien(CachChebien CachChebien);
        public string DeleteCachCheBien(CachChebien CachChebien);
        public string SaveCachCheBien();
        public List<CachChebien> GetMethodsFromDB();
    }
}
