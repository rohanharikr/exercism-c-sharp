// https://exercism.org/tracks/csharp/exercises/matching-brackets

using System;
using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        Dictionary<char, char> brackets = new Dictionary<char, char>() {
            {']', '['},
            {'}', '{'},
            {')', '('}
        };
        List<char> started = new List<char>();
        foreach(char c in input.ToCharArray())
        {
            if(!brackets.ContainsKey(c) && !brackets.ContainsValue(c))
                continue;
            if(started.Count == 0 && brackets.ContainsKey(c))
                return false;
            if(brackets.ContainsValue(c))
                started.Add(c);
            if(started.Count > 0 && brackets.ContainsKey(c))
            {
                if(brackets[c] == started[started.Count - 1])    
                    started.RemoveAt(started.Count - 1);   
                else
                    return false;
            }
        }
    
        if(started.Count == 0)
            return true;
        return false;
    }
}
