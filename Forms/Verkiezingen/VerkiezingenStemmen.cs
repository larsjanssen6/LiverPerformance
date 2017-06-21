using LivePerformance.Classes;
using LivePerformance.Classes.Repositories;
using LivePerformance.Forms.Coalities;
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

namespace LivePerformance.Forms.Verkiezingen
{
    public partial class VerkiezingenStemmen : Form
    {
        int verkiezingsId;
        IStemRepo stemRepo;

        public VerkiezingenStemmen(int verkiezingsId)
        {
            InitializeComponent();
            stemRepo = new StemRepo(new Connection());
            this.verkiezingsId = verkiezingsId;
            this.loadStemmen();
        }

        public void loadStemmen()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Verkiezing");
                dt.Columns.Add("Partij");
                dt.Columns.Add("Stemmen");

                foreach (Stem item in stemRepo.index(verkiezingsId))
                {
                  dt.Rows.Add(new object[] { item.getVerkiezing().getNaam(), item.getPartij().getNaam(), item.getTotaal() });
                }

                gridStemmen.DataSource = dt;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnAddPartij_Click(object sender, EventArgs e)
        {

            try
            {
                PartijPunten partijPunten = new PartijPunten(verkiezingsId, this);
                partijPunten.ShowDialog();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void btnMakeCoalitie_Click(object sender, EventArgs e)
        {
            try
            {
                MaakCoalitie newVerkiezingen = new MaakCoalitie(verkiezingsId);
                newVerkiezingen.ShowDialog();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }
    }
}
