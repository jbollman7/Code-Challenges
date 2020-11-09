using System;
using System.Linq;

public static class Acronym
{
    //LINQ way
    public static string Abbreviate(string phrase) => string.Join("", phrase.Split(new char[] {'-','_',' '}, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToString().ToUpper().First()));
    // more traditional way.
    /*{
        var returnString = "";
        var words = phrase.Split(new char[] {'-','_',' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (var w in words)
        {
            returnString += w[0].ToString().ToUpper();
        }
        return returnString;
    }
    */
}
