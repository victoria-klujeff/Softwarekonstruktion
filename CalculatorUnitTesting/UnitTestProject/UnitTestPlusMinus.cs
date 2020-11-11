using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUnitTesting;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTestPlusMinus
    {
        public UnitTestPlusMinus()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethodPlus()
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
            int plusTest = classCalc.resPlus;
            // A - Assert
            Assert.AreEqual(plusRes, plusTest);
        }
        [TestMethod]
        public void TestMethodMinus()
        {
            //Hvad er 3 A'er for noget?

            // A - arrange - Opsætte betingelserne for testen. Sikrer adgang til klassen og opsætter forventninger
            ClassCalc classCalc = new ClassCalc();
            int plusRes = 28;
            int minusRes = 16;
            int gangeRes = 132;
            double dividerRes = 3.66666667;

            // A - act - Udfører handling = kalder metoden der skal testes
            classCalc.BeregnAlt(22, 6);
            int minusTest = classCalc.resMinus;

            // A - Assert - Undersøger om metoden giver det forventede resultat
            Assert.AreEqual(minusRes, minusTest);
        }
    }
}
