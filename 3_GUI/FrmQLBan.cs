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
using _2_BUS.Models;

namespace _3_GUI
{
    public partial class FrmQLBan : Form
    {
        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        iQLMenuService _qlMeniu;
        List<BanAn> _lstBanAn;
        public FrmQLBan()
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _lstBanAn = new List<BanAn>();
            _qlHoaDon = new QLHoaDon();
            _qlMeniu = new QLMenuService();
            _lstBanAn = _qlBanAn.GetTablesFromDB();
            LoadTable();
            //LoadHoaDon();
            //LoadMeniu();
        }
        void LoadTable()
        {
            foreach (BanAn x in _lstBanAn.Where(c => c.Floor == 1))
            {
                Button btn = new Button() { Width = x.Rong, Height = x.Cao };
                btn.Text = x.Name + Environment.NewLine + (x.TinhTrang == 1 ? "Trống" : "Có người");
                switch (x.TinhTrang)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                FLPenal.Controls.Add(btn);
            }
            //â
        }
        void LoadMeniu()
        {
            DataGridViewButtonColumn Them = new DataGridViewButtonColumn();
            Them.Name = "Them";
            Them.HeaderText = "Thêm món";
            Them.UseColumnTextForButtonValue = true;
            Them.Text = "Thêm";

            Dgid_Meniu.ColumnCount = 6;
            Dgid_Meniu.Columns[0].Name = "Tên món";
            Dgid_Meniu.Columns[1].Name = "ád";
            Dgid_Meniu.Columns[2].Name = "ádfd";
            Dgid_Meniu.Columns[3].Name = "sgdgh";
            Dgid_Meniu.Columns[4].Name = "dhjfg";
            Dgid_Meniu.Columns[5].Name = "dhjfg";
            Dgid_Meniu.Columns.Add(Them);
            foreach (var x in _qlMeniu.GetViewMenus())
            {
                Dgid_Meniu.Rows.Add();
            }

        }
        void LoadHoaDon()
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmThemBan frmThemBan = new FrmThemBan();
            frmThemBan.Show();
        }
    }
}
