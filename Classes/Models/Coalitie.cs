using LivePerformance.Classes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Classes.Models
{
    public class Coalitie
    {
        private List <Stem> stemmen;
        private int id;
        private int zetels;
        private string naam;
        private string partij;
        
        public string getPartij()
        {
            return partij;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
          this.id = id;
        }

        public void setPartij(string partij)
        {
            this.partij = partij;
        }

        public void setZetels(int zetels)
        {
            this.zetels = zetels;
        }

        public int getZetels()
        {
            return zetels;
        }

        public string getName()
        {
            return naam;
        }

        public void setNaam(string naam)
        {
            this.naam = naam;
        }

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
            return Math.Round((double)partijStemmen / (double)totalStemmen * 150);
        }

        private double getMaxVotes(int totalStemmen)
        {
           return stemmen.Max(x => x.getTotaal());
        }

        public Stem getLijstrekker(int totalStemmen)
        {
            Stem toReturn = null;

            foreach (Stem stem in stemmen)
            {
                if(stem.getTotaal() == getMaxVotes(totalStemmen))
                {
                    toReturn = stem;
                }
            }

            return toReturn;
        }
    }
}
