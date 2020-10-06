using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        return firstStrand.Length != secondStrand.Length ? throw new ArgumentException() : firstStrand.Where((ch, i) => ch != secondStrand[i]).Count();
    }
}