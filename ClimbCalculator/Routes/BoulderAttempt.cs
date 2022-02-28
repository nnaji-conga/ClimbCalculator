namespace ClimbCalculator.Routes;

public class BoulderAttempt
{
    public int Difficulty { get;  }
    public string NameOfBoulder { get; }
    public int RequiredCrashPads { get;  }
    public BoulderAttempt(int difficulty, string nameOfBoulder, int requiredCrashPads)
    {
        Difficulty = difficulty;
        NameOfBoulder = nameOfBoulder;
        RequiredCrashPads = requiredCrashPads;

    }
    public bool IsBoulderCompleted()
    {
        if()
    }
}