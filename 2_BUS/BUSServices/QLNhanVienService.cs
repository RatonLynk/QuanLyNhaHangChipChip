using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DALServices;
using _1_DAL.iDALServices;

namespace _2_BUS.BUSServices
{
    public class QLNhanVienService : IQLNhanVienService
    {
        private INhanVienService _iNhanVienService;
        private List<NhanVien> _getLstNhanViens;
        public static bool _startSave = true;

        public QLNhanVienService()
        {
            _iNhanVienService = new NhanVienService();
            getLstNhanViens();
        }
        public string Add(NhanVien nhanVien)
        {
            _startSave = false;
            _getLstNhanViens.Add(nhanVien);
            return _iNhanVienService.AddNV(nhanVien);
        }

        public string Delete(NhanVien nhanVien)
        {
            _startSave = false;
            var index = _getLstNhanViens.FindIndex(c => c == nhanVien);
            _getLstNhanViens[index] = nhanVien;
            return _iNhanVienService.EditNV(nhanVien);
        }

        public void getLstNhanViens()
        {
            _getLstNhanViens = _iNhanVienService.GetLstNVfromDB();
        }

        public List<NhanVien> lstNhanViens()
        {
            return _getLstNhanViens;
        }

        //public string Save()
        //{
        //    foreach (var x in _getLstNhanViens.Where(c => c.startsSave == 0))
        //    {

        //        x.startsSave = 1;
        //        _iNhanVienService.AddNV(x);

        //    }
        //    startsSave = true;
        //    return _iNhanVienService.Save();
        //}

        public List<NhanVien> searchNhanViens(string nv)
        {
            return _getLstNhanViens.Where(c => c.Name.StartsWith(nv)).ToList();
        }

        public string Update(NhanVien nhanVien)
        {
            _startSave = false;
            var index = _getLstNhanViens.FindIndex(c => c == nhanVien);
            _getLstNhanViens[index] = nhanVien;
            return _iNhanVienService.EditNV(nhanVien);
        }

        public string Save()
        {
            throw new NotImplementedException();
        }
    }
}
