namespace Patterns.Behavioral.Adapter;

public class Pony
{
    public string Name { get; set; }
    public Pony(string name)
    {
        Name = name;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
}