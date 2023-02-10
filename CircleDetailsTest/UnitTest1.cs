using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ass2;
using NUnit.Framework;

namespace ass2.Tests
{
    [TestClass]
    public class CircleDetailsTest
    {
        private CircleDetails circleDetails;

        [TestInitialize]
        public void TestInitialize()
        {
            circleDetails = new CircleDetails(5);
        }

        [TestMethod]
        public void TestGetRadius_r5_out5()
        {
            int expected = 5;
            int actual = circleDetails.GetRadius();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetRadius_r12_out12()
        {
            CircleDetails lshapeCircle = new CircleDetails(12);
            int expected = 12;
            int actual = lshapeCircle.GetRadius();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSetRadius_r10_out10()
        {
            int expected = 10;
            circleDetails.SetRadius(10);
            int actual = circleDetails.GetRadius();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSetRadius_r1000_out1000()
        {
            int expected = 1000;
            circleDetails.SetRadius(1000);
            int actual = circleDetails.GetRadius();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetCircumference_r5_out31_42()
        {
            double expected = 31.42;
            double actual = circleDetails.GetCircumference();
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void TestGetCircumference_r22_out138_23()
        {
            CircleDetails lshapeCircle = new CircleDetails(22);
            double expected = 138.23;
            double actual = lshapeCircle.GetCircumference();
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void TestGetArea_r5_out78_53()
        {
            double expected = 78.53;
            double actual = circleDetails.GetArea();
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void TestGetArea_r22_out1520_53()
        {
            CircleDetails lshapeCircle = new CircleDetails(22);
            double expected = 1520.53;
            double actual = lshapeCircle.GetArea();
            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
