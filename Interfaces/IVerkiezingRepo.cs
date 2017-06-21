using LivePerformance.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Interfaces
{
  interface IVerkiezingRepo
  {
      int store(Verkiezing verkiezing);
      int getTotalStemmen(int verkiezingId);
      bool find(int verkiezingId);
  }
}
