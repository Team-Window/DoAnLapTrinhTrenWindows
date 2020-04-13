using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class frmThongKeDoanhThu : Form
    {
        GuiXe guixe = new GuiXe();
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnLapTrinhTrenWIndowsDataSet.ThongKe' table. You can move, or remove it, as needed.
            this.thongKeTableAdapter.Fill(this.doAnLapTrinhTrenWIndowsDataSet.ThongKe);
            SqlCommand command = new SqlCommand("SELECT * FROM ThongKe");
            DataGridView1.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            DataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019,co gian de pic dep, dang tim auto-size
            DataGridView1.DataSource = guixe.getGuiXe(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {

            SqlCommand command;
            String query;
            int tongsotien = 0;
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
                if (RadioBtXedap.Checked)
                {
                    query = "SELECT * FROM ThongKe WHERE loaixe='Xe đạp', ngayraben='date1'";
                        
                }
                else if (RadioBtXemay.Checked)
                {
                    query = "SELECT * FROM ThongKe WHERE loaixe='Xe máy', ngayraben='date1'";
                
            }
                else if (RadioBtXehoi.Checked)
                {
                    query = "SELECT * FROM ThongKe WHERE loaixe='Xe hơi', ngayraben='date1'";
                
            }
                else
                {
                    query = "SELECT * FROM ThongKe WHERE ngayraben='date1'";
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    tongsotien += int.Parse(DataGridView1.Rows[i].Cells[9].Value.ToString());
                }
            }
                command = new SqlCommand(query);
                fillGrid(command);
            lb_TongDoanhThu.Text = tongsotien.ToString();
        }
    public void fillGrid(SqlCommand command)
    {
        DataGridView1.ReadOnly = true;// nap lai du lieu len datagrid view

        DataGridViewImageColumn picCol = new DataGridViewImageColumn();

        DataGridView1.RowTemplate.Height = 80;

        DataGridView1.DataSource = guixe.getGuiXe(command);

        picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        DataGridView1.AllowUserToAddRows = false; // dong nay tren stackoverflo

    }
}
}
