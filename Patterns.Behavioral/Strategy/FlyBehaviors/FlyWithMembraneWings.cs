namespace Patterns.Behavioral.Strategy.FlyBehaviors;

public class FlyWithMembraneWings : IFlyingBehavior
{
    public void Fly() =>
        Console.WriteLine("I'm flying with membrane wings! I'm lurking in the skies >:3 ");
}