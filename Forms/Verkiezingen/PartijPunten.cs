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

namespace LivePerformance.Forms.Verkiezingen
{
    public partial class PartijPunten : Form
    {
        PartijenRepo partijRepo;
        StemRepo stemRepo;
        VerkiezingenStemmen verkiezingenStemmen;
        int partijId;

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
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("naam");

            foreach (Partij item in partijRepo.index())
            {
                dt.Rows.Add(new object[] { item.getId(), item.getName() });
            }

            gridPartijen.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(partijId.ToString()))
            {
                int stemmen = Convert.ToInt32(txtStemmen.Value);

                stemRepo.store(verkiezingsId, partijId, stemmen);
                verkiezingenStemmen.loadStemmen();
            }

            else
            {
                MessageBox.Show("Selecteer a.u.b eerst een partij.");
            }
          
        }

        private void gridPartijen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = gridPartijen.Rows[index];
            partijId = Convert.ToInt32(selectedRow.Cells[0].Value);
            MessageBox.Show("Partij: " + selectedRow.Cells[1].Value.ToString() + " geselecteerd");
        }
    }
}
