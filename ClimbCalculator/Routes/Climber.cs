namespace ClimbCalculator.Routes;

public class Climber: Person
{
   

    
    public int Experience { get; }

    public Climber(string name, int experience) : base(name)
    {
        Experience = experience;
    }
}