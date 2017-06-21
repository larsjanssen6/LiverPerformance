using LivePerformance.Classes;
using LivePerformance.Classes.Models;
using LivePerformance.Classes.Repositories;
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
        StemRepo stemRepo;
        VerkiezingRepo verkiezingRepo;
        CoalitieRepo coalitieRepo;

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
                dt.Rows.Add(new object[] { item.getId(), item.getVerkiezing().getNaam(), item.getPartij().getName(), item.getTotaal() });
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
                  dt.Rows.Add(new object[] { item.getId(), item.getVerkiezing().getNaam(), item.getPartij().getName(), item.getTotaal() });
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

            int totalStemmen = verkiezingRepo.getTotalStemmen(verkiezingId);

            if (coalitie.checkIfCoalitieCanBeMade(totalStemmen))
            {
                double zetels = coalitie.toZetels(coalitie.countStemmen(), totalStemmen);
                coalitieRepo.store(coalitieName, coalitieStemmen, zetels);
                MessageBox.Show("Coalitie opgeslagen met " + zetels.ToString() + " zetels.");
            }

            else
            {
                MessageBox.Show("Formatie kan niet worden gevormd!");
            }
        }
    }
}
