using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using _1_DAL.DALServices;
using _2_BUS.iBUSServices;
using _2_BUS.Models;

namespace _2_BUS.BUSServices
{
    public class QLMenuService : iQLMenuService
    {
        iMonAnChiTietService _MonCT;
        public QLMenuService()
        {            
            _MonCT = new MonAnChiTietService();
        }
        public bool AddCategory(DanhMucFood cat)
        {
            throw new NotImplementedException();
        }

        public bool AddDetail(MonAnChiTiet food)
        {
            return _MonCT.AddMonAnChiTiet(food);
        }

        public bool AddItem(ThucDon food)
        {
            throw new NotImplementedException();
        }

        public bool AddMethod(CachChebien method)
        {
            throw new NotImplementedException();
        }

        public bool AddUnit(DonVi unit)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(DanhMucFood cat)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDetail(MonAnChiTiet food)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(ThucDon food)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMethod(CachChebien method)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUnit(DonVi unit)
        {
            throw new NotImplementedException();
        }

        public List<CachChebien> GetCachChebiens()
        {
            throw new NotImplementedException();
        }

        public List<DanhMucFood> GetDanhMucFoods()
        {
            throw new NotImplementedException();
        }

        public List<DonVi> GetDonVis()
        {
            throw new NotImplementedException();
        }

        public List<MonAnChiTiet> GetMonAnChiTiets()
        {
            throw new NotImplementedException();
        }

        public List<ViewMenu> GetViewMenus()
        {
            throw new NotImplementedException();
        }

        public List<ViewMenu> TimKiem()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(DanhMucFood cat)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetail(MonAnChiTiet food)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(ThucDon food)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMethod(CachChebien method)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUnit(DonVi unit)
        {
            throw new NotImplementedException();
        }
    }
}
