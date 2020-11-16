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
        
        /*
        var query =
            numbers.Select((fruit, index) =>
                new { sliceLength, str = num.Substring(0, sliceLength) });
        //string[] mySlices = new string[];
        
        //numbers.Select().Take(sli
        /*
        mySlices = numbers.ToArray().GroupBy(sliceLength);
        Enumerable<string> query =
            numbers.Take(sliceLength);
            //numbers.TakeWhile(fruit => String.Compare("orange", fruit, true) != 0)
                //.Append(mySlices);
               mySlices.Add(query);
               
                //return mySlices;
                //var slices =  (IEnumerable)numbers.Take(sliceLength);
                //return (string[])slices;
        */