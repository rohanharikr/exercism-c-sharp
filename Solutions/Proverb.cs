// https://exercism.org/tracks/csharp/exercises/proverb

using System;
using System.Linq;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if(subjects.Length == 0)
            return new string[0];
        
        List<string> proverbs = new List<string>();
        for(int i=0; i < subjects.Length - 1; i++)
        {
            proverbs.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }
        proverbs.Add($"And all for the want of a {subjects[0]}.");
        
        return proverbs.ToArray();
    }
}
