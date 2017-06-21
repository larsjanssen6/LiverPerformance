using LivePerformance.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Interfaces
{
  interface IPartijenRepo
  {
      List<Partij> index();
      void store(Partij partij);
      void update(Partij partij);
      Partij find(int id);
  }
}
