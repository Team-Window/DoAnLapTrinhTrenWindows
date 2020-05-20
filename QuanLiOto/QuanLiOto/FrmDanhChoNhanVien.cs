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
    // Sửa ở đây
    public partial class FrmDanhChoNhanVien : Form
    {
        public FrmDanhChoNhanVien()
        {
            InitializeComponent();
        }
        login log = new login();
        //QLLuongThuong luongthuong = new QLLuongThuong();
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show(this);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra", "Log Out Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ChamCong chamcong = new ChamCong();
                DateTime giotanlam = DateTime.Now;
                chamcong.insertBangChamCong(Globals.GlobalUserId, Globals.GlobalUserGioVaoLam, giotanlam);
                DataTable table = log.getUserByID(Globals.GlobalUserId);
                TimeSpan tinhgiovaolam = Globals.GlobalUserGioVaoLam.TimeOfDay;
                TimeSpan tinhgiotanlam = giotanlam.TimeOfDay;
                float tongsogiolam = (float)(tinhgiotanlam - tinhgiovaolam).TotalHours;
                int tienluong = TinhTienLuongNhanVien(tongsogiolam);
                //luongthuong.insertQLLuongThuong(Globals.GlobalUserId, table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), DateTime.Now.Date, tongsogiolam, tienluong);
                this.Close();
            }
        }

        public int TinhTienLuongNhanVien(float sogiolamviec)
        {
            int tienluong;
            tienluong = (int)sogiolamviec * 50000;
            return tienluong;
        }
    }
}
