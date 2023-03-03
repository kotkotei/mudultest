using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp5;

namespace Geometrytests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReactangleArea_5_7()
        {
            int a = 5;
            int b = 7;
            int rez = 35;
            Geometry g = new Geometry();
            int rez2 = g.ReactangleArea(a, b);
            Assert.AreEqual(rez, rez2);
        }


        [TestMethod]
        public void ReactangleArea_5_4()
        {
            int a = 5;
            int b = 4;
            int rez = 20;
            Geometry g = new Geometry();
            int rez2 = g.ReactangleArea(a, b);
            Assert.AreEqual(rez, rez2);
        }

        [TestMethod]
        public void ReactangleArea_5_6()
        {
            int a = 5;
            int b = 6;
            int rez = 30;
            Geometry g = new Geometry();
            int rez2 = g.ReactangleArea(a, b);
            Assert.AreEqual(rez, rez2);
        }
    }
}
