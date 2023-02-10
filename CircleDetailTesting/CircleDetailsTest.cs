global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleApplication;


namespace CircleApplication.Tests
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
            int right = 5;
            int real = circleDetails.GetRadius();
            Assert.AreEqual(right, real);
        }

        [TestMethod]
        public void TestGetRadius_r12_out12()
        {
            CircleDetails mshape = new CircleDetails(12);
            int right = 12;
            int real = mshape.GetRadius();
            Assert.AreEqual(right, real);
        }

        [TestMethod]
        public void TestSetRadius_r10_out10()
        {
            int right = 10;
            circleDetails.SetRadius(10);
            int real = circleDetails.GetRadius();
            Assert.AreEqual(right, real);
        }

        [TestMethod]
        public void TestSetRadius_r1000_out1000()
        {
            int right = 1000;
            circleDetails.SetRadius(1000);
            int real = circleDetails.GetRadius();
            Assert.AreEqual(right, real);
        }

        [TestMethod]
        public void TestGetCircumference_r5_out31_42()
        {
            double right = 31.42;
            double real = circleDetails.GetCircumference();
            Assert.AreEqual(right, real, 0.01);
        }

        [TestMethod]
        public void TestGetCircumference_r22_out138_23()
        {
            CircleDetails mshape = new CircleDetails(22);
            double right = 138.23;
            double real = mshape.GetCircumference();
            Assert.AreEqual(right, real, 0.01);
        }

        [TestMethod]
        public void TestGetArea_r5_out78_53()
        {
            double right = 78.53;
            double real = circleDetails.GetArea();
            Assert.AreEqual(right, real, 0.01);
        }

        [TestMethod]
        public void TestGetArea_r22_out1520_53()
        {
            CircleDetails mshape = new CircleDetails(22);
            double right = 1520.53;
            double real = mshape.GetArea();
            Assert.AreEqual(right, real, 0.01);
        }
    }
}
