using Patterns.Structural.Decorator;

namespace Patterns.Structural;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        DecoratorProgram.Execute();
    }
}