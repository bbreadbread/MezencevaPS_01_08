using Microsoft.VisualStudio.TestTools.UnitTesting;

using SportCL;

using System;

namespace UnitTestProjectSport
{
    [TestClass]
    public class UnitTestSports
    {
        [TestMethod]
        public void TestMethod_BaseQ()
        {
            Athlete athlete = new Athlete(168, 18, 65);
            Assert.AreEqual(2096.8, athlete.Q(), 0.01);

        }
        [TestMethod]
        public void TestMethod_Print()
        {
            Athlete athlete = new Athlete(168, 18, 65);
            Assert.AreEqual("Рост: 168, возраст: 18, вес: 65", athlete.Print());
        }
        [TestMethod]
        public void TestMethod_DoutherQ_Fit()
        {
            Athlete athlete = new FitOrFat(168, 18, 65, "fit");
            Assert.AreEqual(1496.8, athlete.Q(), 0.01);
        }
        [TestMethod]
        public void TestMethod_DoutherQ_Fat()
        {
            Athlete athlete = new FitOrFat(168, 18, 65, "fat");
            Assert.AreEqual(2996.8, athlete.Q(), 0.01);
        }
    }
}
