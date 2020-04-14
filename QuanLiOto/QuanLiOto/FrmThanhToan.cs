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
    public partial class FrmThanhToan : Form
    {
        // quy định giá vé xe đạp=2000, xe máy=5000, xe oto=10000
        public FrmThanhToan()
        {
            InitializeComponent();
        }
        GuiXe thongke = new GuiXe();
        int SoTienPhaiTra = 0;
        private void bt_CheckOut_Click(object sender, EventArgs e)
        {
           
            dtp_Gioraben.Value = DateTime.Now;
            dtp_ngayraben.Value = DateTime.Now.Date;
            dtp_Gioraben.Visible = true;
            dtp_ngayraben.Visible = true;
            int giave = 0;
            
            if(lb_ValueLoaiXe.Text=="xe đạp")
            {
                giave = 2000;
                SoTienPhaiTra=Thanhtoan(lb_ValueLoaiVe.Text, dtp_GioVaoBen.Value, dtp_Gioraben.Value, dtp_NgayVaoBen.Value, dtp_ngayraben.Value, giave);
            }   
            else if(lb_ValueLoaiXe.Text=="xe máy")
            {
                giave = 5000;
                SoTienPhaiTra = Thanhtoan(lb_ValueLoaiVe.Text, dtp_GioVaoBen.Value, dtp_Gioraben.Value, dtp_NgayVaoBen.Value, dtp_ngayraben.Value, giave);
            }   
            else
            {
                giave = 10000;
                SoTienPhaiTra = Thanhtoan(lb_ValueLoaiVe.Text, dtp_GioVaoBen.Value, dtp_Gioraben.Value, dtp_NgayVaoBen.Value, dtp_ngayraben.Value, giave);
            }
            
           
        }
         public int Thanhtoan(string loaive, DateTime giovaoben,DateTime gioraben, DateTime ngayvaoben, DateTime ngayraben, int giave )
        {
            int SoTienPhaiTra=0;
            
                TimeSpan Songaygiuaxe = ngayraben - ngayvaoben;
                int tongsongay = Songaygiuaxe.Days;
            TimeSpan Sogiogiuxe = gioraben - giovaoben;
            int tongsogio = Sogiogiuxe.Hours;
            if(loaive=="Vé giờ")
            {
                if(tongsogio==0)
                {
                    SoTienPhaiTra = giave;
                }    
                if(tongsogio<0)
                {
                    tongsogio = 24 - tongsogio;
                }    
                if (tongsogio > 24)
                    SoTienPhaiTra += giave * 16;
                else
                    SoTienPhaiTra = tongsogio * giave;
            }    
            else if(loaive=="Vé tuần")
            {
                SoTienPhaiTra = 24 * giave;
                if((tongsongay>10)&&(tongsongay<30))
                {
                    SoTienPhaiTra += 48 * giave;
                }    

            }   
            else if(loaive=="Vé ngày")
            {
                SoTienPhaiTra = 8 * giave;
                if (tongsongay > 1)
                    SoTienPhaiTra += 24 * giave;

            }    
            else
            {
                SoTienPhaiTra = 48 * giave;

            }    
            txt_ThanhTien.Text = SoTienPhaiTra.ToString();
            //txt_ThanhTien.Text = tongsogio.ToString();
            return SoTienPhaiTra;  
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
           
                int mave = int.Parse(lb_ValueMaVe.Text);
                MemoryStream hinhanh = new MemoryStream();
                ptb_HinhAnh.Image.Save(hinhanh, ptb_HinhAnh.Image.RawFormat);
                TimeSpan giovaoben1 = dtp_GioVaoBen.Value.TimeOfDay;
                TimeSpan gioraben1 = dtp_Gioraben.Value.TimeOfDay;
                if (thongke.InsertThongKe(mave, lb_ValueBienSo.Text, lb_ValueLoaiXe.Text, lb_ValueHieuXe.Text, hinhanh, giovaoben1, dtp_NgayVaoBen.Value, lb_ValueLoaiVe.Text, gioraben1, dtp_ngayraben.Value, SoTienPhaiTra))
                {
                    MessageBox.Show("Đã thanh toán thành công", "Add Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if ((MessageBox.Show("Are Yousure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                thongke.DeleteGuiXe(mave);
        }
    }
}
