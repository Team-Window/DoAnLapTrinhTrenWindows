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
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }
        GuiXe guiXe = new GuiXe();
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnLapTrinhTrenWIndowsDataSet.ThongKe' table. You can move, or remove it, as needed.
            this.thongKeTableAdapter.Fill(this.doAnLapTrinhTrenWIndowsDataSet.ThongKe);
            SqlCommand command = new SqlCommand("SELECT * FROM ThongKe");
            DataGridView1.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            DataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019,co gian de pic dep, dang tim auto-size
            DataGridView1.DataSource = guiXe.getGuiXe(command);
            try
            {
                picCol = (DataGridViewImageColumn)DataGridView1.Columns[4];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch
            {

            }
            DataGridView1.AllowUserToAddRows = false;
        }
    }
}
