using Patterns.Behavioral.Adapter;
using Patterns.Behavioral.Strategy;
using Patterns.Behavioral.Strategy.Races;

namespace Patterns.Behavioral;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        // StrategyProgram.Execute();
        AdapterProgram.Execute();
    }
}