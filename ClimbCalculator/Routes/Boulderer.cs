namespace ClimbCalculator.Routes;

public class Boulderer : Climber
{
    public int NumberOfCrashPads { get;  }

    public Boulderer(string name, int experience, int numberOfCrashPads) : base(name, experience)
    {
        NumberOfCrashPads = numberOfCrashPads;
    }
}