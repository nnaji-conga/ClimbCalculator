using System.Collections.Generic;

namespace ClimbCalculator.Services;

public interface IExperienceService
{
    double AverageTeamExperience(IEnumerable<int> membersExperience);
}