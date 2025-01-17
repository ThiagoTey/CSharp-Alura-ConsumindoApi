namespace PokeApi.Pokemon;

internal class Pokemon
{
    public AbilityWrapper[] Abilities { get; set; }
    public Form[] Forms { get; set; }
}

public class AbilityWrapper
{
    public Ability Ability { get; set; }
}

public class Ability
{
    public string Name { get; set; }
}

public class Form
{
    public string Name { get; set; }
}