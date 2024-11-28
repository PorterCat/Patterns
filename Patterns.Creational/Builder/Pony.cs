namespace Patterns.Creational.Builder;

public class Pony
{
    public string Name { get; set; } = string.Empty;
    public Race Race { get; set; } = default;
    public string GreetingPhrase { get; set; } = string.Empty;

    public void Greet() =>
        Console.WriteLine($"{GreetingPhrase}");
}