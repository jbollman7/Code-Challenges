using System;
public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{

    public static Classification Classify(int number)
    {
        var sumNumber = 0;

            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for ( var i = 0; i < number; i++)
            {
                if (i ==0)
                    continue;
                if (number % i == 0)
                    sumNumber += i;
            }

            if (sumNumber > number)
            {
            return Classification.Abundant;
            }
            else if(sumNumber < number)
            {
                return Classification.Deficient;
            }
            else
            {
                return Classification.Perfect;
            }
    }
}
