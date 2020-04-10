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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        Color colorTongSoLuongPhuongTien;
        Color colorXeDap;
        Color colorXeMay;
        Color colorXeHoi;

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            GuiXe guixe = new GuiXe();
            double tong = Convert.ToDouble(guixe.tongSoLuongPhuongTien());
            double slXeDap = Convert.ToDouble(guixe.SoLuongXeMay());
            double slXeHoi = Convert.ToDouble(guixe.SoLuongXeHoi());
        }
    }
}
