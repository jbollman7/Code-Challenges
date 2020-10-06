using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10_000; i++) {
            var robot = new Robot();
            Console.WriteLine(robot.Name);
        }
    }
}
public class Robot
{
    public static List<string> UniqueNames = new List<string>();
    protected string RandomName {get;  set;}

    public string Name
    {
        get
        {
            if (RandomName == null)
                Reset();

            return RandomName;
        }
    }

    public void Reset()
    {
        var random = new Random();
        char char1 = (char)('A' + random.Next(0, 26));
        char char2 = (char)('A' + random.Next(0, 26));
        var int1 = random.Next(0, 10).ToString();
        var int2 = random.Next(0, 10).ToString();
        var int3 = random.Next(0, 10).ToString();
        var tempName = $"{char1}" + $"{char2}" + int1 + int2 + int3;
        if (UniqueNames.Contains(tempName))
        {
            Reset();
        }
        else
        {
            UniqueNames.Add(tempName);
            RandomName = tempName;
        }
    }
}