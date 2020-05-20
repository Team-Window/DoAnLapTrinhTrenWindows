using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiOto
{
    class QLLuongThuong
    {
        My_DB mydb = new My_DB();
        public bool insertQLLuongThuong(int iduser, string fname, string lname, DateTime ngaylamviec, float sogiolamviec, int luong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO thanhtoanluong (iduser, fname, lname, ngaylamviec, sogiolamviec, luong) VALUES (@iduser, @fname, @lname, @ngaylamviec, @sogiolamviec, @luong)", mydb.getConnection);
            command.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngaylamviec;
            command.Parameters.Add("@sogiolamviec", SqlDbType.Float).Value = sogiolamviec;
            command.Parameters.Add("@luong", SqlDbType.Int).Value = luong;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public DataTable getQLLuongThuong(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteQLLuongThuong(int iduser, DateTime ngaylamviec)
        {
            SqlCommand command = new SqlCommand("DELETE FROM thanhtoanluong WHERE iduser=@id and ngaylamviec=@ngaylamviec", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = iduser;
            command.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngaylamviec;
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
    }
}
