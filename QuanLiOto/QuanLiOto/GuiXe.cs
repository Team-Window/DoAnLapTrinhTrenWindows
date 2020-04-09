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
    class GuiXe
    {
        My_DB mydb = new My_DB();
        public bool InsertGuiXe(int mave, string bienso, string loaixe, string hieuxe, MemoryStream hinhanh, TimeSpan giovaoben, DateTime ngayvaoben)
        {
            SqlCommand command = new SqlCommand("INSERT INTO GuiXe (mave, bienso, loaixe, hieuxe, hinhanh, giovaoben, ngayvaoben)"
                + "VALUES(@mave, @bienso, @loaixe, @hieuxe, @hinhanh, @giovaoben, @ngayvaoben)", mydb.getConnection);
            command.Parameters.Add("@mave", SqlDbType.Int).Value = mave;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh.ToArray();
            command.Parameters.Add("@giovaoben", SqlDbType.Time).Value = giovaoben;
            command.Parameters.Add("@ngayvaoben", SqlDbType.DateTime).Value = ngayvaoben;

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


    }
}
