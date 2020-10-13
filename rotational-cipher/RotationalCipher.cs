using System;
public static class RotationalCipher
{
        private const int UPPER_CASE = 65;
        private const int LOWER_CASE = 97;
    public static string Rotate(string text, int shiftKey)
    {
       var returnString = "";
       foreach (char c in text)
       {
           if (char.IsLetter(c))
           {
               var lowerOrUpper = char.IsUpper(c) ? UPPER_CASE : LOWER_CASE;
               returnString += (char)(lowerOrUpper + (c + shiftKey - lowerOrUpper) % 26);
           }
           else
           {
               returnString += c;
           }
        }
       return returnString;
    }
}