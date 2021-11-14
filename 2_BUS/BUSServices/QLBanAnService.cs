using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using _1_DAL.DALServices;
using _1_DAL.iDALServices;
using _2_BUS.iBUSServices;

namespace _2_BUS.BUSServices
{
    public class QLBanAnService : IQLBanAnService
    {
        iBanAnService _Ba;
        iFloorService _F;
        public QLBanAnService()
        {
            _Ba = new BanAnService();
            _F = new FloorService();
        }
        public string AddBanAn(BanAn BanAn)
        {
            return _Ba.AddBanAn(BanAn);
        }

        public string AddFloor(Floor Floor)
        {
            return _F.AddFloor(Floor);
        }

        public string DeleteBanAn(BanAn BanAn)
        {
            return _Ba.DeleteBanAn(BanAn);
        }

        public string DeleteFloor(Floor Floor)
        {
            return _F.DeleteFloor(Floor);
        }

        public List<Floor> GetFloorsFromDB()
        {
            return _F.GetFloorsFromDB();
        }

        public List<BanAn> GetTablesFromDB()
        {
            return _Ba.GetTablesFromDB();
        }

        public List<BanAn> LoadBanlist()
        {
            List<BanAn> bananlist = new List<BanAn>();
            //foreach ( item in collection)
            //{

            //}
            return bananlist;
        }

        public string UpdateBanAn(BanAn BanAn)
        {
            return _Ba.UpdateBanAn(BanAn);
        }

        public string UpdateFloor(Floor Floor)
        {
            return _F.UpdateFloor(Floor);
        }
    }
}
