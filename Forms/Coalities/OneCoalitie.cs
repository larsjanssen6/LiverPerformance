using LivePerformance.Classes;
using LivePerformance.Classes.Models;
using LivePerformance.Classes.Repositories;
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

namespace LivePerformance.Forms.Coalities
{
  public partial class OneCoalitie : Form
  {
      ICoalitieRepo coalitieRepo;
      int coalitieId;

      public OneCoalitie(int coalitieId)
      {
          InitializeComponent();
          this.coalitieId = coalitieId;
          coalitieRepo = new CoalitieRepo(new Connection());
          getCoalitie();
      }

      public void getCoalitie()
      {
          try
          {
              DataTable dt = new DataTable();

              dt.Columns.Add("naam");
              dt.Columns.Add("partij");

              foreach (Coalitie item in coalitieRepo.find(coalitieId))
              {
                dt.Rows.Add(new object[] { item.getName(), item.getPartij() });
              }

              gridOneCoalitie.DataSource = dt;
          }

          catch(Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
      }
  }
}
