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
    class CoalitieRepo : ICoalitieRepo
    {
        IConnection connection;

        public CoalitieRepo(IConnection conn)
        {
            connection = conn;
        }

        public List<Coalitie> index()
        {
          Coalitie coalitie;
          List<Coalitie> coalities = new List<Coalitie>();

          connection.Connect();
          SqlCommand sqlCommand = new SqlCommand("select * from coalitie", connection.getConnection());

          SqlDataReader reader = sqlCommand.ExecuteReader();
          if (reader.HasRows)
          {
            while (reader.Read())
            {
              coalitie = new Coalitie();
              coalitie.setId(Convert.ToInt32(reader["id"]));
              coalitie.setNaam(reader["naam"].ToString());
              coalitie.setZetels(Convert.ToInt32(reader["zetel"]));
              coalities.Add(coalitie);
            }
          }

          return coalities;
        }

        public void store(Coalitie coalitie, List<Stem> stemmen, double zetels)
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("insert into coalitie values(@name, @zetels) select scope_identity()", connection.getConnection());
            connection.Connect();
            sqlCommand.Parameters.AddWithValue("@name", coalitie.getName());
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
        
        public List<Coalitie>find(int coalitieId)
        {
            Coalitie coalitie;
            List<Coalitie> coalities = new List<Coalitie>();

            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("select c.naam as naam, p.naam as partij from coalitie c inner join coalitie_stemmen cs on c.id = cs.coalitie_id inner join stem s on s.id = cs.stem_id inner join partij p on p.id = s.partij_id where c.id = @coalitieId", connection.getConnection());
            sqlCommand.Parameters.AddWithValue("@coalitieId", coalitieId);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
              while (reader.Read())
              {
                coalitie = new Coalitie();
                coalitie.setNaam(reader["naam"].ToString());
                coalitie.setPartij(reader["partij"].ToString());
                coalities.Add(coalitie);
              }
            }

            return coalities;
        }
    }
}
