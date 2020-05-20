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
    public partial class FrmDangKyLichLamViec : Form
    {
        public FrmDangKyLichLamViec()
        {
            InitializeComponent();
        }
        dangkylichlamviec dklichlamviec = new dangkylichlamviec();
        login log = new login();
        private void lbl_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng lập lịch", "Đăng ký lịch làm việc. Vui lòng chọn đối tượng ở bảng phải.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int iduser = Convert.ToInt32(txb_ID.Text);
            string fname = txb_FirstName.Text;
            string lname = txb_LastName.Text;
            DateTime ngaydk = dtp_NgayDK.Value;
            int ca;
            if (cb_Ca.SelectedIndex == 0)
            {
                ca = 1;

            }
            else if (cb_Ca.SelectedIndex == 1)
            {
                ca = 2;
            }
            else
            {
                ca = 3;
            }
            if (cb_Ca.SelectedIndex == null)
            {
                MessageBox.Show("Bạn chưa chọn ca", "Đăng ký lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dklichlamviec.insertLichLamViec(iduser, fname, lname, ngaydk, ca))
                {
                    MessageBox.Show("Đăng ký thành công", "Đăng ký lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công", "Đăng ký lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void FrmDangKyLichLamViec_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE chucvu = 'Nhân viên'");
            DataTable table = log.getUser(command);
            dtgv_DKLichLamViec.DataSource = table;
        }

        private void dtgv_DKLichLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_ID.Text = dtgv_DKLichLamViec.CurrentRow.Cells[0].ToString();
            txb_FirstName.Text = dtgv_DKLichLamViec.CurrentRow.Cells[1].ToString();
            txb_LastName.Text = dtgv_DKLichLamViec.CurrentRow.Cells[2].ToString();

        }
    }
}
