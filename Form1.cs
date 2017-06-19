using LivePerformance.Classes;
using LivePerformance.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance
{
    public partial class Form1 : Form
    {
        private IConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new Connection();
            testConnection();
        }

        public void testConnection()
        {
            connection.Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from test", connection.getConnection());
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MessageBox.Show(reader["test"].ToString());
                }
            }

            connection.disConnect();
        }
    }
}
