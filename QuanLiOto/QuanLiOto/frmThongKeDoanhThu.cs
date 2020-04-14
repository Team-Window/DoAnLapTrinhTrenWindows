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
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = guixe.getGuiXe(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[4];   
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            
            int DoanhThuThang = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                 DoanhThuThang+= int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
               
            }
            lb_TongDoanhThu.Text = DoanhThuThang.ToString();
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {

            SqlCommand command;
            String query;

            int tongsotien = 0;
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (RadioBtXedap.Checked)
                {
                    query = "SELECT * FROM ThongKe WHERE loaixe='Xe dap'AND ngayraben="+date1;
                        
                }
                else if (RadioBtXemay.Checked)
                {
                    query = "SELECT * FROM ThongKe WHERE loaixe='Xe may'AND ngayraben='" + date1 + "'";
                
                }
                else if (RadioBtXehoi.Checked)
                {
                    query = "SELECT * FROM ThongKe WHERE loaixe='Xe hoi'AND ngayraben='"+date1 + "'";
                
                }
                else
                {
                    query = "SELECT * FROM ThongKe WHERE ngayraben='" + date1 + "'";
               
                }
             command = new SqlCommand(query);
             fillGrid(command);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tongsotien += int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
            }
            //lb_TongDoanhThu.Text = query;
            lb_TongDoanhThu.Text = tongsotien.ToString();

        }
    public void fillGrid(SqlCommand command)
    {
        dataGridView1.ReadOnly = true;// nap lai du lieu len datagrid view

        DataGridViewImageColumn picCol = new DataGridViewImageColumn();

        dataGridView1.RowTemplate.Height = 80;

        dataGridView1.DataSource = guixe.getGuiXe(command);

        picCol = (DataGridViewImageColumn)dataGridView1.Columns[4];

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        dataGridView1.AllowUserToAddRows = false; // dong nay tren stackoverflo

    }

        private void btPrintToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp =
                 new Microsoft.Office.Interop.Excel.Application();
            int i = 0;
            int j = 0;
            Microsoft.Office.Interop.Excel._Workbook ExcelBook;
            Microsoft.Office.Interop.Excel._Worksheet ExcelSheet;
            ExcelBook = (Microsoft.Office.Interop.Excel._Workbook)ExcelApp.Workbooks.Add(1);
            ExcelSheet = (Microsoft.Office.Interop.Excel._Worksheet)ExcelBook.ActiveSheet;

            for (i = 1; i <= this.dataGridView1.Columns.Count; i++)
            {
                ExcelSheet.Cells[1, i] = this.dataGridView1.Columns[i - 1].HeaderText;
            }
            string bdate;
            //export data
            for (i = 1; i <= this.dataGridView1.RowCount; i++)
            {
                for (j = 1; j <= dataGridView1.Columns.Count; j++)
                {
                    try
                    {
                        ExcelSheet.Cells[i + 1, j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                        if (j == 5 || j == 7)
                        {

                            bdate = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            ExcelSheet.Cells[i + 1, j] = bdate;

                        }
                    }
                    catch
                    {
                        
                        
                    }
                }
            }
            ExcelSheet.Cells[dataGridView1.RowCount+1, dataGridView1.Columns.Count+1].Value = "Tong doanh thu";
            ExcelSheet.Cells[dataGridView1.RowCount + 2, dataGridView1.Columns.Count + 1].Value = lb_TongDoanhThu.Text;
            ExcelApp.Visible = true;
            ExcelSheet = null;
            ExcelBook = null;
            ExcelApp = null;
        }
    }
}
