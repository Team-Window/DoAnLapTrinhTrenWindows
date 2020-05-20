using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class FrmThemDSThue : Form
    {
        public FrmThemDSThue()
        {
            InitializeComponent();
        }
        QLThue qlthue = new QLThue();
        private void btn_Them_Click(object sender, EventArgs e)
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
            string loaihopdong;
            if (cb_loaihopdong.SelectedIndex == 0)
            {
                loaihopdong = "Thuê";
            }
            else
            {
                loaihopdong = "Cho thuê";
            }
            MemoryStream pic = new MemoryStream();
            DateTime ngayhd = dtp_NgayHopDong.Value;
            int trigiahd = Convert.ToInt32(txb_TriGiaHD.Text);
            DateTime ngaygiaoxe = dtp_NgayGiaoXe.Value;
            DateTime ngayhethanthue = dtp_NgayHetHanThue.Value;
            if(verif())
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

        bool verif()
        {
            if ((txb_FirstName.Text.Trim() == "") || (txb_LastName.Text.Trim() == "") || (txb_CMND.Text.Trim() == "") || (ptb_Anh.Image == null) || (txb_HieuXe.Text.Trim() == "") || (txb_TriGiaHD.Text.Trim() == ""))
            {
                return false;
            }
            else if ((cb_LoaiXe.SelectedIndex == 1 && txb_BienSo.Text.Trim() == "") || (cb_LoaiXe.SelectedIndex == 1 && cb_loaihopdong.Text =="") || (cb_LoaiXe.SelectedIndex == 2 && cb_loaihopdong.Text == "") ||(cb_LoaiXe.SelectedIndex == 2 && txb_BienSo.Text.Trim() == ""))
            {
                MessageBox.Show("Nếu là xe máy hoặc xe hơi thì phải nhập biển số và giấy phép xe");
                return false;
            }
            else if ((dtp_NgayHetHanThue.Value - dtp_NgayGiaoXe.Value).TotalDays < 7)
            {
                MessageBox.Show("Xe được thuê phải nhiều hơn 7 ngày", "Xe Thuê Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Seclect Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                ptb_Anh.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Xe_" + txb_HieuXe.Text + "_" + txb_BienSo.Text);
            if ((ptb_Anh.Image == null))
            {
                MessageBox.Show("Không có hình ảnh");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                ptb_Anh.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
