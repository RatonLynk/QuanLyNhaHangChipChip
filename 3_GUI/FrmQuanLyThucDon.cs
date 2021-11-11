using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;



namespace _3_GUI
{
    public partial class FrmQuanLyThucDon : Form
    {
       

        public FrmQuanLyThucDon()
        {
            //MaximizeBox = false;
            InitializeComponent();
        }

        private void FrmQuanLyThucDon_Load(object sender, EventArgs e)
        {
            //btnXoaNhom.Enabled = false;//an button
            //btnSuaNhom.Enabled = false;

            //btnSuaMon.Enabled = false;
            //btnXoaMon.Enabled = false;

            //btnXoaCongThuc.Enabled = false;

            //lblMaMonAn.Enabled = false;
            //lblMaNguyenLieu.Enabled = false;
            //this.dgvCongThuc.ClearSelection();//ClearSelection() : Xoa focus khi hien datagridview
            //this.dgvDanhMuc.ClearSelection();
            //this.dgvMonAn.ClearSelection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
