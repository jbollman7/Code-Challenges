using System;
using System.Collections.Generic;
public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var myList = new List<int>();
        foreach(var color in colors)
        {
            var index = Array.IndexOf(Colors(), color);
            myList.Add(index);
        }
        int combinedvalue = int.Parse(myList[0].ToString() + myList[1].ToString());
        return combinedvalue;
    }
    public static string[] Colors()
    {
        var colorArray = new string[]
        {
            "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"
        };
        return colorArray;
    }
}
