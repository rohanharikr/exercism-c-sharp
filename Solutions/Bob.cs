// https://exercism.org/tracks/csharp/exercises/bob

using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        bool isAQuestion = !string.IsNullOrWhiteSpace(statement) && statement.Trim().EndsWith("?");
        string lettersOnly = string.Join("", statement.ToCharArray().Where(c => Char.IsLetter(c)));
        bool isYelling = lettersOnly.Length > 0 && lettersOnly == lettersOnly.ToUpper();
        bool isYellingAQuestion = isYelling && isAQuestion;
        bool isSilence = statement.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).Count() == 0;
        if(isYellingAQuestion)
            return "Calm down, I know what I'm doing!";
        if(isSilence)
            return "Fine. Be that way!";
        if(isAQuestion)
            return "Sure.";
        if(isYelling)
            return "Whoa, chill out!";
        return "Whatever.";
    }
}
