namespace PrimeNumbers
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public abstract class Prime
    {
        public abstract IEnumerable<int> FindPrimesLessThan(int number);
    }
}