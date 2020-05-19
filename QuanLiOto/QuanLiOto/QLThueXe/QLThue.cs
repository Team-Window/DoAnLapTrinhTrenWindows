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
    class QLThue
    {
        My_DB mydb = new My_DB();
        public bool insertXeThue(string fname, string lname, string cmnd, string loaixe, string hieuxe, string bienso, string giayphep, MemoryStream anh, DateTime  ngayhd, int trigiahd, DateTime ngaygiaoxe, DateTime ngayhethanthue)
        {
            SqlCommand command = new SqlCommand("INSERT INTO thue(fname, lname, cmnd, loaixe, hieuxe, bienso, giayphepxe, anh, ngayhd, trigiahd, ngaygiaoxe, ngayhethanthue) VALUES (@fname, @lname, @cmnd, @loaixe, @hieuxe, @bienso, @giayphepxe, @anh, @ngayhd, @trigiahd, @ngaygiaoxe, @ngayhethanthue)", mydb.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@giayphepxe", SqlDbType.VarChar).Value = giayphep;
            command.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            command.Parameters.Add("@ngayhd", SqlDbType.Date).Value = ngayhd;
            command.Parameters.Add("@trigiahd", SqlDbType.Int).Value = trigiahd;
            command.Parameters.Add("@ngaygiaoxe", SqlDbType.Date).Value = ngaygiaoxe;
            command.Parameters.Add("@ngayhethanthue", SqlDbType.Date).Value = ngayhethanthue;

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

        public DataTable getXeThue(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateXeThue(int id, string fname, string lname, string cmnd, string loaixe, string hieuxe, string bienso, string giayphep, MemoryStream anh, DateTime ngayhd, int trigiahd, DateTime ngaygiaoxe, DateTime ngayhethanthue)
        {
            SqlCommand command = new SqlCommand("UPDATE thue SET fname=@fname, lname=@lname, cmnd=@cmnd, loaixe=@loaixe, hieuxe=@hieuxe, bienso=@bienso, giayphepxe=@giayphepxe, anh=@anh, ngayhd=@ngayhd, trigiahd=@trigiahd, ngaygiaoxe=@ngaygiaoxe, ngayhethanthue=@ngayhethanthue WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@giayphepxe", SqlDbType.VarChar).Value = giayphep;
            command.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            command.Parameters.Add("@ngayhd", SqlDbType.Date).Value = ngayhd;
            command.Parameters.Add("@trigiahd", SqlDbType.Int).Value = trigiahd;
            command.Parameters.Add("@ngaygiaoxe", SqlDbType.Date).Value = ngaygiaoxe;
            command.Parameters.Add("@ngayhethanthue", SqlDbType.Date).Value = ngayhethanthue;

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

        public DataTable getXeThueByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM thue WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool XeThueExist(string bienso, string operation, int id = 0)
        {
            string query = "";
            if (operation == "edit")
            {
                query = "SELECT * FROM thue WHERE bienso=@bienso AND id<>@id";
            }
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool deleteXeThue(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM thue WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public string totalXeThue()
        {
            return execCount("SELECT COUNT (*) FROM thue ");
        }

        public string totalXeDap()
        {
            return execCount("SELECT COUNT (*) FROM thue WHERE loaixe='Xe đạp' ");
        }

        public string totalXeMay()
        {
            return execCount("SELECT COUNT (*) FROM thue WHERE loaixe='Xe máy' ");
        }

        public string totalXeHoi()
        {
            return execCount("SELECT COUNT (*) FROM thue WHERE loaixe='Xe hơi' ");
        }

        string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
    }
}
