// https://exercism.org/tracks/csharp/exercises/sum-of-multiples

using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> m = new HashSet<int>();
        foreach(int multiple in multiples)
        {
            for(int i=1;i<max; i++)
            {
                int s = multiple * i;
                if(s >= max)
                    break;
                m.Add(s);
            }
        }
        return m.Sum();
    }
}
