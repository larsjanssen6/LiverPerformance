using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LivePerformance.Classes.Repositories;
using LivePerformance.Classes;
using LivePerformance.Classes.Models;

namespace UnitTests
{
  [TestClass]
  public class UnitTest1
  {
    VerkiezingRepo verkiezingRepo;

    public UnitTest1()
    {
      verkiezingRepo = new VerkiezingRepo(new Connection());
    }

    [TestMethod]
    public void a_verkiezing_object_can__be_created()
    {
      Verkiezing verkiezing = new Verkiezing();
      verkiezing.setNaam("2017");

      Assert.AreEqual(verkiezing.getNaam(), "2017");
    }

    [TestMethod]
    public void a_verkiezing_can__be_created_in_database()
    {
        Verkiezing verkiezing = new Verkiezing();
        verkiezing.setNaam("2017");
        int verkiezingId = verkiezingRepo.store(verkiezing);

        Assert.IsTrue(verkiezingRepo.find(verkiezingId));
    }
  }
}
