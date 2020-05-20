using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiOto
{
    public partial class FrmThongKePhieuThanhToanLuong : Form
    {
        public FrmThongKePhieuThanhToanLuong()
        {
            InitializeComponent();
        }
        QLPhieuThanhToan phieuthanhtoan = new QLPhieuThanhToan();
        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void btn_SaveToExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }


        private void copyAlltoClipboard()
        {
            dtgv_ThongKe.RowHeadersVisible = false;
            dtgv_ThongKe.SelectAll();
            DataObject dataObj = dtgv_ThongKe.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        public void fillGrid(SqlCommand command)
        {
            dtgv_ThongKe.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgv_ThongKe.RowTemplate.Height = 80;
            dtgv_ThongKe.DataSource = phieuthanhtoan.getPhieuThanhToan(command);
            dtgv_ThongKe.AllowUserToAddRows = false;
        }

        private void FrmThongKePhieuThanhToanLuong_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM phieuthanhtoan");
            fillGrid(command);
            if (rdb_No.Checked)
            {
                dtp_Start.Enabled = false;
                dtp_End.Enabled = false;
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;
            if (rdb_Yes.Checked)
            {
                string date1 = dtp_Start.Value.ToString("yyyy-MM-dd");
                string date2 = dtp_End.Value.ToString("yyyy-MM-dd");
                query = "SELECT * FROM phieuthanhtoan WHERE ngaylamviec BETWEEN '" + date1 + "'AND'" + date2 + "'";
                command = new SqlCommand(query);
                fillGrid(command);
            }
            else
            {
                query = "SELECT * FROM phieuthanhtoan'";
                command = new SqlCommand(query);
                fillGrid(command);
            }
        }
    }
}
