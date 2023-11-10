// https://exercism.org/tracks/csharp/exercises/bird-watcher

using System;

class BirdCount
{
    private int[] birdsPerDay;
    private static int[] _birdsPerDayLastWeek = { 0, 2, 5, 3, 7, 8, 4 };

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => _birdsPerDayLastWeek;

    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1] += 1;

    public bool HasDayWithoutBirds()
    {
        foreach(int day in birdsPerDay) {
            if(day == 0)
                return true;
        };
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i=0; i<numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        };
        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach(int day in birdsPerDay) {
            if(day >= 5)
                busyDays += 1;
        };
        return busyDays;
    }
}
