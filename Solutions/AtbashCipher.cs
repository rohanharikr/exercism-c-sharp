// https://exercism.org/tracks/csharp/exercises/atbash-cipher

using System;
using System.Text;
using System.Collections.Generic;

public static class AtbashCipher
{
    private static List<char> _alphabets = new List<char>()
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
    private static List<char> _alphabetsRev = new List<char>(_alphabets);

    static AtbashCipher()
    {
        _alphabetsRev.Reverse();
    }
    
    public static string Encode(string plainValue)
    {
        char[] plainValueArr = plainValue.ToLower().ToCharArray();
        StringBuilder str = new StringBuilder();
        int count = 0;
        foreach(char c in plainValueArr)
        {
           if(!Char.IsLetterOrDigit(c))
               continue;
           int index = _alphabetsRev.IndexOf(c);
            if(count == 5)
            {
                str.Append(" ");
                count = 0;
            }
            if(index == -1)
                str.Append(c);
            else
                str.Append(_alphabets[index]);
            count++;
        }
        return str.ToString();
    }

    public static string Decode(string encodedValue)
    {
        char[] encodedValueArr = encodedValue.ToLower().ToCharArray();
        StringBuilder str = new StringBuilder();
        foreach(char c in encodedValueArr)
        {
           if(!Char.IsLetterOrDigit(c))
               continue;
           int index = _alphabets.IndexOf(c);
            if(index == -1)
                str.Append(c);
            else
                str.Append(_alphabetsRev[index]);
        }
        return str.ToString();
    }
}
