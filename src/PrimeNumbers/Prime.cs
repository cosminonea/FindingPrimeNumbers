namespace PrimeNumbers
{
    using System.Collections.Generic;

    public abstract class Prime
    {
        public abstract IEnumerable<int> FindPrimesLessThan(int number);
    }
}