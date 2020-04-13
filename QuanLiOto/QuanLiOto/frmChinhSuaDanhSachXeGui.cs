using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class frmChinhSuaDanhSachXeGui : Form
    {
        public frmChinhSuaDanhSachXeGui()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            GuiXe guixe = new GuiXe();
            int mave = int.Parse(txb_MaVe.Text);
            SqlCommand command = new SqlCommand("SELECT mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben, loaive FROM GuiXe WHERE mave= " + mave);
            DataTable table = guixe.getGuiXe(command);
            if (table.Rows.Count > 0)
            {
                txb_BienSo.Text = table.Rows[0]["bienso"].ToString();
                if (table.Rows[0]["loaixe"].ToString() == "Xe dap")
                    cb_LoaiXe.SelectedIndex = 0;
                else if (table.Rows[0]["loaixe"].ToString() == "Xe may")
                    cb_LoaiXe.SelectedIndex = 1;
                else
                    cb_LoaiXe.SelectedIndex = 2;
                    txb_HieuXe.Text = table.Rows[0]["hieuxe"].ToString();
                byte[] pic = (byte[])table.Rows[0]["hinhanh"];
                MemoryStream picture = new MemoryStream(pic);
                ptb_HinhAnh.Image = Image.FromStream(picture);
                dtp_GioVaoBen.Value = Convert.ToDateTime(table.Rows[0]["giovaoben"].ToString());
                dtp_NgayVaoBen.Value = (DateTime)table.Rows[0]["ngayvaoben"];
                if (table.Rows[0]["loaive"].ToString() == "Ve gio")
                    cb_LoaiVe.SelectedIndex = 0;
                else if (table.Rows[0]["loaive"].ToString() == "Ve ngay")
                    cb_LoaiVe.SelectedIndex = 1;
                else if (table.Rows[0]["loaive"].ToString() == "Ve tuan")
                    cb_LoaiVe.SelectedIndex = 2;
                else
                    cb_LoaiVe.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Chỉnh sửa danh sách gửi xe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            GuiXe guixe = new GuiXe();
            int mave;
            string bienso = txb_BienSo.Text;
            string loaixe;
            string hieuxe = txb_HieuXe.Text;
            MemoryStream hinhanh = new MemoryStream();
            if (cb_LoaiXe.SelectedIndex == 0)
            {
                loaixe = "Xe dap";
            }
            else if (cb_LoaiXe.SelectedIndex == 1)
            {
                loaixe = "Xe may";
            }
            else
            {
                loaixe = "Xe hoi";
            }
            TimeSpan giovaoben = dtp_GioVaoBen.Value.TimeOfDay;
            DateTime ngayvaoben = dtp_NgayVaoBen.Value.Date;
            string loaive;
            if (cb_LoaiVe.SelectedIndex == 0)
            {
                loaive = "Ve gio";
            }
            else if (cb_LoaiVe.SelectedIndex == 1)
            {
                loaive = "Ve ngay";
            }
            else if (cb_LoaiVe.SelectedIndex == 2)
            {
                loaive = "Ve tuan";
            }
            else
            {
                loaive = "Ve thang";
            }
            if (verif())
            {
                try
                {
                    mave = Convert.ToInt32(txb_MaVe.Text);
                    ptb_HinhAnh.Image.Save(hinhanh, ptb_HinhAnh.Image.RawFormat);
                    if (guixe.UpdateGuiXe(mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben,loaive))
                    {
                        MessageBox.Show("Đã chỉnh sửa thành công", "Add GuiXe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add GuiXe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Chỉnh sửa danh sách gửi xe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu trống", "Chỉnh sửa danh sách gửi xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool verif()
            {
                if (txb_MaVe.Text.Trim() == "" || txb_HieuXe.Text.Trim() == "" || ptb_HinhAnh.Image == null)
                    return false;
                else if ((cb_LoaiXe.SelectedIndex == 1 && txb_BienSo.Text.Trim() == "") || (cb_LoaiXe.SelectedIndex == 2 && txb_BienSo.Text.Trim() == ""))
                {
                    MessageBox.Show("Neu la xe may hoac xe hoi thi phai nhap bien so vao");
                    return false;
                }
                else if (cb_LoaiVe.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn loại vé");
                    return false;
                }
                else
                    return true;
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Seclect Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                ptb_HinhAnh.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Xe_" + txb_HieuXe.Text + "_" + txb_BienSo.Text);
            if ((ptb_HinhAnh.Image == null))
            {
                MessageBox.Show("Không có hình ảnh");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                ptb_HinhAnh.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            GuiXe guixe = new GuiXe();
            int mave = int.Parse(txb_MaVe.Text);
            if ((MessageBox.Show("Bạn có muốn xóa đối tượng này không?", "Xóa danh sách xe gửi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    if (guixe.DeleteGuiXe(mave))
                    {
                        MessageBox.Show("Xóa thành công", "Xóa danh sách xe gửi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txb_MaVe.Text = "";
                        txb_BienSo.Text = "";
                        cb_LoaiXe.Text = "";
                        txb_HieuXe.Text = "";
                        ptb_HinhAnh.Image = null;
                        dtp_GioVaoBen.Value = DateTime.Now;
                        dtp_NgayVaoBen.Value = DateTime.Now;
                        cb_LoaiVe.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Xóa danh sách xe gửi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn hãy nhập mã vé vào", "Xóa danh sách xe gửi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtThanhToan_Click(object sender, EventArgs e)
        {
            /*
            FrmThanhToan frmThanhToan = new FrmThanhToan();
            frmThanhToan.lb_ValueMaVe.Text = txb_MaVe.Text;
            frmThanhToan.lb_ValueBienSo.Text = txb_BienSo.Text;
            frmThanhToan.lb_ValueHieuXe.Text = txb_HieuXe.Text;
            frmThanhToan.lb_ValueLoaiVe.Text = cb_LoaiVe.Text;
            frmThanhToan.lb_ValueLoaiXe.Text = cb_LoaiXe.Text;
            //byte[] pic = (byte[])table.Rows[0]["hinhanh"];
            //MemoryStream picture = new MemoryStream(pic);
            ptb_HinhAnh.Image = Image.FromStream(picture);
            //  MemoryStream hinhanh = new MemoryStream();
            /// ptb_HinhAnh.Image.Save(frmThanhToan.ptb_HinhAnh, ptb_HinhAnh.Image.RawFormat);
            //frmThanhToan.ptb_HinhAnh.Image = hinhanh;
            frmThanhToan.dtp_GioVaoBen.Value = dtp_GioVaoBen.Value;
            frmThanhToan.dtp_NgayVaoBen.Value = dtp_NgayVaoBen.Value;
            frmThanhToan.ShowDialog(this);
            */
            FrmThanhToan frmThanhToan = new FrmThanhToan();
            GuiXe guixe = new GuiXe();
            int mave = int.Parse(txb_MaVe.Text);
            SqlCommand command = new SqlCommand("SELECT mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben, loaive FROM GuiXe WHERE mave= " + mave);
            DataTable table = guixe.getGuiXe(command);
            if (table.Rows.Count > 0)
            {
                frmThanhToan.lb_ValueMaVe.Text = txb_MaVe.Text;
                frmThanhToan.lb_ValueBienSo.Text = table.Rows[0]["bienso"].ToString();
                if (table.Rows[0]["loaixe"].ToString() == "Xe dap")
                    frmThanhToan.lb_ValueLoaiXe.Text = "Xe đạp";
                else if (table.Rows[0]["loaixe"].ToString() == "Xe may")
                    frmThanhToan.lb_ValueLoaiXe.Text="Xe máy";
                else
                    frmThanhToan.lb_ValueLoaiXe.Text="Xe hơi";
                frmThanhToan.lb_ValueHieuXe.Text = table.Rows[0]["hieuxe"].ToString();
                byte[] pic = (byte[])table.Rows[0]["hinhanh"];
                MemoryStream picture = new MemoryStream(pic);
                frmThanhToan.ptb_HinhAnh.Image = Image.FromStream(picture);
                frmThanhToan.dtp_GioVaoBen.Value = Convert.ToDateTime(table.Rows[0]["giovaoben"].ToString());
                frmThanhToan.dtp_NgayVaoBen.Value = (DateTime)table.Rows[0]["ngayvaoben"];
                if (table.Rows[0]["loaive"].ToString() == "Ve gio")
                    frmThanhToan.lb_ValueLoaiVe.Text="Vé giờ";
                else if (table.Rows[0]["loaive"].ToString() == "Ve ngay")
                    frmThanhToan.lb_ValueLoaiVe.Text="Vé ngày";
                else if(table.Rows[0]["loaive"].ToString() == "Ve tuan")
                    frmThanhToan.lb_ValueLoaiVe.Text = "Vé tuần";
                else
                    frmThanhToan.lb_ValueLoaiVe.Text="Vé tháng";
                frmThanhToan.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Form Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
