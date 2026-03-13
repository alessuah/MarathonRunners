using MarathonRunners.Core.PrimeAbilities;
using MarathonRunners.Core.TacticalAbilities;

namespace MarathonRunners.Core;

public class ShellBuilder
{
    private string Name { get; set; } = "Rook";
    private uint Health { get; set; } = 100;
    private uint Shield { get; set; } = 200;
    private IPrimeAbility? PrimeAbility;
    private ITacticalAbility? TacticalAbility;

    private ShellBuilder()
    {
    }
    public static ShellBuilder CreateBuilder()
    {
        return new ShellBuilder();
    }

    public ShellBuilder WithName(string name)
    {
        this.Name = name;
        return this;
    }

    public ShellBuilder WithHealth(uint health)
    {
        this.Health = health;
        return this;
    }

    public ShellBuilder WithShield(uint shield)
    {
        this.Shield = shield;
        return this;
    }

    public ShellBuilder WithPrimeAbility(IPrimeAbility primeAbility)
    {
        this.PrimeAbility = primeAbility;
        return this;
    }

    public ShellBuilder WithTacticalAbility(ITacticalAbility tacticalAbility)
    {
        this.TacticalAbility = tacticalAbility;
        return this;
    }
    public Shell Build()
    {
        return new Shell() { 
            Name = this.Name,
            Health = this.Health,
            Shield = this.Shield,
            PrimeAbility = this.PrimeAbility,
            TacticalAbility = this.TacticalAbility
        };
    }
}
