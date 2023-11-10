// https://exercism.org/tracks/csharp/exercises/resistor-color-duo

using System;
using System.Text;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static Dictionary<string, int> _colorMap = new Dictionary<string, int>()
    {
        {"black", 0},
        {"brown", 1},
        {"red", 2},
        {"orange", 3},
        {"yellow", 4},
        {"green", 5},
        {"blue", 6},
        {"violet", 7},
        {"grey", 8},
        {"white", 9}
    };
        
    public static int Value(string[] colors)
    {
        StringBuilder display = new StringBuilder();
        for(int i=0; i<2; i++)
        {
            int val = _colorMap[colors[i]];
            display.Append(val);
        };
        return int.Parse(display.ToString());
    }
}
