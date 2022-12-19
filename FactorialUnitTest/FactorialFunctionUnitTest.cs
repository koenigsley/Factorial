using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Factorial.FactorialFunction;

namespace FactorialUnitTest
{
    [TestClass]
    public class FactorialFunctionUnitTest
    {
        private const double delta = 0.0001;

        [TestMethod]
        public void Test_computes_factorail_0_correctly()
        {
            int n = 0;
            double factorial = ComputeFactorial(n);
            Assert.AreEqual(1.0, factorial, delta);
        }

        [TestMethod]
        public void Test_computes_factorial_1_correctly()
        {
            int n = 1;
            double factorial = ComputeFactorial(n);
            Assert.AreEqual(1.0, factorial, delta);
        }

        [TestMethod]
        public void Test_computes_factorial_5_correctly()
        {
            int n = 5;
            double factorial = ComputeFactorial(n);
            Assert.AreEqual(120.0, factorial, delta);
        }

        [TestMethod]
        public void Test_throws_argument_exception_if_n_is_negative()
        {
            int n = -1;
            Assert.ThrowsException<ArgumentException>(() => ComputeFactorial(n));
        }
    }
}
