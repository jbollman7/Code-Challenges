using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var intKeysList = new List<int>();
        Dictionary<string, int> myDic = new Dictionary<string, int>();
        foreach(KeyValuePair<int, string[]> kvp in old)
        {
            var keyToAddToList = kvp.Key;
            foreach (var nestedLoop in kvp.Value)
            {
                myDic.Add(nestedLoop.ToLower(), keyToAddToList);
            }
        }
        
        return myDic;
    }
}
