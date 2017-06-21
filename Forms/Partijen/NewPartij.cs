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

namespace LivePerformance.Forms.Partijen
{
      public partial class NewPartij : Form
      {
            IPartijenRepo partijenRepo;
            Partijen partijen;

            public NewPartij(Partijen partijen)
            {
                InitializeComponent();
                partijenRepo = new PartijenRepo(new Connection());
                this.partijen = partijen;
            }

            private void btnAddPartij_Click(object sender, EventArgs e)
            {
                
                try
                {
                    if (String.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtListTrekker.Text))
                    {
                      MessageBox.Show("Vul aub alle velden in");
                    }

                    else
                    {
                      //Maak een partij aan

                      string name = txtName.Text;
                      string listTrekker = txtListTrekker.Text;
                      Partij partij = new Partij();
                      partij.setNaam(name);
                      partij.setLijstrekker(listTrekker);

                      // Sla de partij op

                      txtListTrekker.Text = "";
                      txtName.Text = "";

                      partijenRepo.store(partij);
                      partijen.loadPartijen();

                      MessageBox.Show("Partij succesvol aangemaakt.");
                    }

                }

                catch (Exception ex)
                {
                  MessageBox.Show(ex.Message);
                }
    }
      }
}
