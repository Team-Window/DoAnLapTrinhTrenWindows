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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        ChamCong chamcong = new ChamCong();
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE uname = @User AND password=@Pass", mydb.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = txb_UserName.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txb_Password.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][6].ToString() == "Nhân viên")
                {
                    int userid = Convert.ToUInt16(table.Rows[0][0].ToString());
                    Globals.SetGlobalUserId(userid);
                    DateTime giovaolam = DateTime.Now;
                    Globals.SetGlobalUserGioVaoLam(giovaolam);
                    FrmDanhChoNhanVien nhanvien = new FrmDanhChoNhanVien();
                    nhanvien.ShowDialog(this);
                }
                else
                {
                    int userid = Convert.ToUInt16(table.Rows[0][0].ToString());
                    Globals.SetGlobalUserId(userid);

                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lbl_NewUsers_Click(object sender, EventArgs e)
        {
            FrmCreateAccount createAccount = new FrmCreateAccount();
            createAccount.ShowDialog(this);
        }
    }
}
