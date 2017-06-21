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

namespace LivePerformance.Forms.Verkiezingen
{
    public partial class PartijPunten : Form
    {
        IPartijenRepo partijRepo;
        IStemRepo stemRepo;
        VerkiezingenStemmen verkiezingenStemmen;
        int partijId = 0;

        int verkiezingsId;

        public PartijPunten(int verkiezingsId, VerkiezingenStemmen verkiezingenStemmen)
        {
            InitializeComponent();
            partijRepo = new PartijenRepo(new Connection());
            stemRepo = new StemRepo(new Connection());
            this.verkiezingenStemmen = verkiezingenStemmen;
            this.verkiezingsId = verkiezingsId;
            loadPartijen();
        }

        public void loadPartijen()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("id");
                dt.Columns.Add("naam");

                foreach (Partij item in partijRepo.index())
                {
                  dt.Rows.Add(new object[] { item.getId(), item.getNaam() });
                }

                gridPartijen.DataSource = dt;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (partijId <= 0)
                {
                    MessageBox.Show("Selecteer a.u.b eerst een partij.");
                }

                else
                {
                    int stemmen = Convert.ToInt32(txtStemmen.Value);

                    stemRepo.store(verkiezingsId, partijId, stemmen);
                    verkiezingenStemmen.loadStemmen();
                    MessageBox.Show("Partij succesvol toegevoegd");
                    this.Close();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridPartijen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = gridPartijen.Rows[index];
                partijId = Convert.ToInt32(selectedRow.Cells[0].Value);
                MessageBox.Show("Partij: " + selectedRow.Cells[1].Value.ToString() + " geselecteerd");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
    }
}
