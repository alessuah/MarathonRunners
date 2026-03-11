namespace MarathonRunners.Core.PrimeAbilities;

public interface IPrimeAbility
{
    public string Name { get; }
    public string Description { get; }
    public float Cooldown { get; }
    public void Use() { }
}
