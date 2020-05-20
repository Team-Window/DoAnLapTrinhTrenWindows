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

namespace QuanLiOto
{
    public partial class FrmQLDSThue : Form
    {
        public FrmQLDSThue()
        {
            InitializeComponent();
        }
        QLThue qlthue = new QLThue();
        private void btn_VaoBen_Click(object sender, EventArgs e)
        {
            FrmThemDSThue themDSThue = new FrmThemDSThue();
            themDSThue.Show(this);
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ID", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txb_ID.Text);
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
                string giayphepxe = txb_GiayPhepXe.Text;
                MemoryStream pic = new MemoryStream();
                DateTime ngayhd = dtp_NgayHopDong.Value;
                int trigiahd = Convert.ToInt32(txb_TriGiaHD.Text);
                DateTime ngaygiaoxe = dtp_NgayGiaoXe.Value;
                DateTime ngayhethanthue = dtp_NgayHetHanThue.Value;
                if (qlthue.XeThueExist(bienso, "edit", id))
                {
                    MessageBox.Show("Xe này đã tồn tại", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    ptb_Anh.Image.Save(pic, ptb_Anh.Image.RawFormat);
                    if (qlthue.updateXeThue(id, fname, lname, cmnd, loaixe, hieuxe, bienso, giayphepxe, pic, ngayhd, trigiahd, ngaygiaoxe, ngayhethanthue))
                    {
                        MessageBox.Show("Đã chỉnh sửa thành công", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fileds", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        bool verif()
        {
            if ((txb_FirstName.Text.Trim() == "") || (txb_LastName.Text.Trim() == "") || (txb_CMND.Text.Trim() == "") || (ptb_Anh.Image == null) || (txb_HieuXe.Text.Trim() == "") || (txb_TriGiaHD.Text.Trim() == ""))
            {
                return false;
            }
            else if ((cb_LoaiXe.SelectedIndex == 1 && txb_BienSo.Text == "" && txb_GiayPhepXe.Text == "") || (cb_LoaiXe.SelectedIndex == 2 && txb_BienSo.Text == "" && txb_GiayPhepXe.Text == ""))
            {
                MessageBox.Show("Nếu là xe máy hoặc xe hơi thì phải nhập biển số và giấy phép xe");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ID", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txb_ID.Text);
                System.Data.DataTable table = qlthue.getXeThueByID(id);
                if (table.Rows.Count > 0)
                {
                    txb_FirstName.Text = table.Rows[0][1].ToString();
                    txb_LastName.Text = table.Rows[0][2].ToString();
                    txb_CMND.Text = table.Rows[0][3].ToString();
                    string loaixe = table.Rows[0][4].ToString();
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
                    txb_HieuXe.Text = table.Rows[0][5].ToString();
                    txb_BienSo.Text = table.Rows[0][6].ToString();
                    txb_GiayPhepXe.Text = table.Rows[0][7].ToString();
                    byte[] pic = (byte[])table.Rows[0][8];
                    MemoryStream picture = new MemoryStream(pic);
                    ptb_Anh.Image = Image.FromStream(picture);
                    dtp_NgayHopDong.Value = (DateTime)table.Rows[0][9];
                    txb_TriGiaHD.Text = table.Rows[0][10].ToString();
                    dtp_NgayGiaoXe.Value = (DateTime)table.Rows[0][11];
                    dtp_NgayHetHanThue.Value = (DateTime)table.Rows[0][12];
                }
                else
                {
                    MessageBox.Show("ID không tồn tại", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ID", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txb_ID.Text);
                if (MessageBox.Show("Bạn có muốn xóa đối tượng này", "FrmQLDSThue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (qlthue.deleteXeThue(id))
                    {
                        MessageBox.Show("Đã xóa thành công", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }   
            }
        }

        public void fillGrid(SqlCommand command)
        {
            dtgv_DSThue.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgv_DSThue.RowTemplate.Height = 80;
            dtgv_DSThue.DataSource = qlthue.getXeThue(command);
            picCol = (DataGridViewImageColumn)dtgv_DSThue.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv_DSThue.AllowUserToAddRows = false;
        }

        private void FrmQLDSThue_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM thue Where fname is not null and lname is not null and ngayhd is not null and ngaygiaoxe is not null"));
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM thue WHERE CONCAT(id, fname, lname) LIKE '%" + txb_Search.Text + "%'");
            fillGrid(command);
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM thue Where fname is not null and lname is not null and ngayhd is not null and ngaygiaoxe is not null");
            fillGrid(command);
        }

        private void dtgv_DSThue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_ID.Text = dtgv_DSThue.CurrentRow.Cells[0].Value.ToString();
            txb_FirstName.Text = dtgv_DSThue.CurrentRow.Cells[1].Value.ToString();
            txb_LastName.Text = dtgv_DSThue.CurrentRow.Cells[2].Value.ToString();
            txb_CMND.Text = dtgv_DSThue.CurrentRow.Cells[3].Value.ToString();
            string loaixe = dtgv_DSThue.CurrentRow.Cells[4].Value.ToString();
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
            txb_HieuXe.Text = dtgv_DSThue.CurrentRow.Cells[5].Value.ToString();
            txb_BienSo.Text = dtgv_DSThue.CurrentRow.Cells[6].Value.ToString();
            txb_GiayPhepXe.Text = dtgv_DSThue.CurrentRow.Cells[7].Value.ToString();
            byte[] pic = (byte[])dtgv_DSThue.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            ptb_Anh.Image = Image.FromStream(picture);
            dtp_NgayHopDong.Value = (DateTime)dtgv_DSThue.CurrentRow.Cells[9].Value;
            txb_TriGiaHD.Text = dtgv_DSThue.CurrentRow.Cells[10].Value.ToString();
            dtp_NgayGiaoXe.Value = (DateTime)dtgv_DSThue.CurrentRow.Cells[11].Value;
            dtp_NgayHetHanThue.Value = (DateTime)dtgv_DSThue.CurrentRow.Cells[12].Value;
        }

        private void btn_TraXe_Click(object sender, EventArgs e)
        {
            if(txb_GiayPhepXe.Text=="Cho thuê")
            {
                for (int i = 0; i < dtgv_DSThue.Rows.Count; i++)
                {
                    string loaihopdong = dtgv_DSThue.Rows[i].Cells[7].Value.ToString();
                    string bienso = dtgv_DSThue.Rows[i].Cells[6].Value.ToString();
                    if((loaihopdong=="Thuê")&&(txb_BienSo.Text==bienso))
                    {
                        MessageBox.Show("Xe đang được cho người khác thuê", "Không có xe trong kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }    
                }
            }    
                
            FrmThanhToanXeThue thanhtoanxethue = new FrmThanhToanXeThue();
            if (txb_ID.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập ID để thanh toán", "FrmQLDSThue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txb_ID.Text);
                System.Data.DataTable table = qlthue.getXeThueByID(id);
                if (table.Rows.Count > 0)
                {
                    thanhtoanxethue.txb_ID.Text = txb_ID.Text;
                    thanhtoanxethue.txb_FirstName.Text = table.Rows[0][1].ToString();
                    thanhtoanxethue.txb_LastName.Text = table.Rows[0][2].ToString();
                    thanhtoanxethue.txb_CMND.Text = table.Rows[0][3].ToString();
                    string loaixe = table.Rows[0][4].ToString();
                    if (loaixe == "Xe đạp")
                    {
                        thanhtoanxethue.cb_LoaiXe.SelectedIndex = 0;
                    }
                    else if (loaixe == "Xe máy")
                    {
                        thanhtoanxethue.cb_LoaiXe.SelectedIndex = 1;
                    }
                    else
                    {
                        thanhtoanxethue.cb_LoaiXe.SelectedIndex = 2;
                    }
                    thanhtoanxethue.txb_HieuXe.Text = table.Rows[0][5].ToString();
                    thanhtoanxethue.txb_BienSo.Text = table.Rows[0][6].ToString();
                    thanhtoanxethue.cb_loaihopdong.Text = table.Rows[0][7].ToString();
                    byte[] pic = (byte[])table.Rows[0][8];
                    MemoryStream picture = new MemoryStream(pic);
                    thanhtoanxethue.ptb_Anh.Image = Image.FromStream(picture);
                    thanhtoanxethue.dtp_NgayHopDong.Value = (DateTime)table.Rows[0][9];
                    thanhtoanxethue.txb_TriGiaHD.Text = table.Rows[0][10].ToString();
                    thanhtoanxethue.dtp_NgayGiaoXe.Value = (DateTime)table.Rows[0][11];
                    thanhtoanxethue.dtp_NgayHetHanThue.Value = (DateTime)table.Rows[0][12];
                    thanhtoanxethue.Show(this);
                }
            }
        }

        private void dtgv_DSThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_ID.Text = dtgv_DSThue.CurrentRow.Cells[0].Value.ToString();
            txb_FirstName.Text = dtgv_DSThue.CurrentRow.Cells[1].Value.ToString();
            txb_LastName.Text = dtgv_DSThue.CurrentRow.Cells[2].Value.ToString();
            txb_CMND.Text = dtgv_DSThue.CurrentRow.Cells[3].Value.ToString();
            string loaixe = dtgv_DSThue.CurrentRow.Cells[4].Value.ToString();
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
            txb_HieuXe.Text = dtgv_DSThue.CurrentRow.Cells[5].Value.ToString();
            txb_BienSo.Text = dtgv_DSThue.CurrentRow.Cells[6].Value.ToString();
            txb_GiayPhepXe.Text = dtgv_DSThue.CurrentRow.Cells[7].Value.ToString();
            byte[] pic = (byte[])dtgv_DSThue.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            ptb_Anh.Image = Image.FromStream(picture);
            dtp_NgayHopDong.Value = (DateTime)dtgv_DSThue.CurrentRow.Cells[9].Value;
            txb_TriGiaHD.Text = dtgv_DSThue.CurrentRow.Cells[10].Value.ToString();
            dtp_NgayGiaoXe.Value = (DateTime)dtgv_DSThue.CurrentRow.Cells[11].Value;
            dtp_NgayHetHanThue.Value = (DateTime)dtgv_DSThue.CurrentRow.Cells[12].Value;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
