using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox;
using System;

namespace TestFigure
{
    [TestClass]
    public class FiguresCalculatorTest
    {
        [TestMethod]
        public void TestCalcAreaCircle()
        {
            var R = 100;
            var area = Figures.CalcArea("Circle", 2, 3, R);
            Assert.AreEqual(R * R * Math.PI, area, 0.2);
        }

        [TestMethod]
        public void TestCalcAreaTriangle()
        {
            var A = 100;
            var B = 100;
            var C = 150;
            var p = (A + B + C) / 2;
            var eArea = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            var area = Figures.CalcArea("Triangle", A, B, C);
            Assert.AreEqual(eArea, area, 0.2);
        }

        [TestMethod]
        public void TestCheckTriangle()
        {
            var A = 100;
            var B = 190;
            var C = (float)Math.Sqrt(A * A + B * B);
            var figure = (Triangle)Figures.CreateFigure("Triangle", A, B, C);
            Assert.AreEqual(figure.IsRightTriangle, true);
        }
    }
}
