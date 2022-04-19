#UnitTest1.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPLib;
using System;
using System.Collections.Generic;


namespace CompanyCoreLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testprozent()
        {
            int min;
            min = Program.Skidkaprozent(5, 10, 15);
            Assert.AreEqual(5, min);
        }
        [TestMethod]
        public void SkidkaMunis()
        {
            int value = Program.Calculate(500, 50);
            Assert.AreEqual(450, value, "от 5 книг скидка 10% получается 450 руб");
        }
        [TestMethod]
        public void SkidkaMunis1()
        {
            int value = Program.Calculate(500, 75);
            Assert.AreEqual(425, value, "от 3 книг скидка 15% получается 425 руб");
        }
        [TestMethod]
        public void SkidkaMunis2()
        {
            int value = Program.Calculate(500, 25);
            Assert.AreEqual(475, value, "от 3 книг скидка 5% получается 475 руб");
        }
    }
}
