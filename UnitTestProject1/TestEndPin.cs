using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EndRectangleLibrary;
using System.Diagnostics;

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
            double clearance = 1;
            double endMill = .125;

            double testResult = endRectangle.calculateWidth(inputWidth, clearance, endMill);
            Assert.AreEqual(11.125,testResult);
        }

        [TestMethod]
        public void TestHeightCalculation()
        {
            double inputThickness = 20;
            double endMill = .125;

            double testResult = endRectangle.calculateHeight(inputThickness, endMill);
            Assert.AreEqual(20.250, testResult);
        }

        [TestMethod]
        public void TestX1Calculation()
        {
            double origin = 0.0;
            double difference = .625;
            double testResult = endRectangle.calulateX1(origin, difference);
            Assert.AreEqual(-.625, testResult);
        }

        [TestMethod]
        public void TestX2Calculation()
        {
            double width =20.125;
            double origin = 0.0;
            double clearance = 1;
            double endMill = .125;

            double testResult = endRectangle.calulateX2(width, origin, clearance, endMill);
            Assert.AreEqual(21.25, testResult);
        }

        [TestMethod]
        public void TestY1Calculation()
        {
            double origin = 0.0;
            double difference = .625;

            double testResult = endRectangle.calulateY1(origin, difference);
            Assert.AreEqual(-.625, testResult);
        }

        [TestMethod]
        public void TestY2Calculation()
        {
            double origin = 0.0;

            double testResult = endRectangle.calulateY2(origin);
            Assert.AreEqual(-.625, testResult);
        }

        [TestMethod]
        public void TestFirstRectangleCreation()
        {
            TestHeightCalculation();
            TestWidthCalculation();
            TestX1Calculation();
            TestX2Calculation();
            TestY1Calculation();
            TestY2Calculation();

            //x,y  x->  y-v
            double[,] expectedRectangleCords = new double[4,4];
            expectedRectangleCords[0, 0] =  -.625;
            expectedRectangleCords[0, 1] =  -.625;
            
            expectedRectangleCords[1, 0] =  10.5;
            expectedRectangleCords[1, 1] =  -.625;

            expectedRectangleCords[2, 0] =  10.5;
            expectedRectangleCords[2, 1] =  10.625;

            expectedRectangleCords[3, 0] =  -.625;
            expectedRectangleCords[3, 1] =  10.625;

            double[,] realRectangleCords = new double[3, 1];
            realRectangleCords = endRectangle.createRectangle1();
                       
            for (int i = 0; i < expectedRectangleCords.GetLength(0); i++)
            {
                for(int j = 0; i < expectedRectangleCords.GetLength(1); i++)
                {
                    Assert.AreEqual(expectedRectangleCords[i, j], realRectangleCords[i, j]);
                }
            }
            
        }

        [TestMethod]
        public void TestSecondtRectangleCreation()
        {
            TestHeightCalculation();
            TestWidthCalculation();
            TestX1Calculation();
            TestX2Calculation();
            TestY1Calculation();
            TestY2Calculation();

            //x,y  x->  y-v
            double[,] expectedRectangleCords = new double[4, 4];
            expectedRectangleCords[0, 0] = 21.25;
            expectedRectangleCords[0, 1] = -.625;

            expectedRectangleCords[1, 0] = 32.375;
            expectedRectangleCords[1, 1] = -.625;

            expectedRectangleCords[2, 0] = 32.375;
            expectedRectangleCords[2, 1] = 10.625;

            expectedRectangleCords[3, 0] = 21.25;
            expectedRectangleCords[3, 1] = 10.625;

            double[,] realRectangleCords = new double[3, 1];
            realRectangleCords = endRectangle.createRectangle2();

            for (int i = 0; i < expectedRectangleCords.GetLength(0); i++)
            {
                for (int j = 0; i < expectedRectangleCords.GetLength(1); i++)
                {
                    Assert.AreEqual(expectedRectangleCords[i, j], realRectangleCords[i, j]);
                }
            }
        }
    }
}
