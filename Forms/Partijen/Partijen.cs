﻿using LivePerformance.Classes;
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
    public partial class Partijen : Form
    {

        PartijenRepo partijenRepo;

        public Partijen()
        {
            InitializeComponent();
            partijenRepo = new PartijenRepo(new Connection());
            loadPartijen();
        }

        public void loadPartijen()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("naam");
            dt.Columns.Add("lijstrekker");

            foreach (Partij item in partijenRepo.index())
            {
                dt.Rows.Add(new object[] { item.getId(), item.getName(), item.getLijstrekker() });
            }

            lijstrekkersGrid.DataSource = dt;
        }

        private void btnAddPartij_Click(object sender, EventArgs e)
        {
          NewPartij newPartij = new NewPartij();
          newPartij.ShowDialog();
        }

        private void lijstrekkersGrid_SelectionChanged(object sender, EventArgs e)
        {
            
        }
  }
}