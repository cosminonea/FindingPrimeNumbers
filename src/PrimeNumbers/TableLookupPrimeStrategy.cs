namespace PrimeNumbers
{
    using System.Collections.Generic;
    using System.Linq;

    public class TableLookupPrimeStrategy : Prime
    {
        #region Constants and Fields

        private int[] primes;

        #endregion

        #region Constructors and Destructors

        public TableLookupPrimeStrategy()
        {
            FindAndCacheAllPrimes(100000);
        }

        #endregion

        #region Public Methods

        public override IEnumerable<int> FindPrimesLessThan(int number)
        {
            int length = primes.Length;
            for (int i = 0; i <= length && primes[i] <= number; i++)
            {
                yield return primes[i];
            }
        }

        #endregion

        #region Methods

        private void FindAndCacheAllPrimes(int maxValue)
        {
            var primeCalculator = new EratosthenesSieveStrategy();
            primes = primeCalculator.FindPrimesLessThan(maxValue).ToArray();
        }

        #endregion
    }
}