namespace Patterns.Structural.Decorator;

public static class DecoratorProgram
{
    public static void Execute()
    {
        Pony pony = new("Twilight Sparkle");
        pony.Greet();
        Console.WriteLine("Few years later...");
        Pony magicPony = new MagicDecorator(pony);
        magicPony.Greet();
    }
}