using LivePerformance.Classes.Models;
using LivePerformance.Classes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Interfaces
{
  interface ICoalitieRepo
  {
      void store(Coalitie coalitie, List<Stem> stemmen, double zetels);
  }
}
