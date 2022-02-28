namespace ClimbCalculator.Routes;

public class Climber: Person
{
   

    
    //this property was initially static in our last commit (initial commit), did I accidentally change this or was it done for some reason to accomodate the unit test we created on Friday?
    public int Experience { get; }

    public Climber(string name, int experience) : base(name)
    {
        Experience = experience;
    }
}