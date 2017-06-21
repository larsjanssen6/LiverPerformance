using LivePerformance.Classes;
using LivePerformance.Forms.Coalities;
using LivePerformance.Forms.Partijen;
using LivePerformance.Forms.Uitslagen;
using LivePerformance.Forms.Verkiezingen;
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
        }

        private void btnPartijen_Click(object sender, EventArgs e)
        {
            Partijen partijen = new Partijen();
            partijen.ShowDialog();
        }

        private void btnNewVerkiezing_Click(object sender, EventArgs e)
        {
            NewVerkiezing newVerkiezing = new NewVerkiezing();
            newVerkiezing.ShowDialog();
        }

        private void btnCoalitie_Click(object sender, EventArgs e)
        {
            Coalities coalities = new Coalities();
            coalities.ShowDialog();
        }

    private void button3_Click(object sender, EventArgs e)
    {
        Uitslagen uitslagen = new Uitslagen();
        uitslagen.ShowDialog();
    }
  }
}
