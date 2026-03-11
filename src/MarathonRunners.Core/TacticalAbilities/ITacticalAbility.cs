namespace MarathonRunners.Core.TacticalAbilities;

public interface ITacticalAbility
{
    public string Name { get; }
    public string Description { get; }
    public float Cooldown { get; }
    public void Use() { }
}
