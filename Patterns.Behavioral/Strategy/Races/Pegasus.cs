using Patterns.Behavioral.Strategy.FlyBehaviors;

namespace Patterns.Behavioral.Strategy.Races;

public class Pegasus : Pony, IFlyingCreature
{
    public Pegasus(string name) : base(name) {}
    public IFlyingBehavior FlyBehavior { get; } = new FlyWithFeatherWings();
}