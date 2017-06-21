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
    public partial class MaakCoalitie : Form
    {
        int verkiezingId;
        IStemRepo stemRepo;
        IVerkiezingRepo verkiezingRepo;
        ICoalitieRepo coalitieRepo;

        List<Stem> coalitieStemmen;

        public MaakCoalitie(int verkiezingId)
        {
            InitializeComponent();
            this.verkiezingId = verkiezingId;
            stemRepo = new StemRepo(new Connection());
            verkiezingRepo = new VerkiezingRepo(new Connection());
            coalitieRepo = new CoalitieRepo(new Connection());
            coalitieStemmen = new List<Stem>();
            loadPartijen();
        }

        public void loadPartijen()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("Verkiezing");
            dt.Columns.Add("Partij");
            dt.Columns.Add("Stemmen");

            foreach (Stem item in stemRepo.index(verkiezingId))
            {
                dt.Rows.Add(new object[] { item.getId(), item.getVerkiezing().getNaam(), item.getPartij().getNaam(), item.getTotaal() });
            }

            gridPartijen.DataSource = dt;
        }

        public void loadCoalitie()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("Verkiezing");
            dt.Columns.Add("Partij");
            dt.Columns.Add("Stemmen");

            
            if(coalitieStemmen.Any())
            {
                foreach (Stem item in coalitieStemmen)
                {
                  dt.Rows.Add(new object[] { item.getId(), item.getVerkiezing().getNaam(), item.getPartij().getNaam(), item.getTotaal() });
                }

                gridCoalities.DataSource = dt;
            }
        }

        private void gridPartijen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = gridPartijen.Rows[index];
            int stemId = Convert.ToInt32(selectedRow.Cells[0].Value);
            gridPartijen.Rows.RemoveAt(e.RowIndex);
            coalitieStemmen.Add(stemRepo.find(stemId));
            loadCoalitie();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            Coalitie coalitie = new Coalitie();
            coalitie.setStemmen(coalitieStemmen);

            string coalitieName = txtCoalitieNaam.Text;
            coalitie.setNaam(coalitieName);

            int totalStemmen = verkiezingRepo.getTotalStemmen(verkiezingId);

            if (coalitie.checkIfCoalitieCanBeMade(totalStemmen))
            {
                double zetels = coalitie.toZetels(coalitie.countStemmen(), totalStemmen);
                coalitieRepo.store(coalitie, coalitieStemmen, zetels);
                MessageBox.Show("Coalitie opgeslagen met " + zetels.ToString() + " zetels.");
            }

            else
            {
                MessageBox.Show("Formatie kan niet worden gevormd!");
            }
        }

        private void btnExportCoalitie_Click(object sender, EventArgs e)
        {
            string[] lines = { "First line", "Second line", "Third line" };

            using (System.IO.StreamWriter file =
             new System.IO.StreamWriter(@"C:\WriteLines2.txt"))
            {
              foreach (string line in lines)
              {
                // If the line doesn't contain the word 'Second', write the line to the file.
                if (!line.Contains("Second"))
                {
                  file.WriteLine(line);
                }
              }
            }



            //Coalitie coalitie = new Coalitie();
            //coalitie.setStemmen(coalitieStemmen);

      //string coalitieName = txtCoalitieNaam.Text;
      //coalitie.setNaam(coalitieName);

      //int totalStemmen = verkiezingRepo.getTotalStemmen(verkiezingId);

      //if (coalitie.checkIfCoalitieCanBeMade(totalStemmen))
      //{
      //    string[] lines = { "First line", "Second line", "Third line" };
      //    // WriteAllLines creates a file, writes a collection of strings to the file,
      //    // and then closes the file.  You do NOT need to call Flush() or Close().
      //    System.IO.File.WriteAllLines(@"C:\Users\WriteLines.txt", lines);
      //}

      //else
      //{
      //    MessageBox.Show("Formatie kan niet worden gevormd!");
      //}
    }
    }
}
