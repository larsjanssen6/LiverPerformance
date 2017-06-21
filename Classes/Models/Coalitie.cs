using LivePerformance.Classes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Models
{
    class Coalitie
    {
        List<Stem> stemmen;

        public void setStemmen(List<Stem> stemmen)
        {
            this.stemmen = stemmen;
        }

        public List<Stem> getStemmen()
        {
            return stemmen;
        }

        public bool checkIfCoalitieCanBeMade(int totalStemmen)
        {
            if(toZetels(countStemmen(), totalStemmen) > 75)
            {
                return true;
            }

            return false;
        }


        public int countStemmen()
        {
            int total = 0;

            foreach (Stem stem in stemmen)
            {
                total += stem.getTotaal();
            }

            return total;
        }

        public double toZetels(int partijStemmen, int totalStemmen)
        {
            return (double)partijStemmen / (double)totalStemmen * 150;
        }
    }
}
