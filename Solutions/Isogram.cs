// https://exercism.org/tracks/csharp/exercises/isogram

using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string sanitizedWord = word.Replace(" ", "").Replace("-", "").ToLower();
        List<char> checkedLetters = new List<char>();
        foreach(char i in sanitizedWord.ToCharArray())
        {
            if(checkedLetters.Contains(i))
                return false;
            checkedLetters.Add(i);
        };
        return true;
    }
}
