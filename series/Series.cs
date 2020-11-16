using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var mySlices = new List<String>();
        if (sliceLength > numbers.Length || sliceLength <= 0 || numbers.Length <= 0)
            throw new ArgumentException();
        for (int i = 0; i < numbers.Length - sliceLength + 1; i++)
        {
            mySlices.Add(numbers.Substring(i, sliceLength));
        }
        return mySlices.ToArray();
    }
}