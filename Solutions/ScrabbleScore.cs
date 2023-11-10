// https://exercism.org/tracks/csharp/exercises/scrabble-score

using System;
using System.Linq;
using System.Collections.Generic;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int[] points = { 1, 2, 3, 4, 5, 8, 10 };
        List<List<char>> letterGroups = new List<List<char>>() {
            new List<char> { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' },
            new List<char> { 'D', 'G' },
            new List<char> { 'B', 'C', 'M', 'P' },
            new List<char> { 'F', 'H', 'V', 'W', 'Y' },
            new List<char> { 'K' },
            new List<char> { 'J', 'X' },
            new List<char> { 'Q', 'Z' }
        };
        List<char> charList = input.ToUpper().ToCharArray().ToList();
        
        int sum = 0;
        foreach(char i in charList)
        {
            for(int j=0; j<letterGroups.Count; j++)
            {
                if(letterGroups[j].Contains(i))
                    sum += points[j];
            }
        };
        return sum;
    }
}
