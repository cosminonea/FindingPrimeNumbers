namespace PrimeNumbers
{
    using System.Collections.Generic;
    using System.Linq;

    public class EratosthenesSieveStrategy : Prime
    {
        public override IEnumerable<int> FindPrimesLessThan(int number)
        {
            var numbers = Enumerable.Range(2, number - 1).ToList();

            while (numbers.Count > 0)
            {
                var prime = numbers.First();
                yield return prime;

                for (int i = prime; i <= number; i += prime)
                {
                    numbers.Remove(i);
                }
            }
        }
    }
}