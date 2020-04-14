using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiOto
{
    class GuiXe
    {
        My_DB mydb = new My_DB();
        public bool InsertGuiXe(int mave, string bienso, string loaixe, string hieuxe, MemoryStream hinhanh,TimeSpan giovaoben, DateTime ngayvaoben, string loaive)
        {
            SqlCommand command = new SqlCommand("INSERT INTO GuiXe (mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben,loaive)"
                + "VALUES(@mave, @bienso, @loaixe, @hieuxe, @hinhanh, @giovaoben, @ngayvaoben, @loaive)", mydb.getConnection);
            command.Parameters.Add("@mave", SqlDbType.Int).Value = mave;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh.ToArray();
            command.Parameters.Add("@giovaoben", SqlDbType.Time).Value = giovaoben;
            command.Parameters.Add("@ngayvaoben", SqlDbType.DateTime).Value = ngayvaoben;
            command.Parameters.Add("@loaive", SqlDbType.VarChar).Value = loaive;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        

        

        public bool UpdateGuiXe(int mave, string bienso, string loaixe, string hieuxe, MemoryStream hinhanh, TimeSpan giovaoben, DateTime ngayvaoben, string loaive)
        {
            SqlCommand command = new SqlCommand("UPDATE GuiXe SET mave=@mave, bienso=@bienso, loaixe=@loaixe, hieuxe=@hieuxe, hinhanh=@hinhanh, giovaoben=@giovaoben, ngayvaoben=@ngayvaoben, loaive=@loaive WHERE mave=@mave", mydb.getConnection);
            command.Parameters.Add("@mave", SqlDbType.Int).Value = mave;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh.ToArray();
            command.Parameters.Add("@giovaoben", SqlDbType.Time).Value = giovaoben;
            command.Parameters.Add("@ngayvaoben", SqlDbType.DateTime).Value = ngayvaoben;
            command.Parameters.Add("@loaive", SqlDbType.VarChar).Value = loaive;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteGuiXe(int mave)
        {
            SqlCommand command = new SqlCommand("DELETE FROM GuiXe WHERE mave=@mave", mydb.getConnection);
            command.Parameters.Add("@mave", SqlDbType.Int).Value = mave;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getGuiXe(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        public string tongSoLuongPhuongTien()
        {
            return execCount("SELECT COUNT (*) FROM GuiXe ");
        }
        public string SoLuongXeMay()
        {
            return execCount("SELECT COUNT (*) FROM GuiXe WHERE loaixe='Xe may' ");
        }
        public string SoLuongXeDap()
        {
            return execCount("SELECT COUNT (*) FROM GuiXe WHERE loaixe='Xe dap' ");
        }
        public string SoLuongXeHoi()
        {
            return execCount("SELECT COUNT (*) FROM GuiXe WHERE loaixe='Xe hoi' ");
        }
        public bool InsertThongKe(int mave, string bienso, string loaixe, string hieuxe, MemoryStream hinhanh, TimeSpan giovaoben, DateTime ngayvaoben, string loaive,TimeSpan gioraben,DateTime ngayraben,int tongtien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ThongKe (mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben,loaive,gioraben,ngayraben,tongtien)"
                + "VALUES(@mave, @bienso, @loaixe, @hieuxe, @hinhanh, @giovaoben, @ngayvaoben,@loaive,@gioraben,@ngayraben,@tongtien)", mydb.getConnection);
            command.Parameters.Add("@mave", SqlDbType.Int).Value = mave;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh.ToArray();
            command.Parameters.Add("@giovaoben", SqlDbType.Time).Value = giovaoben;
            command.Parameters.Add("@ngayvaoben", SqlDbType.DateTime).Value = ngayvaoben;
            command.Parameters.Add("@loaive", SqlDbType.VarChar).Value = loaive;
            command.Parameters.Add("@gioraben", SqlDbType.Time).Value = gioraben;
            command.Parameters.Add("@ngayraben", SqlDbType.DateTime).Value = ngayraben;
            command.Parameters.Add("@tongtien", SqlDbType.Int).Value = tongtien;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool maveExist(int mave)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM GuiXe WHERE mave=@mave", mydb.getConnection);
            command.Parameters.Add("@mave", SqlDbType.Int).Value = mave;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count) == 0)
                return false;
            else
                return true;
        }
    }
}
