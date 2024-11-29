using Patterns.Behavioral.Strategy.Races;

namespace Patterns.Behavioral.Strategy;

public static class StrategyProgram
{
    public static void Execute()
    {
        Pegasus pegasus = new("Rainbow Dash");
        Batpony batpony = new("Echo");
        Griffin griffin = new("Gilda");

        pegasus.Greet();
        pegasus.FlyBehavior.Fly();
        Console.WriteLine();
        batpony.Greet();
        batpony.FlyBehavior.Fly();
        Console.WriteLine();
        griffin.Greet();
        griffin.FlyBehavior.Fly();
    }
}