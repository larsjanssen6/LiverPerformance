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
    public partial class Coalities : Form
    {
        ICoalitieRepo coalitieRepo;

        public Coalities()
        {
            InitializeComponent();
            coalitieRepo = new CoalitieRepo(new Connection());
            loadCoalities();
        }

        public void loadCoalities()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("id");
                dt.Columns.Add("naam");
                dt.Columns.Add("zetels");

                foreach (Coalitie item in coalitieRepo.index())
                {
                  dt.Rows.Add(new object[] { item.getId(), item.getName(), item.getZetels() });
                }

                gridCoalities.DataSource = dt;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void gridCoalities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = gridCoalities.Rows[index];
                OneCoalitie oneCoalitie = new OneCoalitie(Convert.ToInt32(selectedRow.Cells[0].Value));
                oneCoalitie.ShowDialog();
            }
           
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
