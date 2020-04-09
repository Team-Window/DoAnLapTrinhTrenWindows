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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            GuiXe guixe = new GuiXe();
            int mave = Convert.ToInt32(txb_MaVe.Text);
            string bienso = txb_BienSo.Text;
            string loaixe;
            string hieuxe = txb_HieuXe.Text;
            MemoryStream hinhanh = new MemoryStream();
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
            TimeSpan giovaoben = dtp_GioVaoBen.Value.TimeOfDay;
            DateTime ngayvaoben = dtp_NgayVaoBen.Value.Date;
            if (verif())
            {
                ptb_HinhAnh.Image.Save(hinhanh, ptb_HinhAnh.Image.RawFormat);
                if (guixe.InsertGuiXe(mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben))
                {
                    MessageBox.Show("Đã thêm thành công", "Add GuiXe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add GuiXe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bool verif()
            {
                if (txb_MaVe.Text.Trim() == "" || txb_BienSo.Text.Trim() == "" || txb_HieuXe.Text.Trim() == "" || ptb_HinhAnh.Image == null)
                    return false;
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
    }
}
