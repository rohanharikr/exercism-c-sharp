// https://exercism.org/tracks/csharp/exercises/phone-number-analysis

using System;

public static class PhoneNumber
{
    public static (bool _IsNewYork, bool _IsFake, string _LocalNumber) Analyze(string phoneNumber)
    {
        string[] parsed = phoneNumber.Split("-");
        bool _IsNewYork = parsed[0] == "212";
        bool _IsFake = parsed[1] == "555";
        string LocalNumber = parsed[2];
        return ( _IsNewYork, _IsFake, LocalNumber );
    }
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
