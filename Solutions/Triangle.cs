// https://exercism.org/tracks/csharp/exercises/triangle

using System;
using System.Linq;

public static class Triangle
{
    private static bool IsTriangle(double side1, double side2, double side3){
        if(side1 == 0 && side2 == 0 && side3 == 0)
            return false;
        bool comp1 = (side1 + side2) >= side3;
        bool comp2 = (side2 + side3) >= side1;
        bool comp3 = (side1 + side3) >= side2;
        return comp1 && comp2 && comp3; 
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        if(!IsTriangle(side1, side2, side3))
            return false;
        double[] deduped = new double[]{ side1, side2, side3 }.Distinct().ToArray();
        return true ? deduped.Length > 2 : false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if(!IsTriangle(side1, side2, side3))
            return false;
        double[] deduped = new double[]{ side1, side2, side3 }.Distinct().ToArray();
        return true ? deduped.Length <= 2 : false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if(!IsTriangle(side1, side2, side3))
            return false;
        double[] deduped = new double[]{ side1, side2, side3 }.Distinct().ToArray();
        return true ? deduped.Length == 1 : false;
    }
}
