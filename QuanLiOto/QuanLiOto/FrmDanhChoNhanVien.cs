using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class FrmDanhChoNhanVien : Form
    {
        public FrmDanhChoNhanVien()
        {
            InitializeComponent();
        }
        login log = new login();
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            DataTable table = log.getUserByID(Globals.GlobalUserId);
            FrmDangKyLichLamViec dangkylichlamviec = new FrmDangKyLichLamViec();
            dangkylichlamviec.txb_ID.Text = Globals.GlobalUserId.ToString();
            dangkylichlamviec.txb_FirstName.Text = table.Rows[0][1].ToString();
            dangkylichlamviec.txb_LastName.Text = table.Rows[0][2].ToString();
            dangkylichlamviec.Show(this);

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra", "Log Out Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ChamCong chamcong = new ChamCong();
                DateTime giotanlam = DateTime.Now;
                chamcong.insertBangChamCong(Globals.GlobalUserId, Globals.GlobalUserGioVaoLam, giotanlam);
                this.Close();
            }
        }
    }
}
