using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
            var index = Array.IndexOf(Colors(), color);
            return index;
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