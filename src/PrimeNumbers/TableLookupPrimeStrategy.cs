namespace PrimeNumbers
{
    using System.Collections.Generic;
    using System.Linq;

    public class TableLookupPrimeStrategy : Prime
    {
        #region Constants and Fields
        // this really hurts performance during the first hit
        private static readonly int[] Primes = FindAndCacheAllPrimes(100000); 

        #endregion


        #region Public Methods

        public override IEnumerable<int> FindPrimesLessThan(int number)
        {
            int length = Primes.Length;
            for (int i = 0; i <= length && Primes[i] <= number; i++)
            {
                yield return Primes[i];
            }
        }

        #endregion

        #region Methods

        private static int[] FindAndCacheAllPrimes(int maxValue)
        {
            // here we could as well read them from a file or some pre-calculated list
            var primeCalculator = new EratosthenesSieveStrategy();
            return primeCalculator.FindPrimesLessThan(maxValue).ToArray();
        }

        #endregion
    }
}