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
    public partial class FrmBangPhanCong : Form
    {
        public FrmBangPhanCong()
        {
            InitializeComponent();
        }
        dangkylichlamviec lichlamviec = new dangkylichlamviec();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            FrmDangKyLichLamViec dangkylichlamviec = new FrmDangKyLichLamViec();
            dangkylichlamviec.Show(this);
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng để chỉnh sửa. Vui lòng chọn ở bảng kế bên", "FrmBangPhanCong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

                if (lichlamviec.updateLichLamViec(iduser, fname, lname, ngaydk, ca))
                {
                    MessageBox.Show("Cập nhật thành công", "Lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DateTime ngaydk = dtp_NgayDK.Value;
            int iduser = Convert.ToInt32(txb_ID.Text);
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng xóa. Vui lòng chọn ở bảng kế", "Lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa đối tượng này", "Lịch làm việc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (lichlamviec.deleteLichLamViec(iduser, ngaydk))
                    {
                        MessageBox.Show("Xóa thành công", "Lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Lịch làm việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dkcongviec");
            lichlamviec.getLichLamViec(command);
        }

        private void FrmBangPhanCong_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dkcongviec");
            lichlamviec.getLichLamViec(command);
        }
    }
}
