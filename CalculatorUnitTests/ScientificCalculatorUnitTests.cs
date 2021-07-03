using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    [TestFixture]
    class ScientificCalculatorUnitTests
    {
        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SumOnlyOneInteger()
        {
            var actual = ScientificCalculator.Add(int.MaxValue);
            var expected = 2147483647;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<int>(actual, "Invalid type.");
            }
            );
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SumTwoInteger()
        {
            var actual = ScientificCalculator.Add(1536, 6895);
            var expected = 8431;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<int>(actual, "Invalid type.");
            }
            );
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SumTwoFloat()
        {
            var actual = ScientificCalculator.Add(1536.36f, 986512.36f);
            var expected = 988048.72f;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<float>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SumManyDouble()
        {
            var actual = ScientificCalculator.Add(1536.36f, 986512.36f, -12, 12635.95637d);
            var expected = 1000672.67637;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<double>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SustractTwoInteger()
        {
            var actual = ScientificCalculator.Substract(15230, 3658);
            var expected = 11572;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<int>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SustractTwoFloat()
        {
            var actual = ScientificCalculator.Substract(1536.36f, 25635.25f);
            var expected = -24098.89f;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<float>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void MultiplyTwoInteger()
        {
            var actual = ScientificCalculator.Multiply(125, 125);
            var expected = 15625;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<int>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void MultiplyTwoFloat()
        {
            var actual = ScientificCalculator.Multiply(26.35f, -1565.59f);
            var expected = -41253.2965f;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<float>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void DivideTwoInteger()
        {
            var actual = ScientificCalculator.Divide(15360, 10);
            var expected = 1536;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<float>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void DivideTwoFloat()
        {
            var actual = ScientificCalculator.Divide(3659.25f, 365.96f);
            var expected = 9.999043f;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<float>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void SquareRootOfHundredReturnsTen()
        {
            var actual = ScientificCalculator.Square(100);
            var expected = 10;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<int>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Positive"), Category("Smoke")]
        public void HundredPoweredThreeReturns()
        {
            var actual = ScientificCalculator.Pow(100,3);
            var expected = 10;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, $"Actual value {actual} is not equal to expected {expected}");
                Assert.IsInstanceOf<int>(actual, "Invalid type.");
            });
        }

        [Test]
        [Category("Negative")]
        [TestCase(0, +2, 4)]
        public void SumOfZeroAndTwoReturnsFour(int x, int y, int expected)
        {
            Assert.That(ScientificCalculator.Add(x, y), Is.EqualTo(expected));
        }

        [Test]
        [Category("Positive")]
        [TestCase(6, +6, 12)]
        public void SumOfSixAndSixReturnsTwelve(double x, double y, double expected)
        {
            Assert.That(ScientificCalculator.Add(x, y), Is.EqualTo(expected));
        }

        [Test]
        [Category("Positive")]
        [TestCase(+1, -3, -2)]
        public void SumOfOneAndMinusThreeIsNegative(double x, double y, double expected)
        {
            Assert.That(ScientificCalculator.Add(x, y), Is.Negative);
        }

        [Test]
        [Category("Positive")]
        [TestCase(+2, -2, 0)]
        public void SumOfOneAndMinusThreeIsNegative(int x, int y, int expected)
        {
            Assert.Multiple(() =>
            {
                Assert.That(ScientificCalculator.Substract(x, y), Is.Not.EqualTo(expected));
                Assert.That(ScientificCalculator.Substract(x, y), Is.Not.Null);
            }
            );
        }
    }
}
