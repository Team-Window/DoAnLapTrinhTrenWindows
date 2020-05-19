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
    }
}
