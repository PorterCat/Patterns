namespace Patterns.Creational.Builder;

public interface IPonyBuilder
{
    IPonyBuilder SetName(string name);
    IPonyBuilder SetRace(Race race);
    IPonyBuilder SetGreetingPhrase(string phrase);
    Pony GetResult();
}