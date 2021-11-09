using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.iDALServices
{
    public interface iCachCheBienService
    {
        public string AddCachCheBien(CachCheBien CachCheBien);
        public string UpdateCachCheBien(CachCheBien CachCheBien);
        public string DeleteCachCheBien(CachCheBien CachCheBien);
        public string SaveCachCheBien();
        public List<CachCheBien> GetMethodsFromDB();
    }
}
