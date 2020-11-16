using System;
using System.Linq;
public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var colorArray = new string[]
        {
            "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"
        };
        var result = "";
        foreach(var color in colors.Take(2))
        {
            var index = Array.IndexOf(colorArray, color);
            result += index;
        }
        return Int32.Parse(result);
    }
}
