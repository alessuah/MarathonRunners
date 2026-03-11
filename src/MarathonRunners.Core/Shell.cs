using MarathonRunners.Core.PrimeAbilities;
using MarathonRunners.Core.TacticalAbilities;

namespace MarathonRunners.Core;

public class Shell
{
    public required string Name { get; init; }
    public uint Health { get; set; }
    public uint Shield { get; set; }

    public IPrimeAbility? PrimeAbility;
    public ITacticalAbility? TacticalAbility;
}
