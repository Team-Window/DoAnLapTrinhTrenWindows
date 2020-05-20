using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiOto
{
    class QLThanhToanXeThue
    {
        My_DB mydb = new My_DB();
        public bool insertThanhToanXeThue(string fname, string lname, string cmnd, string loaixe, string bienso,string loaihopdong, MemoryStream anh, DateTime ngayhd, int trigiahd, DateTime ngaygiaoxe, DateTime ngayhethanthue, DateTime ngaytraxe, float sotienphaitra)
        {
            SqlCommand command = new SqlCommand("INSERT INTO thanhtoanxethue(fname, lname, cmnd, loaixe, bienso,loaihopdong, anh, ngayhd, trigiahd, ngaygiaoxe, ngayhethanthue, ngaytraxe, sotienphaitra) VALUES (@fname, @lname, @cmnd, @loaixe, @bienso,@loaihopdong, @anh, @ngayhd, @trigiahd, @ngaygiaoxe, @ngayhethanthue, @ngaytraxe, @sotienphaitra)", mydb.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@loaihopdong", SqlDbType.NVarChar).Value = loaihopdong;
            command.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            command.Parameters.Add("@ngayhd", SqlDbType.Date).Value = ngayhd;
            command.Parameters.Add("@trigiahd", SqlDbType.Int).Value = trigiahd;
            command.Parameters.Add("@ngaygiaoxe", SqlDbType.Date).Value = ngaygiaoxe;
            command.Parameters.Add("@ngayhethanthue", SqlDbType.Date).Value = ngayhethanthue;
            command.Parameters.Add("@ngaytraxe", SqlDbType.Date).Value = ngaytraxe;
            command.Parameters.Add("@sotienphaitra", SqlDbType.Float).Value = sotienphaitra;

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
        public DataTable getDoanhThu(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
