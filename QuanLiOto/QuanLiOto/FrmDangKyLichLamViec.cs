using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void lbl_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
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
    }
}
