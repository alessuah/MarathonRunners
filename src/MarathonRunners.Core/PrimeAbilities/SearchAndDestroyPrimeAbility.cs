namespace MarathonRunners.Core.PrimeAbilities;

public class SearchAndDestroyPrimeAbility : IPrimeAbility
{
    public string Name => "Search & Destroy";

    public string Description => "Shoots homing missiles that will deal damage to enemies";

    public float Cooldown => 120f;

    public void Use()
    {
        Console.WriteLine($"Using {Name} : {Description}!"  );
    }
}
