using System;
public static class RotationalCipher
{
    private const int UPPER_CASE = 65;
    private const int LOWER_CASE = 97;
    private const int TOTAL_LETTERS_IN_ALPHABET = 26;
    public static string Rotate(string text, int shiftKey)
    {
        var returnString = "";
       foreach (char c in text)
       {
           returnString += Validate(c, shiftKey);
       }
       return returnString;
    }

    private static char Validate(char c, int shiftKey)
    {
        if (char.IsLetter(c))
        {
            var lowerOrUpper = char.IsUpper(c) ? UPPER_CASE : LOWER_CASE;
           return (char)(lowerOrUpper + (c + shiftKey - lowerOrUpper) % TOTAL_LETTERS_IN_ALPHABET);
        }
        else
        {
            return c;
        }
    }
}