namespace Patterns.Behavioral.Strategy;

public class Pony
{
    public string Name { get; private set; }

    public Pony(string name)
    {
        Name = name;
    }
    
    public void Greet() => Console.WriteLine($"Hello, my name is {Name}");
}