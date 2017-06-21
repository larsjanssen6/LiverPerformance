using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LivePerformance.Classes.Repositories;
using LivePerformance.Classes;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        PartijenRepo partijenRepo;

        public UnitTest1()
        {
            partijenRepo = new PartijenRepo(new Connection());
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
