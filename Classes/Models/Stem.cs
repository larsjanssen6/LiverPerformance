using LivePerformance.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Repositories
{
    public class Stem
    {
        private int id;
        private int totaal;
        private Partij partij;
        private Verkiezing verkiezing;
        

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getTotaal()
        {
            return totaal;
        }

        public void setTotaal(int totaal)
        {
            this.totaal = totaal;
        }

        public void setPartij(Partij partij)
        {
            this.partij = partij;
        }

        public Partij getPartij()
        {
            return partij;
        }

        public void setVerkiezing(Verkiezing verkiezing)
        {
            this.verkiezing = verkiezing;
        }

        public Verkiezing getVerkiezing()
        {
            return verkiezing;
        }
    }
}
