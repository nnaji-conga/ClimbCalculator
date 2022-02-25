using System.Collections.Generic;
using System.Linq;

namespace ClimbCalculator.Services;
//concrete class 

public class ExperienceService : IExperienceService
{
    public double AverageTeamExperience(IEnumerable<int> membersExperience)
    {
        // var length = membersExperience.Length;
        // int count = 0;
        // foreach (var experience in membersExperience)
        // {
        //     count += experience;
        // }
        //
        // return (count / length);
        return membersExperience.Average();
    }
}