using LivePerformance.Classes;
using LivePerformance.Classes.Repositories;
using LivePerformance.Forms.Verkiezingen;
using LivePerformance.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance.Forms.Uitslagen
{
  public partial class Uitslagen : Form
  {
      IStemRepo stemRepo;

      public Uitslagen()
      {
          InitializeComponent();
          stemRepo = new StemRepo(new Connection());
          getUitslagen();
      }

      public void getUitslagen()
      {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("verkiezingsId");
                dt.Columns.Add("Verkiezing");
                dt.Columns.Add("Partij");
                dt.Columns.Add("Stemmen");


                foreach (Stem item in stemRepo.all())
                {
                  dt.Rows.Add(new object[] { item.getVerkiezing().getId(), item.getVerkiezing().getNaam(), item.getPartij().getNaam(), item.getTotaal() });
                }

                gridUitslagen.DataSource = dt;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
      }

      private void gridUitslagen_CellClick(object sender, DataGridViewCellEventArgs e)
      {
          try
          {
              int index = e.RowIndex;
              DataGridViewRow selectedRow = gridUitslagen.Rows[index];
              VerkiezingenStemmen partijPunten = new VerkiezingenStemmen(Convert.ToInt32(selectedRow.Cells[0].Value));
              partijPunten.ShowDialog();
          }
          
          catch(Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
      }
  }
}
