using ClimbCalculator.Services;

namespace ClimbCalculator.Routes;

//it is a great time, Tim! Namespaces are arbitrary...
//first name = project name
    //second name = subfolder name
public class ClimbAttempt
{
    private readonly IExperienceService _experienceService;
    //constructor allows you to
    /*class fields: something you assign or reassign in the body of the class
     property: has a getter & a setter  --> Tim almost always uses properties
     
     */
     
    //come back to climber and make it have things...arguments...strength, shoes, skill level, strongest technique
    public Climber[] Climbers { get; }

    public int Difficulty { get; }

    private double _averageClimberExperience;

    public string NameOfClimb { get; }
    // public string ClimbName { get; set; } ---> this is the same as below. Backing field vs auto-prop
    // public string ClimbName
    // {
    //     get
    //     {
    //         return _ClimbName;
    //     }
    //     set
    //     {
    //         _ClimbName = value;
    //     }
    // }
    //
    // private string _ClimbName;

    public ClimbAttempt(int difficulty, Climber[] climbers, string nameOfClimb, IExperienceService experienceService)
    {
        _experienceService = experienceService;
        Difficulty = difficulty;
        Climbers = climbers;
        NameOfClimb = nameOfClimb;
        
    }

    // public double AverageTeamExperience()
    // {
    //     // var maxInt = int.MaxValue;
    //     // double maxVal = double.MaxValue;
    //     // long max = long.MaxValue;
    //     // double maxIntDouble = (double) int.MaxValue;
    //
    //     int experienceLevelCount = 0;
    //     int averageExperienceLevel;
    //     foreach (var climber in Climbers)
    //     {
    //         experienceLevelCount += climber.Experience;
    //     }
    //     averageExperienceLevel = experienceLevelCount / Climbers.Length;
    //     _averageClimberExperience = averageExperienceLevel;
    //     return _averageClimberExperience;
    // }

    public bool IsClimbCompleted()
    {
        var experienceList = Climbers.Select(climber => climber.Experience).ToList();
        return _experienceService.AverageTeamExperience(experienceList) >= Difficulty;
    }
    
    public bool IsBoulderCompleted()
    {
        
    }
}
