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

namespace QuanLiOto.QLThueXe
{
    public partial class FrmXecuaCongTy : Form
    {
        public FrmXecuaCongTy()
        {
            InitializeComponent();
        }
        QLThue qlthue = new QLThue();
        private void btn_Them_Click(object sender, EventArgs e)
        {
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
            string loaihopdong="";
            if (cb_loaihopdong.SelectedIndex == 0)
            {
                loaihopdong = "Công ty";
            }

            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                ptb_Anh.Image.Save(pic, ptb_Anh.Image.RawFormat);
                if(qlthue.insertXeCongTy(loaixe,hieuxe,bienso,loaihopdong,pic))
                {
                    MessageBox.Show("Đã thêm thành công", "Xe Thuê Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Xe Thuê Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
        }
        bool verif()
        {
            if (cb_LoaiXe.Text.Trim() == "" || (cb_loaihopdong.Text.Trim() == "") || (txb_BienSo.Text.Trim() == "") || (txb_BienSo.Text.Trim() == ""))
                return false;
            else
                return true;
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
    }
}
