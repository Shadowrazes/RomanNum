using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            try
            {
                var result = new RomanNumber(1);
            }
            catch (RomanNumberException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

            try
            {
                var result = new RomanNumber(3999);
            }
            catch (RomanNumberException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

            try
            {
                var result = new RomanNumber(536);
            }
            catch (RomanNumberException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(4000));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(6544));
        }

        [TestMethod()]
        public void CloneTest()
        {
            var a = new RomanNumber(3462);
            var b = a.Clone();
            Assert.AreEqual(a.ToString(), b.ToString());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            var a = new RomanNumber(3462);
            var b = new RomanNumber(2345);
            RomanNumber? c = null;

            Assert.IsTrue(a.CompareTo(b) > 0);
            Assert.IsTrue(b.CompareTo(a) < 0);
            Assert.IsTrue(a.CompareTo(a) == 0);

            Assert.ThrowsException<RomanNumberException>(() => b.CompareTo(c));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var a = new RomanNumber(900);
            Assert.AreEqual(a.ToString(), "CM");
        }

        [TestMethod()]
        public void Add()
        {
            var a = new RomanNumber(542);
            var b = new RomanNumber(643);
            var c = new RomanNumber(3561);
            RomanNumber? d = null;

            Assert.AreEqual("MCLXXXV", (a + b).ToString());
            Assert.ThrowsException<RomanNumberException>(() => a + c);
            Assert.ThrowsException<RomanNumberException>(() => a + d);
            Assert.ThrowsException<RomanNumberException>(() => d + a);
            Assert.ThrowsException<RomanNumberException>(() => d + d);
        }

        [TestMethod()]
        public void Sub()
        {
            var a = new RomanNumber(2371);
            var b = new RomanNumber(432);
            RomanNumber? c = null;

            Assert.AreEqual("MCMXXXIX", (a - b).ToString());
            Assert.ThrowsException<RomanNumberException>(() => b - a);
            Assert.ThrowsException<RomanNumberException>(() => a - c);
            Assert.ThrowsException<RomanNumberException>(() => c - a);
            Assert.ThrowsException<RomanNumberException>(() => c - c);
        }

        [TestMethod()]
        public void Mul()
        {
            var a = new RomanNumber(799);
            var b = new RomanNumber(2);
            var c = new RomanNumber(56);
            RomanNumber? d = null;

            Assert.AreEqual("MDXCVIII", (a * b).ToString());
            Assert.ThrowsException<RomanNumberException>(() => a * c);
            Assert.ThrowsException<RomanNumberException>(() => a * d);
            Assert.ThrowsException<RomanNumberException>(() => d * a);
            Assert.ThrowsException<RomanNumberException>(() => d * d);
        }

        [TestMethod()]
        public void Div()
        {
            var a = new RomanNumber(1456);
            var b = new RomanNumber(2);
            RomanNumber? c = null;

            Assert.AreEqual("DCCXXVIII", (a / b).ToString());
            Assert.AreEqual("I", (a / a).ToString());
            Assert.ThrowsException<RomanNumberException>(() => b / a);
            Assert.ThrowsException<RomanNumberException>(() => a / c);
            Assert.ThrowsException<RomanNumberException>(() => c / a);
            Assert.ThrowsException<RomanNumberException>(() => c / c);
        }
    }
}