using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {

        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }

        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[3];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

            numbers[0] = 50;
            numbers[1] = 50;
            numbers[2] = 50;
            Assert.AreEqual(150, Calculator.Sum(numbers));

        }

        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(25, Calculator.Multiply(5, 5));
            Assert.AreEqual(0, Calculator.Multiply(0, 7));
        }

        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(27, Calculator.Power(3, 3));
            Assert.AreEqual(-243, Calculator.Power(-3, 5));
            Assert.AreEqual(0, Calculator.Power(0, 1337));
        }

        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(1,   Calculator.Factorial(-28));
            Assert.AreEqual(1,   Calculator.Factorial(-1));
            Assert.AreEqual(1,   Calculator.Factorial(0));
            Assert.AreEqual(1,   Calculator.Factorial(1));
            Assert.AreEqual(2,   Calculator.Factorial(2));
            Assert.AreEqual(6,   Calculator.Factorial(3));
            Assert.AreEqual(24,  Calculator.Factorial(4));
            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(720, Calculator.Factorial(6));
        }

    }
}
