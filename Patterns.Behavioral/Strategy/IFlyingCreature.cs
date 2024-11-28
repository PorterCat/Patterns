using Patterns.Behavioral.Strategy.FlyBehaviors;

namespace Patterns.Behavioral.Strategy;

public interface IFlyingCreature
{
    public IFlyingBehavior FlyBehavior { get; }
    public void Fly() => FlyBehavior.Fly(); 
}