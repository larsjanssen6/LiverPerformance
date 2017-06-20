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
        private string name;
        private string lijstrekker;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
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
