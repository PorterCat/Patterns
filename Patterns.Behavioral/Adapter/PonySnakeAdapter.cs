namespace Patterns.Behavioral.Adapter;

public class PonySnakeAdapter : ISnakeAdapter
{
    private readonly Pony _pony;

    public PonySnakeAdapter(Pony pony)
    {
        _pony = pony;
    }
    
    public void Hiss()
    {
        _pony.Greet();
        Console.WriteLine("Now I understand snakes! Hiss!!!");
    }
}