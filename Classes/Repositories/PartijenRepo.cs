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
  public class PartijenRepo : IPartijenRepo
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
            partij.setNaam(reader["naam"].ToString());
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
      sqlCommand.Parameters.AddWithValue("@name", partij.getNaam());
      sqlCommand.Parameters.AddWithValue("@lijstrekker", partij.getLijstrekker());
      sqlCommand.ExecuteNonQuery();
      sqlCommand.Connection = connection.getConnection();
    }

    public void update(Partij partij)
    {
      connection.Connect();
      SqlCommand sqlCommand = new SqlCommand("update partij set naam = @name, lijstrekker = @lijstrekker where id = @id", connection.getConnection());
      connection.Connect();
      sqlCommand.Parameters.AddWithValue("@name", partij.getNaam());
      sqlCommand.Parameters.AddWithValue("@lijstrekker", partij.getLijstrekker());
      sqlCommand.Parameters.AddWithValue("@id", partij.getId());
      sqlCommand.ExecuteNonQuery();
      sqlCommand.Connection = connection.getConnection();
    }

    public Partij find(int id)
    {
        Partij partij = new Partij();

        connection.Connect();
        SqlCommand sqlCommand = new SqlCommand("select * from partij where id = @id", connection.getConnection());
        sqlCommand.Parameters.AddWithValue("@id", id);
        SqlDataReader reader = sqlCommand.ExecuteReader();

        if (reader.HasRows)
        {
          while (reader.Read())
          {
            partij.setId(Convert.ToInt32(reader["id"]));
            partij.setNaam(reader["naam"].ToString());
            partij.setLijstrekker(reader["lijstrekker"].ToString());
          }
        }

        connection.disConnect();
        return partij;
    }
  }
}
