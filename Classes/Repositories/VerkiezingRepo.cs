using LivePerformance.Classes.Models;
using LivePerformance.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Repositories
{
    class VerkiezingRepo
    {
        IConnection connection;

        public VerkiezingRepo(IConnection conn)
        {
            connection = conn;
        }

        public int store(Verkiezing verkiezing)
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("insert into verkiezing values(@name, @date) select scope_identity()", connection.getConnection());
            connection.Connect();
            sqlCommand.Parameters.AddWithValue("@name", verkiezing.getNaam());
            sqlCommand.Parameters.AddWithValue("@date", DateTime.Now);
            sqlCommand.Connection = connection.getConnection();
            int id = (int)(decimal)sqlCommand.ExecuteScalar();
            connection.disConnect();
            return id;
        }

        public int getTotalStemmen(int verkiezingId)
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("select sum(totaal) as total from stem where verkiezing_id = @verkiezingsId", connection.getConnection());
             connection.Connect();
            sqlCommand.Parameters.AddWithValue("@verkiezingsId", verkiezingId);
            sqlCommand.Connection = connection.getConnection();
            int id = (int)sqlCommand.ExecuteScalar();
            connection.disConnect();
            return id;
        }
    }
}
