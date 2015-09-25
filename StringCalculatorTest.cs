using System;

namespace StringCalculator.Test
{
    using NUnit.Framework;
    using Src;

    [TestFixture]
    public class StringCalculatorTest
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("5,3,0,10,50", 68)]
        [TestCase("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
        [TestCase("//a\n1a2a3", 6)]
        [TestCase("2,1001", 2)]
        [TestCase("//[***]\n1***2***3", 6)]
        [TestCase("//[*][%]\n1*2%3", 6)]
        public void TestAdd(string numbers, int sum)
        {
            Calculator calculator = new Calculator();

            int sumResult = calculator.Add(numbers);

            Assert.AreEqual(sum, sumResult);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void TestExceptionForNegativeNumbers()
        {
            Calculator calculator = new Calculator();

            calculator.Add("-1");
        }
    }
}
