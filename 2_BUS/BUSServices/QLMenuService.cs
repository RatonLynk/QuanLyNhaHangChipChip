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
        private iMonAnChiTietService _iMonAnChiTietService;
        private iDonViService _iDonViService;
        private iCachChebienService _iCachChebienService;
        IThucDonService _IThucDon;
        iDonViService _Donvi;
        iDMFoodService _DMF;
        private List<MonAnChiTiet> _lstMonAnCT;
        private List<ThucDon> _lstMenu;
        private List<DonVi> _lstDonVi;
        private List<CachCheBien> _lstCachCheBien;
        

        public QLMenuService()
        {
            _iMonAnChiTietService = new MonAnChiTietService();
            _iDonViService = new DonViService();
            _IThucDon = new ThucDonService();
            _iCachChebienService = new CachCheBienService();
            _DMF = new DMFoodService();
        }
        public bool AddCategory(DanhMucFood cat)
        {
            _DMF.AddDMFood(cat);
            return true;
        }

        public bool AddDetail(MonAnChiTiet food)
        {
            _iMonAnChiTietService.AddMonAnChiTiet(food);
            return true;
        }

        public bool AddItem(ThucDon food)
        {
            _IThucDon.AddThucDon(food);
            return true;
        }

        public bool AddMethod(CachCheBien method)
        {
            _iCachChebienService.AddCachCheBien(method);
            return true;
        }


        public bool AddUnit(DonVi unit)
        {
            _Donvi.AddDonVi(unit);
            return true;
        }

        public bool DeleteCategory(DanhMucFood cat)
        {
            _DMF.DeleteDMFood(cat);
            return true;
        }

        public bool DeleteDetail(MonAnChiTiet food)
        {
            _iMonAnChiTietService.DeleteMonAnChiTiet(food);
            return true;
        }

        public bool DeleteItem(ThucDon food)
        {
            _IThucDon.DeleteThucDon(food);
            return true;
        }

        public bool DeleteMethod(CachCheBien method)
        {
            _iCachChebienService.DeleteCachCheBien(method);
            return true;
        }


        public bool DeleteUnit(DonVi unit)
        {
            _Donvi.DeleteDonVi(unit);
            return true;
        }

        public List<CachCheBien> GetCachChebiens()
        {
            return _iCachChebienService.GetMethodsFromDB();
        }

        public List<DanhMucFood> GetDanhMucFoods()
        {
            return _DMF.GetCategoriesFromDB();
        }

        public List<DonVi> GetDonVis()
        {
            return _Donvi.GetUnitsFromDB();
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

        public bool UpdateMethod(CachCheBien method)
        {
            throw new NotImplementedException();
        }


        public bool UpdateUnit(DonVi unit)
        {
            throw new NotImplementedException();
        }

        List<CachCheBien> iQLMenuService.GetCachCheBiens()
        {
            throw new NotImplementedException();
        }
    }
}
