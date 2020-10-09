using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable
            .Range(0, max)
            .Aggregate(0, (sum, accumulator) =>
                multiples.Any(m => m != 0 && accumulator % m == 0) ? sum + accumulator : sum);exer
    }
}
