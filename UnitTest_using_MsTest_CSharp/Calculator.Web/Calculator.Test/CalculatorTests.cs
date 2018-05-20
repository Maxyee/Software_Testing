using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsPositiveQuotient()
        {
            //AAA
            //Arrage
            int expected = 5;
            int numeriator = 20;
            int denominator = 4;

            //Act
            int actual = Calculator.Divide(numeriator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_PositiveNumoratorAndNegativeDenominator_ReturnsNegativeQuotient()
        {
            //AAA
            //Arrage
            int expected = -5;
            int numeriator = 20;
            int denominator = -4;

            //Act
            int actual = Calculator.Divide(numeriator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_NegetiveNumbers_ReturnsPositiveQuotient()
        {
            //AAA
            //Arrage
            int expected = 5;
            int numeriator = -20;
            int denominator = -4;

            //Act
            int actual = Calculator.Divide(numeriator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
