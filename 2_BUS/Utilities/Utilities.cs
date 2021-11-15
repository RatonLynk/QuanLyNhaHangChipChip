using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using _1_DAL.DALServices;
using _2_BUS.iBUSServices;
using _2_BUS.Models;

namespace _2_BUS.Utilities
{
    public class Utilities
    {
        private iMonAnChiTietService _iMonAnChiTietService;
        private iDonViService _iDonViService;
        private iCachChebienService _iCachChebienService;
        private IThucDonService _iThucDonService;
        private iDMFoodService _iDMFoodService;
        private DonVi _donVi;
        private DanhMucFood _dmFood;
        private CachCheBien _cachCB;
        private MonAnChiTiet _item;
        //public static bool CheckListEmpty(List<T> list)
        //{
        //    if (list is null){
        //        return true;
        //    }
        //    return false;
        //}

        public int GetMethodID(string Name)
        {
            _cachCB = _iCachChebienService.GetMethodsFromDB().Where(c => c.Name == Name).FirstOrDefault();
            return _cachCB.Id;
        }
        public int GetCategoryID(string Name)
        {
            _dmFood = _iDMFoodService.GetCategoriesFromDB().Where(c => c.Name == Name).FirstOrDefault();
            return _dmFood.Id;
        }
        public int GetDonViID(string Name)
        {
            _donVi = _iDonViService.GetUnitsFromDB().Where(c => c.Name == Name).FirstOrDefault();
            return _donVi.Id;
        }
        public  string GetHash(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

    }
}
