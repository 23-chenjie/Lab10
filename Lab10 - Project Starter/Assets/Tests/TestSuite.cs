using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        float result = 0f;

        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [UnityTest]
        public IEnumerator TestSuiteAddition()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestSuiteSubtraction()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(5, 2, "/");
            Assert.AreEqual(result, 2.5f);
        }
        [UnityTest]
        public IEnumerator TestSuiteDivision()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "/");
            Assert.AreEqual(result, 2.5f);
        }

        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(9,2, "*");
            Assert.AreEqual(result, 18f);
        }
        [UnityTest]
        public IEnumerator TestSuiteMultiplication()
        {
            yield return null;

            result = Calculator.CalculatePair(9,2, "*");
            Assert.AreEqual(result, 18f);
        }
    }
}
