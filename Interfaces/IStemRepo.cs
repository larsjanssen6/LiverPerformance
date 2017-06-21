using LivePerformance.Classes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Interfaces
{
  interface IStemRepo
  {
      List<Stem> index(int id);
      Stem find(int id);
      void store(int verkiezingsId, int partijId, int totaal);
  }
}
