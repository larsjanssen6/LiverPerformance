using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Models
{
    public class Partij
    {
        private int id;
        private string naam;
        private string lijstrekker;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNaam()
        {
            return naam;
        }

        public void setNaam(string name)
        {
            this.naam = name;
        }

        public void setLijstrekker(string lijstrekker)
        {
            this.lijstrekker = lijstrekker;
        }

        public string getLijstrekker()
        {
            return lijstrekker;
        }
    }
}
