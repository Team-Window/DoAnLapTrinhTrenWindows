using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiOto
{
    class dangkylichlamviec
    {
        My_DB mydb = new My_DB();
        public bool insertLichLamViec(int iduser, string fname, string lname, DateTime ngaydk, int ca)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dkcongviec(iduser, fname, lname, ngaydk, ca) VALUES (@iduser, @fname, @lname, @ngaydk, @ca)", mydb.getConnection);
            command.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ngaydk", SqlDbType.Date).Value = ngaydk;
            command.Parameters.Add("@ca", SqlDbType.Int).Value = ca;

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

        public DataTable getLichLamViec(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteLichLamViec(int iduser, DateTime ngaydk)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dkcongviec WHERE iduser=@id AND ngaydk=@ngaydk", mydb.getConnection);
            command.Parameters.Add("@ngaydk", SqlDbType.Date).Value = ngaydk;
            command.Parameters.Add("@id", SqlDbType.Int).Value = iduser;
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

        public bool updateLichLamViec(int iduser, string fname, string lname, DateTime ngaydk, int ca)
        {
            SqlCommand command = new SqlCommand("UPDATE dkcongviec SET fname=@fname, lname=@lname, ngaydk=@ngaydk, ca=@ca WHERE iduser=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = iduser;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ngaydk", SqlDbType.Date).Value = ngaydk;
            command.Parameters.Add("@ca", SqlDbType.Int).Value = ca;

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
