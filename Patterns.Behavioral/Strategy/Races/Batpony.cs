using Patterns.Behavioral.Strategy.FlyBehaviors;

namespace Patterns.Behavioral.Strategy.Races;

public class Batpony : Pony, IFlyingCreature
{
    public Batpony(string name) : base(name){}

    public IFlyingBehavior FlyBehavior { get; } = new FlyWithMembraneWings();
}