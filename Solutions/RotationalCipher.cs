// https://exercism.org/tracks/csharp/exercises/rotational-cipher

using System;
using System.Text;

public static class RotationalCipher
{
    private static char[] alphabets = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder enc = new StringBuilder();
        foreach(char c in text.ToCharArray())
        {
            if(!Char.IsLetter(c))
                enc.Append(c);
            else {
                int index = Array.IndexOf(alphabets, Char.ToLower(c));
                char letter = alphabets[(shiftKey + index) % alphabets.Length];
                if(Char.IsUpper(c))
                    enc.Append(Char.ToUpper(letter));
                else
                    enc.Append(letter);
            }
        }
        return enc.ToString();
    }
}
