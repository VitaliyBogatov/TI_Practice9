using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTests
{
    public class StringUnitTests
    {
        [Test]
        [SetUp ]
        [TestCase("abc", "abcdefg")]
        public void ContainsSubstring(string substr, string str)
        {
            Assert.That(str, Does.Contain(substr));
        }
        [TearDown]

        [Test]
        [TestCase("AbCDefg", "aBcdeFG")]
        public void SameStringsIgnoringCase(string actual, string expected)
        {
            StringAssert.AreEqualIgnoringCase(expected, actual);
        }

        [Test]
        [TestCase("qwe", "Qwerty")]
        [TestCase("qwe", "qwerty")]
        public void StringStartsWith(string substr, string str)
        {
            StringAssert.StartsWith(substr, str, $"String {str} is not started with {substr}");
        }
    }
}
