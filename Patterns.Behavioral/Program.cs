using Patterns.Behavioral.Strategy.Races;

namespace Patterns.Behavioral;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        
    }

    public static void Observer()
    {

    }

    public static void Strategy()
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