﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _1_DAL.iDALServices
{
    public interface iBanAnService
    {
        public string AddBanAn(BanAn BanAn);
        public string UpdateBanAn(BanAn BanAn);
        public string DeleteBanAn(BanAn BanAn);
        public string SaveBanAn();
        public List<BanAn> GetTablesFromDB();
    }
}