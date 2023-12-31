// https://exercism.org/tracks/csharp/exercises/annalyns-infiltration

using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
    }
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent && !archerIsAwake)
            return true;       
        if(!petDogIsPresent && !knightIsAwake && !archerIsAwake){
            if(prisonerIsAwake)
                return true;
        }
        return false;
    }
}
