using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        var i = 0;
        if (number <= 0)
            throw new ArgumentOutOfRangeException();
        while(number != 1)
        {
            if (number % 2 == 0)
                number = number / 2;
            else
                number = number * 3 + 1;
            i++;
        }
        return i;
    }
}