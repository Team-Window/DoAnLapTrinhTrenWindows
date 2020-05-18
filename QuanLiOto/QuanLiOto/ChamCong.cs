using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiOto
{
    class ChamCong
    {
        My_DB mydb = new My_DB();
        public bool insertBangChamCong(int iduser, DateTime giovaolam, DateTime giotanlam)
        {
            SqlCommand command = new SqlCommand("INSERT INTO bangchamcong(iduser, giovaolam, giotanlam) VALUES (@iduser, @giovaolam, @giotanlam)", mydb.getConnection);
            command.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
            command.Parameters.Add("@giovaolam", SqlDbType.DateTime).Value = giovaolam;
            command.Parameters.Add("@giotanlam", SqlDbType.DateTime).Value = giotanlam;

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
