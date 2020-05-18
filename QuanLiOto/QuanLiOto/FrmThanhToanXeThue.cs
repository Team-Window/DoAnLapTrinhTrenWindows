using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class FrmThanhToanXeThue : Form
    {
        public FrmThanhToanXeThue()
        {
            InitializeComponent();
        }
        QLThanhToanXeThue thanhtoanxethue = new QLThanhToanXeThue();
        QLThue qlthue = new QLThue();
        private void btn_KiemTraThanhToan_Click(object sender, EventArgs e)
        {
            float sotienphaitra = SoTienPhaiTra(dtp_NgayGiaoXe.Value, dtp_NgayHetHanThue.Value, dtp_NgayTraXe.Value, int.Parse(txb_TriGiaHD.Text));
            txb_SoTienPhaiTra.Text = sotienphaitra.ToString();
        }

        public float SoTienPhaiTra(DateTime ngaygiaoxe, DateTime ngayhethanthue, DateTime ngaytraxe, int trigiahopdong)
        {
            float SoTien;
            //Thuê xe <= 1 tuần
            if ((ngayhethanthue.Date - ngaygiaoxe.Date).TotalDays <= 7)
            {
                if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays == 0)
                {
                    SoTien = trigiahopdong;
                }
                else if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays == 1) // lấy trước 1 ngày
                {
                    SoTien = (float)0.8 * trigiahopdong;
                }
                else if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays > 1 && (ngayhethanthue - ngaytraxe).TotalDays <= 3)
                {
                    SoTien = (float)0.6 * trigiahopdong;
                }
                else
                {
                    SoTien = 0;
                }
            }
            else if ((ngayhethanthue.Date - ngaygiaoxe.Date).TotalDays <= 30) // Thuê xe 1 tháng
            {
                if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays == 0)
                {
                    SoTien = trigiahopdong;
                }
                else if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays <= 3)
                {
                    SoTien = (float)0.8 * trigiahopdong;
                }
                else if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays <= 7)
                {
                    SoTien = (float)0.6 * trigiahopdong;
                }
                else
                {
                    SoTien = 0;
                }
            }
            else if (((ngayhethanthue.Date - ngaygiaoxe.Date).TotalDays <= 120)) // thuê 1 quý
            {
                if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays == 0)
                {
                    SoTien = trigiahopdong;
                }
                else if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays <= 7)
                {
                    SoTien = (float)0.8 * trigiahopdong;
                }
                else if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays <= 15)
                {
                    SoTien = (float)0.6 * trigiahopdong;
                }
                else
                {
                    SoTien = 0;
                }
            }
            else
            {
                if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays == 0)
                {
                    SoTien = trigiahopdong;
                }
                else if ((ngayhethanthue.Date - ngaytraxe.Date).TotalDays <= 15)
                {
                    SoTien = (float)0.8 * trigiahopdong;
                }
                else if((ngayhethanthue.Date - ngaytraxe.Date).TotalDays <= 25)
                {
                    SoTien = (float)0.6 * trigiahopdong;
                }
                else
                {
                    SoTien = 0;
                }
            }
            return SoTien;
        }

        private void btn_TraXe_Click(object sender, EventArgs e)
        {
            if (txb_SoTienPhaiTra.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng kiểm tra thanh toán đã đúng hay chưa trước khi thanh toán", "FrmThanhToanXeThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fname = txb_FirstName.Text;
                string lname = txb_LastName.Text;
                string cmnd = txb_CMND.Text;
                string loaixe;
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
                MemoryStream pic = new MemoryStream();
                DateTime ngayhd = dtp_NgayHopDong.Value;
                int trigiahd = Convert.ToInt32(txb_TriGiaHD.Text);
                DateTime ngaygiaoxe = (DateTime)dtp_NgayGiaoXe.Value;
                DateTime ngayhethanthue = (DateTime)dtp_NgayHetHanThue.Value;
                DateTime ngaytraxe = (DateTime)dtp_NgayTraXe.Value;
                float sotienphaitra = (float)Convert.ToDouble(txb_SoTienPhaiTra.Text);
                ptb_Anh.Image.Save(pic, ptb_Anh.Image.RawFormat);
                int id = Convert.ToInt32(txb_ID.Text);
                if (thanhtoanxethue.insertThanhToanXeThue(fname, lname, cmnd, loaixe, bienso, pic, ngayhd, trigiahd, ngaygiaoxe, ngayhethanthue, ngaytraxe, sotienphaitra) ==true && qlthue.deleteXeThue(id) == true)
                {
                    MessageBox.Show("Thanh toán thành công", "FrmThanhToanXeThue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "FrmThanhToanXeThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
