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
        private IThucDonService _ithucDonService;
        private iDMFoodService _iDMFoodService;
        private List<MonAnChiTiet> _lstMonAnCT;
        private List<ThucDon> _lstMenu;
        private List<DonVi> _lstDonVi;
        private List<CachCheBien> _lstCachCheBien;
        private List<DanhMucFood> _lstDMFood;
        

        public QLMenuService()
        {
            _iMonAnChiTietService = new MonAnChiTietService();
        }
        public bool AddCategory(DanhMucFood cat)
        {
            throw new NotImplementedException();
        }

        public bool AddDetail(MonAnChiTiet food)
        {
            _iMonAnChiTietService.AddMonAnChiTiet(food);
            return true;
        }

        public bool AddItem(ThucDon food)
        {
            throw new NotImplementedException();
        }

        public bool AddMethod(CachCheBien method)
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

        public bool DeleteMethod(CachCheBien method)
        {
            throw new NotImplementedException();
        }


        public bool DeleteUnit(DonVi unit)
        {
            throw new NotImplementedException();
        }

        public List<CachCheBien> GetCachChebiens()
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
            try
            {
                _iDMFoodService.UpdateDMFood(cat);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateDetail(MonAnChiTiet food)
        {
            try
            {
                _iMonAnChiTietService.UpdateMonAnChiTiet(food);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateItem(ThucDon food)
        {
            try
            {
                _ithucDonService.UpdateThucDon(food);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateMethod(CachCheBien method)
        {
            try
            {
                _iCachChebienService.UpdateCachCheBien(method);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool UpdateUnit(DonVi unit)
        {
            try
            {
                _iDonViService.UpdateDonVi(unit);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        List<CachCheBien> iQLMenuService.GetCachCheBiens()
        {
            return _lstCachCheBien;
        }
    }
}
