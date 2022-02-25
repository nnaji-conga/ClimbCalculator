using System.Collections.Generic;
using ClimbCalculator.Routes;
using ClimbCalculator.Services;
using NSubstitute;
using Xunit;

namespace ClimbCalculator.Tests.Routes;

public class ClimbAttemptTests
{
    private readonly IExperienceService _experienceService;

    public ClimbAttemptTests()
    {
        _experienceService = Substitute.For<IExperienceService>();
    }
    private static Climber[] FakeClimbers = new Climber[2]
    {
        new Climber("ted", 12),
        new Climber("john", 18)
    };

    [Theory]
    [InlineData(8)] //<--parens is the constructor for the inline data of the tag/attribute
    public void IsClimbCompleted_ClimberExperience_GreaterThanDifficulty_Returns_True(int difficulty)
    {
        var subject = new ClimbAttempt(difficulty, FakeClimbers, "WooHoo", _experienceService);
        _experienceService.AverageTeamExperience(Arg.Any<IEnumerable <int>>()).Returns(9);

        var actual = subject.IsClimbCompleted();

        Assert.True(actual);
    }

    [Theory]
    [InlineData(8)] //<--parens is the constructor for the inline data of the tag/attribute
    public void IsClimbCompleted_ClimberExperience_GreaterThanDifficulty_Returns_False(int difficulty)
    {
        var subject = new ClimbAttempt(difficulty, FakeClimbers, "WooHoo", _experienceService);
        _experienceService.AverageTeamExperience(Arg.Any<IEnumerable<int>>()).Returns(5);

        var actual = subject.IsClimbCompleted();

        Assert.False(actual);
    }
}