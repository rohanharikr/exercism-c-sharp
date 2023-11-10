// https://exercism.org/tracks/csharp/exercises/acronym

using System;
using System.Text;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] words = phrase.Replace("_", "").Split(new char[]{'-', ' '});
        StringBuilder acronym = new StringBuilder();
        foreach(string word in words)
        {
            if(word.Length == 0)
                continue;
            acronym.Append(word[0]);
        };
        return acronym.ToString().ToUpper();
    }
}
