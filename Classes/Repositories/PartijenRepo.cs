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
    public class PartijenRepo
    {
          IConnection connection;

          public PartijenRepo(IConnection conn)
          {
              connection = conn;
          }

         public List<Partij> index()
         {
            Partij partij;
            List<Partij> partijen = new List<Partij>();

              connection.Connect();
              SqlCommand sqlCommand = new SqlCommand("select id, naam, lijstrekker from partij", connection.getConnection());

              SqlDataReader reader = sqlCommand.ExecuteReader();
              if (reader.HasRows)
              {
                  while (reader.Read())
                  {
                      partij = new Partij();
                      partij.setId(Convert.ToInt32(reader["id"]));
                      partij.setName(reader["naam"].ToString());
                      partij.setLijstrekker(reader["lijstrekker"].ToString());
                      partijen.Add(partij);
                  }
              }
    
            return partijen;
         }

         public void store(Partij partij)
         {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("insert into partij values(@name, @lijstrekker)", connection.getConnection());
            connection.Connect();
            sqlCommand.Parameters.AddWithValue("@name", partij.getName());
            sqlCommand.Parameters.AddWithValue("@lijstrekker", partij.getLijstrekker());
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection = connection.getConnection();
         }
    }
}
