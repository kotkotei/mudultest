using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp5;
namespace Cylindertests
{
    [TestClass]
    public class Cylindertests
    {
        [TestMethod]
        public void Cylindervolume_12_21()
        {
            double h = 12;
            double r = 21;
            double rez = 16625.3;
            Cylinder g = new Cylinder();

            double rez2 = g.Cylindervolume(h, r);
            rez2 = Math.Round(rez2, 1);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void Cylindervolume_13_20()
        {
            double h = 13;
            double r = 20;
            double rez = 16336.28;
            Cylinder g = new Cylinder();

            double rez2 = g.Cylindervolume(h, r);
            rez2 = Math.Round(rez2, 2);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void Cylindervolume_10_6()
        {
            double h = 10;
            double r = 6;
            double rez = 1131;
            Cylinder g = new Cylinder();

            double rez2 = g.Cylindervolume(h, r);
            rez2 = Math.Round(rez2, 0);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void Cylindervolume_14_89()
        {
            double h = 14;
            double r = 89;
            double rez = 348383.8;
            Cylinder g = new Cylinder();

            double rez2 = g.Cylindervolume(h, r);
            rez2 = Math.Round(rez2, 1);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void Cylindervolume_5_4()
        {
            double h = 5;
            double r = 4;
            double rez = 251.3;
            Cylinder g = new Cylinder();

            double rez2 = g.Cylindervolume(h, r);
            rez2 = Math.Round(rez2, 1);
            Assert.AreEqual(rez, rez2);
        }
    }
}
