using System;
using ClimbCalculator.Routes;
using Xunit;

namespace ClimbCalculator.Tests.Routes;

public class BoulderAttemptTests
{
    // private int Difficulty { get;  }
    // private string NameOfBoulder { get; }
    // private int RequiredCrashPads { get;  }
    // private int NumberOfCrashPads { get; }
    //
    // private int Experience { get;  }
    // public BoulderAttemptTests(int difficulty, string nameOfBoulder, int requiredCrashPads, Boulderer boulderer)
    // {
    //     Difficulty = difficulty;
    //     NameOfBoulder = nameOfBoulder;
    //     RequiredCrashPads = requiredCrashPads;
    //     Experience = boulderer.Experience;
    //     NumberOfCrashPads = boulderer.NumberOfCrashPads;
    //     
    // }
    private static Boulderer[] FakeBoulderers = new Boulderer[2]
    {
        new Boulderer("Nadia", 9, 7),
        new Boulderer("Kelly", 6, 2)
    };

    [Theory, InlineData(7,7)]
    public void IsBoulderCompleted_BoulderExperience_GreaterThanBoulderDifficulty_NumberOfCrashPads_EqualTo_RequiredCrashPads_Returns_True(int difficulty, int requiredCrashPads)
    {
            var subject = new BoulderAttempt(difficulty,"Into The Light", requiredCrashPads, FakeBoulderers[0]);
            var actual = subject.IsBoulderCompleted();
        
            Assert.True(actual);
        }
    [Theory, InlineData(7,2)]
    public void IsBoulderCompleted_BoulderExperience_LessThanBoulderDifficulty_NumberOfCrashPads_EqualTo_RequiredCrashPads_Returns_False(int difficulty, int requiredCrashPads)
    {
        var subject = new BoulderAttempt(difficulty,"Into The Light", requiredCrashPads, FakeBoulderers[1]);
        var actual = subject.IsBoulderCompleted();
        
        Assert.False(actual);
    }
    }