// https://exercism.org/tracks/csharp/exercises/difference-of-squares

using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for(int i=0; i<=max; i++)
            sum += i;
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        for(int i=0; i<=max; i++)
            sum += (i * i);
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}
