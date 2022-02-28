namespace ClimbCalculator.Routes;

public class BoulderAttempt
{
    public int Difficulty { get;  }
    public string NameOfBoulder { get; }
    public int RequiredCrashPads { get;  }
    public int NumberOfCrashPads { get; }
    
    public int Experience { get;  }
    public BoulderAttempt(int difficulty, string nameOfBoulder, int requiredCrashPads, Boulderer boulderer)
    {
        Difficulty = difficulty;
        NameOfBoulder = nameOfBoulder;
        RequiredCrashPads = requiredCrashPads;
        Experience = boulderer.Experience;
        NumberOfCrashPads = boulderer.NumberOfCrashPads;

    }
    public bool IsBoulderCompleted()
    {
        return (Experience > Difficulty && NumberOfCrashPads >= RequiredCrashPads);
    }
}