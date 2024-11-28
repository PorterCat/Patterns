namespace Patterns.Creational.FactoryMethod;

public static class FactoryMethodProgram
{
    public static void Execute()
    {
        PonyFactory factory = new CrystalPoniesFactory();
        Pony pony = factory.CreatePony();
        
        factory = new ForestPoniesFactory();
        Pony pony2 = factory.CreatePony();
    }
}