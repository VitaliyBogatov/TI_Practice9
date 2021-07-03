using NUnit.Framework;
using Calculator;
using System;

namespace CalculatorTests
{
    [TestFixture]
    class BasicCalculatorUnitTests
    {
        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SumTwoInteger()
        {
            int actual = BasicCalculator.Add(1536, 6895);
            int expected = 8431;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SumTwoFloat()
        {
            float actual = BasicCalculator.Add(1536.36f, 986512.36f);
            float expected = 988048.72f;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SustractTwoInteger()
        {
            int actual = BasicCalculator.Substract(15230, 3658);
            int expected = 11572;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SustractTwoFloat()
        {
            float actual = BasicCalculator.Substract(1536.36f, 25635.25f);
            float expected = -24098.89f;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void MultiplyTwoInteger()
        {
            int actual = BasicCalculator.Multiply(125, 125);
            int expected = 15625;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void MultiplyTwoFloat()
        {
            float actual = BasicCalculator.Multiply(26.35f, -1565.59f);
            float expected = -41253.2965f;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void DivideTwoInteger()
        {
            int actual = BasicCalculator.Divide(15360, 10);
            int expected = 1536;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void DivideTwoFloat()
        {
            float actual = BasicCalculator.Divide(3659.25f, 365.96f);
            float expected = 9.999043f;
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive")]
        [TestCase(0, 0, 0)]
        [TestCase(156, 16, 172)]
        [TestCase(-167, 175, 8)]
        [TestCase(136581.3567, 32658954.62531, 32795535.98201)]
        [TestCase(10, -10.00, 0)]
        [TestCase(-102.76, -12563.35, -12666.11)]
        [Order(20)]
        public void SumTwoValues(double x, double y, double expected)
        {
            double actual = BasicCalculator.Add(x, y);
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive")]
        [TestCase(0, 0, 0)]
        [TestCase(1562, 25364, -23802)]
        [TestCase(-356, 10345, -10701)]
        [TestCase(-1023.25, -1256.353, 233.103)]
        [TestCase(15623.25, 15623.25, 0)]
        [Order(30)]
        public void SubstractTwoValues(double x, double y, double expected)
        {
            double actual = BasicCalculator.Substract(x, y);
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive")]
        [TestCase(0, 0, 0)]
        [TestCase(1562, 25364, 39618568)]
        [TestCase(-356, 10345, -3682820)]
        [TestCase(-1023.25, -1256.353, 1285563.20725)]
        [TestCase(15623.25, -15623.25, -244085940.5625)]
        [Timeout(10000)]
        [Order(10)]
        public void MultiplyTwoValues(double x, double y, double expected)
        {
            double actual = BasicCalculator.Multiply(x, y);
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Positive")]
        [TestCase(0, 10.263, 0)]
        [TestCase(1562, 1562, 1)]
        [TestCase(1536.36, -2.36, -651)]
        [TestCase(-102325.25, 456.68, -224.06334851537181)]
        [Retry(10)]
        public void DivideTwoValues(double x, double y, double expected)
        {
            double actual = BasicCalculator.Divide(x, y);
            Assert.AreEqual(expected, actual, $"Failed: actual value {actual} is not equal to expected {expected}");
        }

        [Test]
        [Category("Negative"), Category("Smoke")]
        [TestCase(10, 0)]
        public void DivideByZeroThrowsException(int x, int y)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                var actual = BasicCalculator.Divide(x, y);
            });
        }

        [Test]
        [Category("Positive")]
        [TestCase(2.5f, 100)]
        public void SumOfFloatAndIntReturnsFloat(float x, int y)
        {
            Assert.IsInstanceOf<float>(BasicCalculator.Add(x, y));
        }

        [Test]
        [Category("Positive")]
        [TestCase(100, 2.5f)]
        [Timeout(5000)]
        [Repeat(1000)]
        public void SumOfIntAndFloatReturnsFloat(int x, float y)
        {
            try
            {
                Assert.IsInstanceOf<float>(BasicCalculator.Add(x, y));
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test case has been failed - {ex.Message}");
            }
        }
    }
}
