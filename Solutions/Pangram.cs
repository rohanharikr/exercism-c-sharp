// https://exercism.org/tracks/csharp/exercises/pangram

using System;
using System.Linq;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        List<char> alphabets = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<char> inputMod = input.ToLower().ToCharArray().ToList();
        for(int i=0; i<inputMod.Count; i++)
        {
            var letter = inputMod[i];
            if(alphabets.Contains(letter))
                alphabets.Remove(letter);
        }
        if(alphabets.Count > 0)
            return false;
        return true;
    }
}
