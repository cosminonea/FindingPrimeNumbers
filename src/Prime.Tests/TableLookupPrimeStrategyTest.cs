namespace Prime.Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using PrimeNumbers;

    [TestClass]
    public class TableLookupPrimeStrategyTest
    {
        [TestMethod]
        public void ReturnRightNumbers()
        {
            var primeCalculator = new TableLookupPrimeStrategy();

            IEnumerable<int> primes = primeCalculator.FindPrimesLessThan(10).ToList();

            Assert.IsTrue(primes.SequenceEqual(new[] { 2, 3, 5, 7 }));
        }

        [TestMethod]
        public void ReturnRightNumbersForABiggerHighLimit()
        {
            var primeCalculator = new TableLookupPrimeStrategy();

            IEnumerable<int> primes = primeCalculator.FindPrimesLessThan(100).ToList();

            Assert.IsTrue(primes.SequenceEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }));
        }

    }
}