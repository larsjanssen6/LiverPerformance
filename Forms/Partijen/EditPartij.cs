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

namespace LivePerformance.Forms.Partijen
{
    public partial class EditPartij : Form
    {

        PartijenRepo partijenRepo;
        Partijen partijen;
        Partij partij;
        int partijId;

        public EditPartij(int partijId, Partijen partijen)
        {
            InitializeComponent();
            partijenRepo = new PartijenRepo(new Connection());
            this.partijId = partijId;
            this.partijen = partijen;
            loadPartij();
        }

        public void loadPartij()
        {
            partij = partijenRepo.find(partijId);
            txtName.Text = partij.getName();
            txtListTrekker.Text = partij.getLijstrekker();
        }

        private void btnUpdatePartij_Click(object sender, EventArgs e)
        {
            partij.setLijstrekker(txtListTrekker.Text);
            partij.setName(txtName.Text);
            partijenRepo.update(partij);
            partijen.loadPartijen();

            MessageBox.Show("Partij succesvol geupdatet!");
        }
    }
}
