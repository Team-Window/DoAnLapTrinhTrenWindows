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
    public partial class FrmThanhToanLuong : Form
    {
        public FrmThanhToanLuong()
        {
            InitializeComponent();
        }
        QLLuongThuong luongthuong = new QLLuongThuong();
        QLPhieuThanhToan phieuthanhtoan = new QLPhieuThanhToan();
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThanhToanLuong_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT iduser, fname, lname, ngaylamviec, SUM(luong) as luong FROM thanhtoanluong GROUP BY iduser, fname, lname, ngaylamviec");
            DataTable table = luongthuong.getQLLuongThuong(command);
            dtgv_ThanhToanLuong.DataSource = table;
        }

        private void dtgv_ThanhToanLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_ID.Text = dtgv_ThanhToanLuong.CurrentRow.Cells[0].ToString();
            txb_FirstName.Text = dtgv_ThanhToanLuong.CurrentRow.Cells[1].ToString();
            txb_LastName.Text = dtgv_ThanhToanLuong.CurrentRow.Cells[2].ToString();
            dtp_NgayLamViec.Value = (DateTime)dtgv_ThanhToanLuong.CurrentRow.Cells[3].Value;
            txb_Luong.Text = dtgv_ThanhToanLuong.CurrentRow.Cells[4].ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng thanh toán. Vui lòng chọn đối tượng ở bản bên phải", "Thanh toán lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int iduser = Convert.ToInt32(txb_ID.Text);
                string fname = txb_FirstName.Text;
                string lname = txb_LastName.Text;
                DateTime ngaylamviec = dtp_NgayLamViec.Value;
                int luong = Convert.ToInt32(txb_Luong.Text);
                if (phieuthanhtoan.insertPhieuThanhToan(iduser, fname, lname, ngaylamviec, luong))
                {
                    luongthuong.deleteQLLuongThuong(iduser, ngaylamviec);
                    MessageBox.Show("Xuất phiếu thanh toán thành công", "Phiếu thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Phiếu thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
