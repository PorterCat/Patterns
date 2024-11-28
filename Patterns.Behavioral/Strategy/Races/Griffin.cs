using Patterns.Behavioral.Strategy.FlyBehaviors;

namespace Patterns.Behavioral.Strategy.Races;

public class Griffin: IFlyingCreature
{
    public string Name { get; private set; }

    public Griffin(string name)
    {
        Name = name;
    }
    
    public void Greet() => Console.WriteLine($"My name is {Name}. And I don't like you.");
    public IFlyingBehavior FlyBehavior { get; } = new FlyWithFeatherWings();
}