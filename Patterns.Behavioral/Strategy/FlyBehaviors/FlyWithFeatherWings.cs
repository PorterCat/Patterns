namespace Patterns.Behavioral.Strategy.FlyBehaviors;

public class FlyWithFeatherWings : IFlyingBehavior
{
    public void Fly() =>
        Console.WriteLine("I'm flying with feathered wings! My aerodynamic wings are believable.");
}