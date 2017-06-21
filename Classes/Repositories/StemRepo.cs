using LivePerformance.Classes.Models;
using LivePerformance.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Repositories
{
    class StemRepo
    {
        IConnection connection;

        public StemRepo(IConnection conn)
        {
            connection = conn;
        }

        public List<Stem> index(int id)
        {
            Stem stem;
            List<Stem> stemmen = new List<Stem>();

            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("select s.id, p.naam as partij, v.naam as verkiezing, s.totaal as totaal from stem s inner join verkiezing v on v.id = s.verkiezing_id inner join partij p on s.partij_id = p.id where v.id = @verkiezingsId", connection.getConnection());
            sqlCommand.Parameters.AddWithValue("@verkiezingsId", id);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                  stem = new Stem();
                  Partij partij = new Partij();
                  partij.setName(reader["partij"].ToString());
                  Verkiezing verkiezing = new Verkiezing();
                  verkiezing.setNaam(reader["verkiezing"].ToString());
                  stem.setVerkiezing(verkiezing);
                  stem.setPartij(partij);
                  stem.setId(Convert.ToInt32(reader["id"]));
                  stem.setTotaal(Convert.ToInt32(reader["totaal"]));
                  stemmen.Add(stem);
                }
            }

            return stemmen;
        }

        public Stem find(int id)
        {
          Stem stem = new Stem();

          connection.Connect();
          SqlCommand sqlCommand = new SqlCommand("select s.id, p.naam as partij, v.naam as verkiezing, s.totaal as totaal from stem s inner join verkiezing v on v.id = s.verkiezing_id inner join partij p on s.partij_id = p.id where s.id = @stemId", connection.getConnection());
          sqlCommand.Parameters.AddWithValue("@stemId", id);

          SqlDataReader reader = sqlCommand.ExecuteReader();
          if (reader.HasRows)
          {
            while (reader.Read())
            {
              stem = new Stem();
              Partij partij = new Partij();
              partij.setName(reader["partij"].ToString());
              Verkiezing verkiezing = new Verkiezing();
              verkiezing.setNaam(reader["verkiezing"].ToString());
              stem.setVerkiezing(verkiezing);
              stem.setPartij(partij);
              stem.setId(Convert.ToInt32(reader["id"]));
              stem.setTotaal(Convert.ToInt32(reader["totaal"]));
            }
          }

          return stem;
        }

        public void store(int verkiezingsId, int partijId, int totaal)
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("insert into stem values(@verkiezing_id, @partij_id, @totaal)", connection.getConnection());
            connection.Connect();
            sqlCommand.Parameters.AddWithValue("@verkiezing_id", verkiezingsId);
            sqlCommand.Parameters.AddWithValue("@partij_id", partijId);
            sqlCommand.Parameters.AddWithValue("@totaal", totaal);
            sqlCommand.Connection = connection.getConnection();
            sqlCommand.ExecuteNonQuery();
            connection.disConnect();
        }
    }
}
