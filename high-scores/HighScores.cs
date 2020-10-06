using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private static List<int> ScoreList;
    public HighScores(List<int> list)
    {
        ScoreList = list;
    }

    public List<int> Scores()
    {
        return ScoreList;
    }

    public int Latest()
    {
        return ScoreList.LastOrDefault();
    }

    public int PersonalBest()
    {
        return ScoreList.Max();
    }

    public List<int> PersonalTopThree()
    {
        var descending_list = ScoreList.OrderByDescending(x => x).Take(3);
        return new List<int>(descending_list);
    }
}