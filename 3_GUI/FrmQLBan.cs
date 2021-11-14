using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.BUSServices;
using _2_BUS.iBUSServices;
using _1_DAL.Models;

namespace _3_GUI
{
    public partial class FrmQLBan : Form
    {
        IQLBanAnService _qlBanAn;
        List<BanAn> _lstBanAn;
        public FrmQLBan()
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _lstBanAn = new List<BanAn>();
            //_lstBanAn = _qlBanAn.GetTablesFromDB().Where(c => c.Status == true && c.Floor == 1);
            LoadTable();            
        }
        void LoadTable()
        {
            //List<BanAn> Bananlst = new List<BanAn>();
            //   Bananlst = (List<BanAn>)_qlBanAn.GetTablesFromDB().Where(c => c.Status == true && c.Floor == 1);
            //foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Status == true && c.Floor == 1))
            //{               
            //    Button btn = new Button() { Width = x.Rong, Height = x.Cao };
            //    btn.Text = x.Name + Environment.NewLine + x.TinhTrang;
            //    switch (x.TinhTrang)
            //    {
            //        case 1:
            //            btn.BackColor = Color.Aqua;
            //            break;
            //        default:
            //            btn.BackColor = Color.LightPink;
            //            break;
            //    }
            //    Tp_Tang1.Controls.Add(btn);
            //}
            //for (int i = 1; i < _qlBanAn.GetTablesFromDB().Where(c => c.Status == true && c.Floor == 1).Count(); i++)
            //{
            //    Button btn = new Button() { Width = 50, Height = 50 };
            //    btn.Text = _qlBanAn.GetTablesFromDB().Where(c => c.Status == true && c.Floor == 1)[i].Name + Environment.NewLine + _lstBanAn[i].TinhTrang;
            //    switch (_lstBanAn[i].TinhTrang)
            //    {
            //        case 1:
            //            btn.BackColor = Color.Aqua;
            //            break;
            //        default:
            //            btn.BackColor = Color.LightPink;
            //            break;
            //    }
            //    Tp_Tang1.Controls.Add(btn);
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }
    }
}
