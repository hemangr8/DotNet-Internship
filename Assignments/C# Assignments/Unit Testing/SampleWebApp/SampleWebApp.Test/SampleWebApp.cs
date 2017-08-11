using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Controls;
using SampleWebApp;
using PercentageConditions;

namespace SampleWebApp.Test
{
    [TestClass]
    public class SampleWebApp
    {
        ReturnConditions condition;

        [TestInitialize()]
        public void TestSetup()
        {
            condition = new ReturnConditions();
        }

        [TestMethod]
        public void NullTest()
        {
            Assert.AreEqual(true, condition.IsException(""));
        }

        [TestMethod]
        public void StringValueTest()
        {
            Assert.AreEqual(true, condition.IsException("This is a test"));
        }

        [TestMethod]
        public void SplCharacterTest()
        {
            Assert.AreEqual(true, condition.IsException("!@##$"));
        }

        [TestMethod]
        public void TrueValueTest1()
        {
            Assert.AreEqual(false, condition.IsException("55"));
        }

        [TestMethod]
        public void TrueValueTest2()
        {
            Assert.AreEqual(false, condition.IsException("89.3"));
        }

        
        [TestMethod]
        public void NegativeLowerBoundaryTest1()
        {
            Assert.AreEqual(false, condition.IslLegit("-55"));
        }

        [TestMethod]
        public void NegativeLowerBoundaryTest2()
        {
            Assert.AreEqual(false, condition.IslLegit("-0.1"));
        }

        [TestMethod]
        public void NegativeUpperBoundaryTest1()
        {
            Assert.AreEqual(false, condition.IslLegit("151"));
        }

        [TestMethod]
        public void NegativeUpperBoundaryTest2()
        {
            Assert.AreEqual(false, condition.IslLegit("100.1"));
        }

        [TestMethod]
        public void PositiveUpperBoundaryTest1()
        {
            Assert.AreEqual(true, condition.IslLegit("100"));
        }

        [TestMethod]
        public void PositiveUpperBoundaryTest2()
        {
            Assert.AreEqual(true, condition.IslLegit("99.9"));
        }

        [TestMethod]
        public void PositiveLowerBoundaryTest1()
        {
            Assert.AreEqual(true, condition.IslLegit("0"));
        }

        [TestMethod]
        public void PositiveLowerBoundaryTest2()
        {
            Assert.AreEqual(true, condition.IslLegit("0.1"));
        }

        [TestMethod]
        public void NegativePassingTest1()
        {
            Assert.AreEqual(false, condition.IsPassed("10"));
        }

        [TestMethod]
        public void NegativePassingTest2()
        {
            Assert.AreEqual(false, condition.IsPassed("20.6"));
        }

        [TestMethod]
        public void NegativePassingBoundaryTest1()
        {
            Assert.AreEqual(false, condition.IsPassed("20.9"));
        }

        [TestMethod]
        public void NegativePassingBoundaryTest2()
        {
            Assert.AreEqual(false, condition.IsPassed("30"));
        }

        [TestMethod]
        public void PositivePassingTest1()
        {
            Assert.AreEqual(true, condition.IsPassed("40"));
        }

        [TestMethod]
        public void PositivePassingTest2()
        {
            Assert.AreEqual(true, condition.IsPassed("82"));
        }

        [TestMethod]
        public void PositiveBoundaryPassingTest1()
        {
            Assert.AreEqual(true, condition.IsPassed("30.1"));
        }

        [TestMethod]
        public void PositiveBoundaryPassingTest2()
        {
            Assert.AreEqual(true, condition.IsPassed("31"));
        }
    }
}
