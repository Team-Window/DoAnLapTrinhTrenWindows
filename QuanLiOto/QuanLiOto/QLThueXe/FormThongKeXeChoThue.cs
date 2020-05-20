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
using Microsoft.Office.Interop.Excel;
namespace QuanLiOto.QLThueXe
{
    public partial class FormThongKeXeChoThue : Form
    {
        public FormThongKeXeChoThue()
        {
            InitializeComponent();
            SqlCommand command = new SqlCommand("SELECT * FROM thanhtoanxethue");
            fillGrid(command);
            if (rdb_No.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            int tongsotien = 0;
            for (int i = 0; i < dtv_Doanhthu.Rows.Count; i++)
            {
                tongsotien += int.Parse(dtv_Doanhthu.Rows[i].Cells[9].Value.ToString());
            }
            //lb_TongDoanhThu.Text = query;
            lb_TongDoanhThu.Text = tongsotien.ToString();
        }
        QLThanhToanXeThue qLThanhToanXeThue = new QLThanhToanXeThue();
        public void fillGrid(SqlCommand command)
        {
            dtv_Doanhthu.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtv_Doanhthu.RowTemplate.Height = 80;
            dtv_Doanhthu.DataSource = qLThanhToanXeThue.getDoanhThu(command);
            picCol = (DataGridViewImageColumn)dtv_Doanhthu.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtv_Doanhthu.AllowUserToAddRows = false;
        }
        private void FormThongKeXeChoThue_Load(object sender, EventArgs e)
        {

        }

        private void rdb_Yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void rdb_No_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (rdb_Thue.Checked)
            {
                query = "SELECT * FROM thanhtoanxethue WHERE loaihopdong='Thuê' AND ngaytraxe BETWEEN '" + date1 + "'AND'" + date2 + "'";
            }
            else if (rdb_Chothue.Checked)
            {
                query = "SELECT * FROM thanhtoanxethue WHERE loaihopdong='Cho thuê' AND ngaytraxe BETWEEN '" + date1 + "'AND'" + date2 + "'";
            }
            else
            {
                query = "SELECT * FROM thanhtoanxethue WHERE ngaytraxe BETWEEN '" + date1 + "'AND'" + date2 + "'";
            }

            command = new SqlCommand(query);
            fillGrid(command);
            int tongsotien = 0;
            for (int i = 0; i < dtv_Doanhthu.Rows.Count; i++)
            {
                tongsotien += int.Parse(dtv_Doanhthu.Rows[i].Cells[9].Value.ToString());
            }
            //lb_TongDoanhThu.Text = query;
            lb_TongDoanhThu.Text = tongsotien.ToString();
        }

        private void btn_SaveToExcelFile_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp =
                 new Microsoft.Office.Interop.Excel.Application();
            int i = 0;
            int j = 0;
            Microsoft.Office.Interop.Excel._Workbook ExcelBook;
            Microsoft.Office.Interop.Excel._Worksheet ExcelSheet;
            ExcelBook = (Microsoft.Office.Interop.Excel._Workbook)ExcelApp.Workbooks.Add(1);
            ExcelSheet = (Microsoft.Office.Interop.Excel._Worksheet)ExcelBook.ActiveSheet;

            for (i = 1; i <= this.dtv_Doanhthu.Columns.Count; i++)
            {
                ExcelSheet.Cells[1, i] = this.dtv_Doanhthu.Columns[i - 1].HeaderText;
            }
            string bdate;
            //export data
            for (i = 1; i <= this.dtv_Doanhthu.RowCount; i++)
            {
                for (j = 1; j <= dtv_Doanhthu.Columns.Count; j++)
                {
                    try
                    {
                        ExcelSheet.Cells[i + 1, j] = dtv_Doanhthu.Rows[i - 1].Cells[j - 1].Value;
                        if (j == 5 || j == 7)
                        {

                            bdate = dtv_Doanhthu.Rows[i].Cells[j].Value.ToString();
                            ExcelSheet.Cells[i + 1, j] = bdate;

                        }
                    }
                    catch
                    {


                    }
                }
            }
            ExcelSheet.Cells[dtv_Doanhthu.RowCount + 1, dtv_Doanhthu.Columns.Count + 1].Value = "Tổng doanh thu";
            ExcelSheet.Cells[dtv_Doanhthu.RowCount + 2, dtv_Doanhthu.Columns.Count + 1].Value = lb_TongDoanhThu.Text;
            ExcelApp.Visible = true;
            ExcelSheet = null;
            ExcelBook = null;
            ExcelApp = null;
        }
    }
    
}
