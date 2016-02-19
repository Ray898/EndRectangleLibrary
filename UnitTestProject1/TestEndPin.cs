using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EndRectangleLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class TestEndPin
    {
        EndRectangle endRectangle = new EndRectangle();

        [TestMethod]
        public void TestWidthCalculation()
        {
            double inputWidth = 10;
            double clearance = 10;
            double endMill = .125;

            Assert.AreEqual(20.125,endRectangle.calculateWidth(inputWidth, clearance, endMill));
        }

        [TestMethod]
        public void TestHeightCalculation()
        {
            double inputThickness = 20;
            double endMill = .125;

            Assert.AreEqual(20.250, endRectangle.calculateHeight(inputThickness, endMill));
        }

        [TestMethod]
        public void TestX1Calculation()
        {
            double origin = 0.0;

            Assert.AreEqual(-.625, endRectangle.calulateX1(origin));
        }

        [TestMethod]
        public void TestX2Calculation()
        {
            double width = endRectangle._width;
            double origin = 0.0;
            double clearance = 10;
            double endMill = .125;

            Assert.AreEqual(10.125, endRectangle.calulateX2(width, origin, clearance, endMill));
        }

        [TestMethod]
        public void TestY1Calculation()
        {
            double origin = 0.0;

            Assert.AreEqual(-.625, endRectangle.calulateY1(origin));
        }

        [TestMethod]
        public void TestY2Calculation()
        {
            double origin = 0.0;

            Assert.AreEqual(-.625, endRectangle.calulateY2(origin));
        }

        [TestMethod]
        public void TestFirstRectangleCreation()
        {
        }

        [TestMethod]
        public void TestSecondtRectangleCreation()
        {
        }
    }
}
