namespace Patterns.Creational.FactoryMethod;

public class ForestPoniesFactory : PonyFactory
{
    public override Pony CreatePony() => new ForestPony();
}