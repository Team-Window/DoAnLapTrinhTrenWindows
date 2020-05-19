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
    class login
    {
        My_DB mydb = new My_DB();
        public bool insertUser(string fname, string lname, string uname, string password, MemoryStream anh, string chucvu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [user] (fname, lname, uname, password, anh, chucvu) VALUES (@fn, @ln, @un, @pass, @pic, @chucvu)", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = anh.ToArray();
            command.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = chucvu;

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

        public bool updateUser(int id, string fname, string lname, string uname, string password, MemoryStream anh, string chucvu)
        {
            SqlCommand command = new SqlCommand("UPDATE [user] SET fname=@fname, lname=@lname, uname=@uname, password=@password, anh=@anh, chucvu=@chucvu WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = chucvu;

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

        public bool deleteUser(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [user] WHERE id=@id", mydb.getConnection);
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

        public DataTable getUser(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getUserByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
                query = "SELECT * FROM [user] WHERE uname=@un";
            else if (operation == "edit")
            {
                query = "SELECT * FROM [user] WHERE uname=@un AND id<>@uid";
            }
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
