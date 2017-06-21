using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Models
{
    class Verkiezing
    {
        private int id;
        private string naam;
        private DateTime date;

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setNaam(string naam)
        {
            this.naam = naam;
        }

        public string getNaam()
        {
            return naam;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public DateTime getDate()
        {
            return date;
        }
    }
}
