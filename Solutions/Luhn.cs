// https://exercism.org/tracks/csharp/exercises/luhn

using System;
using System.Linq;

public static class Luhn
{
    public static bool IsValid(string _number)
    {
        string number = _number.Replace(" ", "");
        char[] numberArr = number.ToCharArray();
        foreach(char n in numberArr)
        {
            if(!Char.IsNumber(n))
                return false;
        }
        
        if(number.Length <= 1)
            return false;

        int[] numList = (number.Select(digit => int.Parse(digit.ToString()))).ToArray();
        bool skip = true;
        for(int i=numList.Length - 1; i>=0; i--)
        {
            if(!skip)
            {
                int sum = (numList[i] * 2);
                numList[i] = sum;
                if(sum > 9)
                {
                    numList[i] = sum - 9;
                }
            }
            skip = !skip;
        };
        return numList.Sum() % 10 == 0;
    }
}
