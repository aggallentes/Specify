﻿using System.Linq;

namespace Specify.Samples.Domain.Katas.PrimeNumbers
{
    public class PrimeCalculator
    {
        public bool IsPrime(int candidate)
        {
            return candidate != 1 &&
                !Enumerable.Range(2, candidate)
                .Any(i => candidate != i && candidate % i == 0);
        }
    }
}
