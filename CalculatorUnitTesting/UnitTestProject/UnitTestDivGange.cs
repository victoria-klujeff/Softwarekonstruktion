using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestDivGange
    {
        [TestMethod]
        public void TestDivider()
        {

            //Hvad er 3 A'er for noget?

            // A - arrange
            ClassCalc classCalc = new ClassCalc();
            int plusRes = 28;
            int minusRes = 16;
            int gangeRes = 132;
            double dividerRes = 3.66666667;
            // A - act
            classCalc.BeregnAlt(22, 6);
            double divTest = classCalc.resDivider;
            // A - Assert
            Assert.AreEqual(dividerRes, divTest, 0.0001);
        }

        [TestMethod]
        public void TestGange()
        {

            //Hvad er 3 A'er for noget?

            // A - arrange
            ClassCalc classCalc = new ClassCalc();
            int plusRes = 28;
            int minusRes = 16;
            int gangeRes = 132;
            double dividerRes = 3.66666667;
            // A - act
            classCalc.BeregnAlt(22, 6);
            int gangeTest = classCalc.resGange;
            // A - Assert
            Assert.AreEqual(gangeRes, gangeTest);
        }
    }
}
