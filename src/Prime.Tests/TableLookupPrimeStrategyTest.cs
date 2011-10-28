namespace Prime.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using PrimeNumbers;

    [TestClass]
    public class TableLookupPrimeStrategyTest
    {
        [TestMethod]
        public void ReturnRightPrimes()
        {
            var primeCalculator = new TableLookupPrimeStrategy();

            IEnumerable<int> primes = primeCalculator.FindPrimesLessThan(10).ToList();

            Assert.IsTrue(primes.SequenceEqual(new[] { 2, 3, 5, 7 }));
        }

        [TestMethod]
        public void ReturnRightPrimesForABiggerHighLimit()
        {
            var primeCalculator = new TableLookupPrimeStrategy();

            IEnumerable<int> primes = primeCalculator.FindPrimesLessThan(100).ToList();

            Assert.IsTrue(primes.SequenceEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }));
        }

        [TestMethod]
        public void PerformanceTest()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var primeCalculator = new TableLookupPrimeStrategy();

            Debug.WriteLine(stopwatch.ElapsedMilliseconds);

            stopwatch.Restart();

            // all these results should come far quicker than from other calculators
            primeCalculator.FindPrimesLessThan(100).ToList();

            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            primeCalculator.FindPrimesLessThan(100).ToList();

            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            primeCalculator.FindPrimesLessThan(100).ToList();

            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}