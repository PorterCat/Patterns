namespace Patterns.Creational.FactoryMethod;

public class CrystalPoniesFactory : PonyFactory
{
    public override Pony CreatePony() => new CrystalPony();
}