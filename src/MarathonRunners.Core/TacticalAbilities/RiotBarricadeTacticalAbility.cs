namespace MarathonRunners.Core.TacticalAbilities;

public class RiotBarricadeTacticalAbility : ITacticalAbility
{
    public string Name => "Riot Barricade";

    public string Description => "Spawns a shield of energy to block incoming damage";

    public float Cooldown => 60f;

    public void Use()
    {
        Console.WriteLine($"Using {Name} : {Description}!"  );
    }
}
