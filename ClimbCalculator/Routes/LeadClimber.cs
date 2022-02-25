namespace ClimbCalculator.Routes;

public class LeadClimber : Climber
{
    public bool KnowsFigureEight { get; }
    
    public LeadClimber(string name, int experience, bool knowsFigureEight) : base(name, experience)
    {
        KnowsFigureEight = knowsFigureEight;
    }
}