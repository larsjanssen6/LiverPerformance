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
    public partial class NewVerkiezing : Form
    {

        VerkiezingRepo verkiezingenRepo;

        public NewVerkiezing()
        {
            InitializeComponent();
            verkiezingenRepo = new VerkiezingRepo(new Connection());
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if(String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vul a.u.b een verkiezings naam in.");
            }

            else
            {
              Verkiezing verkiezing = new Verkiezing();
              verkiezing.setNaam(name);
              int id = verkiezingenRepo.store(verkiezing);

              VerkiezingenStemmen verkiezingenStemmen = new VerkiezingenStemmen(id);
              verkiezingenStemmen.ShowDialog();
            }
        }
    }
}
