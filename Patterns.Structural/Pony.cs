namespace Patterns.Structural;

public class Pony
{
    public string Name { get; private set; }

    public Pony(string name)
    {
        Name = name;
    }

    public Pony(Pony pony)
    {
        Name = pony.Name;
    }
    public virtual void Greet() => Console.WriteLine($"Hello, my name is {Name}");
}