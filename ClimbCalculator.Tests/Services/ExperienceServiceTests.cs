using System.Collections.Generic;
using ClimbCalculator.Services;
using Xunit;

namespace ClimbCalculator.Tests.Services;
//A unit test is a method
    //it is composed of 3 parts
        //Part 1: arrange section --> where you set up the subject you're going to tests
        //Part 2: act section --> call the method that you are trying to test
        //Part 3: assert section --> where the output of the act section equals the values you expect

public class ExperienceServiceTests
{
    //attributes can be tied to non-unit tests?
    //unit test must be be public
    
    //this is an attribute the square bracket below
    [Fact]
    public void AverageTeamExperience_Returns_Average()
    {
        var subject = new ExperienceService();
        var fakeTeamExperience = new List<int> {2, 2};

        var actual = subject.AverageTeamExperience(fakeTeamExperience);
        
        Assert.Equal(2, actual);
    }
}