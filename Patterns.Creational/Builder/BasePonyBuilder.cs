namespace Patterns.Creational.Builder;

public class BasePonyBuilder : IPonyBuilder
{
    private Pony _pony = new Pony();
    
    public IPonyBuilder SetName(string name)
    {
        _pony.Name = name;
        return this;
    }

    public IPonyBuilder SetRace(Race race)
    {
        _pony.Race = race;
        return this;
    }

    public IPonyBuilder SetGreetingPhrase(string phrase)
    {
        _pony.GreetingPhrase = phrase;
        return this;
    }

    public Pony GetResult()
    {
        var result = _pony;
        _pony = new Pony();
        return result;
    }
}