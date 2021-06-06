using Calculator;
using Moq;
using NUnit.Framework;
using System;

namespace CalculateTest
{
    public class StringCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddSumNull()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "";
            int sumResult = 0;
            var res = calculator.Add(input);
            Assert.AreEqual(sumResult, res);
        }

        [Test]
        public void AddSumNotNull()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "1,2";
            int sumResult = 3;
            var res = calculator.Add(input);
            Assert.AreEqual(sumResult, res);
        }

        [Test]
        public void AddStringEmpty()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "1\n2,3";
            int sumResult = 6;
            var res = calculator.Add(input);
            Assert.AreEqual(sumResult, res);
        }

        [Test]
        public void AddDifferentDelimeter()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "//;\n1;2;3";
            int sumResult = 6;
            var res = calculator.Add(input);
            Assert.AreEqual(sumResult, res);
        }

        [Test]
        public void AddNegativeNumberException()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "-1";
            var ex = Assert.Throws<Exception>(() => calculator.Add(input));
            Assert.That(ex.Message, Is.EqualTo("Negative not allowed"));
        }

        [Test]
        public void AddSeveralNegativeNumbersException()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "-1,-2,-3";
            var ex = Assert.Throws<Exception>(() => calculator.Add(input));
            Assert.That(ex.Message, Is.EqualTo($"Negative not allowed{input}"));
        }

        [Test]
        public void GetCalledCountReturnCount()
        {
            StringCalculator calculator = new StringCalculator();
            calculator.Add("1");
            var result = calculator.GetCalledCount();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetCalletCountReturnSeveralResult()
        {
            StringCalculator calculator = new StringCalculator();
            calculator.Add("1");
            calculator.Add("2");
            var result = calculator.GetCalledCount();
            Assert.AreEqual(2, result);
        }

        [Test]
        public void GetCalledCountReturnWithException()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "-1,-2,-3";
            Assert.Throws<Exception>(() => calculator.Add(input));
            calculator.Add("1");
            calculator.Add("2");
            var result = calculator.GetCalledCount();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Action()
        {
            StringCalculator calculator = new StringCalculator();
            var actionMock = new Mock<Action<string, int>>();
            calculator.AddOccured += actionMock.Object;
            calculator.Add("1");

            actionMock.Verify(a => a.Invoke("1", 1));
        }

        [Test]
        public void ActionTwice()
        {
            StringCalculator calculator = new StringCalculator();
            var actionMock = new Mock<Action<string, int>>();
            calculator.AddOccured += actionMock.Object;
            calculator.Add("1");
            calculator.Add("2");

            actionMock.Verify(a => a.Invoke("1", 1));
            actionMock.Verify(a => a.Invoke("2", 2));
        }

        [Test]
        public void AddIgnoreNumbersMoreThen1000()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "2,1001";
            int sumResult = 2;
            var res = calculator.Add(input);
            Assert.AreEqual(sumResult, res);
        }

        [Test]
        public void AddDifferentDelimeterLength()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "//[ ]\n1 2 3";
            int sumResult = 6;
            var res = calculator.Add(input);
            Assert.AreEqual(sumResult, res);
        }

        [Test]
        public void AddSeveralDelimeter()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "//[ ][%]\n1 2%3";
            int sumResult = 6;
            var res = calculator.Add(input);
            Assert.AreEqual(sumResult, res);
        }
    }
}