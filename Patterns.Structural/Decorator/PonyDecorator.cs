namespace Patterns.Structural.Decorator;

public abstract class PonyDecorator : Pony
{
    protected readonly Pony decoratedPony;

    protected PonyDecorator(Pony pony) : base(pony)
    {
        decoratedPony = pony;
    }
}