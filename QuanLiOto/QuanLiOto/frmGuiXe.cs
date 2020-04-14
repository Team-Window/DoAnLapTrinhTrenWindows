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
    public partial class frmGuiXe : Form
    {
        public frmGuiXe()
        {
            InitializeComponent();
        }
        GuiXe guixe = new GuiXe();
        public void fillGrid(SqlCommand command)
        {
            dtgv_XeGui.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgv_XeGui.RowTemplate.Height = 80;
            dtgv_XeGui.DataSource = guixe.getGuiXe(command);
            picCol = (DataGridViewImageColumn)dtgv_XeGui.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv_XeGui.AllowUserToAddRows = false;
        }
        private void frmGuiXe_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM GuiXe"));
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM GuiXe WHERE CONCAT(mave,bienso) LIKE '%" + txb_Search.Text + "%'");
            fillGrid(command);
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

        private void btn_VaoBen_Click(object sender, EventArgs e)
        {
            GuiXe guixe = new GuiXe();
            int mave = Convert.ToInt32(txb_MaVe.Text);
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
            TimeSpan giovaoben = DateTime.Now.TimeOfDay;
            DateTime ngayvaoben = DateTime.Now.Date;
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
                if (!guixe.maveExist(mave))
                {
                    ptb_HinhAnh.Image.Save(hinhanh, ptb_HinhAnh.Image.RawFormat);
                    if (guixe.InsertGuiXe(mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben, loaive))
                    {
                        MessageBox.Show("Đã thêm thành công", "Add GuiXe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add GuiXe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vé tồn tại", "Add GuiXe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                    MessageBox.Show("Vui lòng chọn loại vé ");
                    return false;
                }
                else
                    return true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM GuiXe");
            fillGrid(command);
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Xe_"+txb_HieuXe.Text+ "_" + txb_BienSo.Text);
            if ((ptb_HinhAnh.Image == null))
            {
                MessageBox.Show("Không có hình ảnh");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                ptb_HinhAnh.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void dtgv_XeGui_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChinhSuaDanhSachXeGui frmChinhSua = new frmChinhSuaDanhSachXeGui();
            frmChinhSua.txb_MaVe.Text = dtgv_XeGui.CurrentRow.Cells[0].Value.ToString();
            frmChinhSua.txb_BienSo.Text = dtgv_XeGui.CurrentRow.Cells[1].Value.ToString();
            if (dtgv_XeGui.CurrentRow.Cells[2].Value.ToString() == "Xe dap")
                frmChinhSua.cb_LoaiXe.SelectedIndex = 0;
            else if (dtgv_XeGui.CurrentRow.Cells[2].Value.ToString() == "Xe may")
                frmChinhSua.cb_LoaiXe.SelectedIndex = 1;
            else
                frmChinhSua.cb_LoaiXe.SelectedIndex = 2;
            frmChinhSua.txb_HieuXe.Text = dtgv_XeGui.CurrentRow.Cells[3].Value.ToString();
            byte[] pic;
            pic = (byte[])dtgv_XeGui.CurrentRow.Cells[4].Value;
            MemoryStream picture = new MemoryStream(pic);
            frmChinhSua.ptb_HinhAnh.Image = Image.FromStream(picture);
            frmChinhSua.dtp_GioVaoBen.Value = Convert.ToDateTime(dtgv_XeGui.CurrentRow.Cells[5].Value.ToString());
            frmChinhSua.dtp_NgayVaoBen.Value = (DateTime)dtgv_XeGui.CurrentRow.Cells[6].Value;
            if (dtgv_XeGui.CurrentRow.Cells[7].Value.ToString() == "Ve gio")
                frmChinhSua.cb_LoaiVe.SelectedIndex = 0;
            else if (dtgv_XeGui.CurrentRow.Cells[7].Value.ToString() == "Ve ngay")
                frmChinhSua.cb_LoaiVe.SelectedIndex = 1;
            else if(dtgv_XeGui.CurrentRow.Cells[7].Value.ToString() == "Ve tuan")
                frmChinhSua.cb_LoaiVe.SelectedIndex = 2;
            else
                frmChinhSua.cb_LoaiVe.SelectedIndex = 3;
            frmChinhSua.ShowDialog(this);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            frmChinhSuaDanhSachXeGui frmChinhSua = new frmChinhSuaDanhSachXeGui();
            frmChinhSua.ShowDialog(this);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frmThongKeDoanhThu = new frmThongKeDoanhThu();
            frmThongKeDoanhThu.ShowDialog(this);
        }
    }
}
