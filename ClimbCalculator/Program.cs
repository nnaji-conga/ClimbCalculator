// See https://aka.ms/new-console-template for more information

using ClimbCalculator.Routes;
using ClimbCalculator.Services;

namespace ClimbCalculator //entrypoint to application
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("sup");
            var nadia = new LeadClimber("nadia", 3, true);
            var tim = new Climber("tim", 8);
            var ben = new Boulderer("ben", 11, 4);
            var climbers = new Climber[2] {nadia, tim};
            var climbAttempt1 = new ClimbAttempt(14, climbers, "Everest", new ExperienceService());
            var boulderAttempt1 = new Boulderer("Gina", 10, 4);

            foreach (var climber in climbers)
            {
                Console.WriteLine($"Climber name: {climber.Name}");
                Console.WriteLine($"Climber experience: {climber.Experience}");

            }
            
            Console.WriteLine($"Has the team has completed the climb: {climbAttempt1.IsClimbCompleted()}");
            // Console.WriteLine("{0}, {1}",climbAttempt1.Climbers[2].Name, climbAttempt1.NameOfClimb);
        }
    }
}

/*primary difference between an interface and a class is that you cannot have an
instance of an interface*/