// https://exercism.org/tracks/csharp/exercises/isbn-verifier

using System;

public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        string sanitized = number.Replace("-", "");
        if(sanitized.Length != 10)
            return false;

        const int MAX = 10;
        int sum = 0;
        for(int i=0; i<MAX; i++)
        {
            if(i >= sanitized.Length)
                break;

            int n;
            bool isNumber = int.TryParse(sanitized[i].ToString(), out n);
            if(isNumber)
                sum += n * (MAX - i);
            else if(sanitized[i] == 'X')
                sum += 10;
            else
                return false;
        }
    
        return sum % 11 == 0;
    }
}
