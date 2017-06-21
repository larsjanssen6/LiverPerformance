using LivePerformance.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Repositories
{
    class CoalitieRepo
    {
        IConnection connection;

        public CoalitieRepo(IConnection conn)
        {
            connection = conn;
        }

        public void store(string name, List<Stem> stemmen, double zetels)
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("insert into coalitie values(@name, @zetels) select scope_identity()", connection.getConnection());
            connection.Connect();
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@zetels", zetels);
            sqlCommand.Connection = connection.getConnection();
            int coalitieId = (int)(decimal)sqlCommand.ExecuteScalar();

            foreach (Stem item in stemmen)
            {
                SqlCommand command = new SqlCommand("insert into coalitie_stemmen values(@coalitieId, @stemId) select scope_identity()", connection.getConnection());
                connection.Connect();
                command.Parameters.AddWithValue("@coalitieId", coalitieId);
                command.Parameters.AddWithValue("@stemId", item.getId());
                command.ExecuteNonQuery();
            }

            connection.disConnect();
        }
  }
}
