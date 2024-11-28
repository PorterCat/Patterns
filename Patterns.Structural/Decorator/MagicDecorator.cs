namespace Patterns.Structural.Decorator;

public class MagicDecorator : PonyDecorator
{
    public MagicDecorator(Pony pony) : base(pony) {}

    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("I can use magic!");
    }
}