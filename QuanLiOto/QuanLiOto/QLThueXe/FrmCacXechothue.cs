using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto.QLThueXe
{
    public partial class FrmCacXechothue : Form
    {
        public FrmCacXechothue()
        {
            InitializeComponent();
        }
        DateTime ngaygiaoxetruockhichon;
        DateTime ngaytraxetruockhichon;
        bool bientam = false;
        private void dtgv_Xechothue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string loaixe = dtgv_Xechothue.CurrentRow.Cells[0].Value.ToString();
            if (loaixe == "Xe đạp")
            {
                cb_LoaiXe.SelectedIndex = 0;
            }
            else if (loaixe == "Xe máy")
            {
                cb_LoaiXe.SelectedIndex = 1;
            }
            else
            {
                cb_LoaiXe.SelectedIndex = 2;
            }
            try
            {
                txb_HieuXe.Text = dtgv_Xechothue.CurrentRow.Cells[1].Value.ToString();
                txb_BienSo.Text = dtgv_Xechothue.CurrentRow.Cells[2].Value.ToString();
                byte[] pic = (byte[])dtgv_Xechothue.CurrentRow.Cells[3].Value;
                MemoryStream picture = new MemoryStream(pic);
                ptb_Anh.Image = Image.FromStream(picture);
                dtp_NgayHopDong.Value = (DateTime)dtgv_Xechothue.CurrentRow.Cells[4].Value;
                txb_TriGiaHD.Text = dtgv_Xechothue.CurrentRow.Cells[5].Value.ToString();
                dtp_NgayGiaoXe.Value = (DateTime)dtgv_Xechothue.CurrentRow.Cells[6].Value;
                dtp_NgayHetHanThue.Value = (DateTime)dtgv_Xechothue.CurrentRow.Cells[7].Value;
                ngaygiaoxetruockhichon = dtp_NgayGiaoXe.Value;
                ngaytraxetruockhichon = dtp_NgayHetHanThue.Value;
            }
            catch
            {

            }
            if (qLThue.XeThueExist(txb_BienSo.Text, "Thuê") == true)
            {
                
                MessageBox.Show("Xe đã được thuê", "Thuê xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Thuexe.Hide();
            }
            else
                btn_Thuexe.Show();
            if(dtgv_Xechothue.CurrentRow.Cells[6].Value.ToString()=="")
            {
                bientam = true;
            }    
        }
        QLThue qlthue = new QLThue();
        DateTime ngaygiaoxe;
        DateTime ngayhethanthue ;
        DateTime thoigianhientai = DateTime.Now;
        DateTime ngayhd;
        private void btn_Thuexe_Click(object sender, EventArgs e)
        {
            string fname = txb_FirstName.Text;
            string lname = txb_LastName.Text;
            string cmnd = txb_CMND.Text;
            string loaixe;
            string hieuxe = txb_HieuXe.Text;
            if (cb_LoaiXe.SelectedIndex == 0)
            {
                loaixe = "Xe đạp";
            }
            else if (cb_LoaiXe.SelectedIndex == 1)
            {
                loaixe = "Xe máy";
            }
            else
            {
                loaixe = "Xe hơi";
            }
            string bienso = txb_BienSo.Text;
            string loaihopdong = txb_GiayPhepXe.Text;

            MemoryStream pic = new MemoryStream();
            ngayhd = dtp_NgayHopDong.Value;
            int trigiahd = 0;
            if (txb_TriGiaHD.Text.Trim() != "")
                trigiahd = Convert.ToInt32(txb_TriGiaHD.Text);
            else
                MessageBox.Show("Vui lòng nhập giá trị hợp đồng", "Chưa có giá trị hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
             ngaygiaoxe = dtp_NgayGiaoXe.Value;
             ngayhethanthue = dtp_NgayHetHanThue.Value;

           
            if (verif(bientam))
            {
                ptb_Anh.Image.Save(pic, ptb_Anh.Image.RawFormat);
                if (qlthue.insertXeThue(fname, lname, cmnd, loaixe, hieuxe, bienso, loaihopdong, pic, ngayhd, trigiahd, ngaygiaoxe, ngayhethanthue))
                {
                    MessageBox.Show("Đã thêm thành công", "Xe Thuê Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Xe Thuê Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fileds", "Xe Thuê Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif(bool bientam)
        {
            if (bientam == false)
            {
                if ((ngaygiaoxe
                    < ngaygiaoxetruockhichon) || (ngaygiaoxe.Date > ngaytraxetruockhichon) || (ngaygiaoxe.Date < thoigianhientai))
                {

                    MessageBox.Show("Bạn vui lòng chọn ngày nhận xe sau " + ngaygiaoxetruockhichon.Date.ToString() + " và trước ngày " + ngaytraxetruockhichon.Date.ToString(), "Lỗi chọn ngày giao xe không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if ((ngayhethanthue > ngaytraxetruockhichon) || (ngayhethanthue <= ngaygiaoxetruockhichon))
                {
                    MessageBox.Show("Bạn vui lòng chọn ngày trả xe trước " + ngaytraxetruockhichon.Date.ToString() + " và sau ngày " + ngaygiaoxetruockhichon.Date.ToString(), "Lỗi chọn ngày hết hạn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                else if ((ngayhethanthue - ngaygiaoxe).TotalDays < 0)
                {
                    MessageBox.Show("Bạn vui lòng chọn ngày giao và trả xe " + ngaytraxetruockhichon.Date.ToString() + " và sau ngày " + ngaygiaoxetruockhichon.Date.ToString(), "Lỗi chọn ngày hết hạn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if(ngayhd<thoigianhientai)
                {
                    MessageBox.Show("Chọn ngày làm hợp đồng lại", "Lỗi chọn ngày hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }    
            }
            else
            {
                if (ngayhd < thoigianhientai)
                {
                    MessageBox.Show("Chọn ngày làm hợp đồng lại", "Lỗi chọn ngày ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if(ngaygiaoxe<thoigianhientai)
                {
                    MessageBox.Show("Chọn ngày giao xe lại", "Lỗi chọn ngày ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }    
                else if(ngayhethanthue<thoigianhientai)
                {
                    MessageBox.Show("Chọn ngày trả xe lại", "Lỗi chọn ngày ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }    
            }
            if ((txb_FirstName.Text.Trim() == "") || (txb_LastName.Text.Trim() == "") || (txb_CMND.Text.Trim() == "") || (ptb_Anh.Image == null) || (txb_HieuXe.Text.Trim() == "") || (txb_TriGiaHD.Text.Trim() == ""))
            {
                return false;
            }
            
            else if ((dtp_NgayHetHanThue.Value - dtp_NgayGiaoXe.Value).TotalDays < 0)
            {
                MessageBox.Show("Bạn đã chọn ngày trả xe và ngày nhận xe bất hợp lý", "Lỗi chọn ngày hết hạn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
            
        }
        QLThue qLThue = new QLThue();
        private void FrmCacXechothue_Load(object sender, EventArgs e)
        {
            dtgv_Xechothue.DataSource = qLThue.getXechothue("Cho thuê");
        }
        
    }
}
