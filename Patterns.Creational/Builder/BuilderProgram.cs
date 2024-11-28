namespace Patterns.Creational.Builder;

public static class BuilderProgram
{
    public static void Execute()
    {
        BasePonyBuilder ponyBuilder = new BasePonyBuilder();
        ponyBuilder.SetName("RainbowDash").SetRace(Race.Pegasus).SetGreetingPhrase("Hello, I'm Rainbow Dash!");
        var pony = ponyBuilder.GetResult();
        
        pony.Greet();
    }
}