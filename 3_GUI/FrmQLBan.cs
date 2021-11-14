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
        public FrmQLBan()
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            LoadTable();
            
        }
        void LoadTable()
        {
            foreach (BanAn x in _qlBanAn.GetTablesFromDB())
            {
                Button btn = new Button() { Width = 50, Height = 50 };
                Tp_Tang1.Controls.Add(btn);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }
    }
}
