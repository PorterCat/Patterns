namespace Patterns.Behavioral.Adapter;

public static class AdapterProgram
{
    public static void Execute()
    {
        Pony pony = new Pony("Twilight Sparkle");
        // I want to know how to speak with Snakes
        
        PonySnakeAdapter adapter = new PonySnakeAdapter(pony);
        adapter.Hiss();
    }
}