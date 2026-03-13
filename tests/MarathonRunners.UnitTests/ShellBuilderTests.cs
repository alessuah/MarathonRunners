using MarathonRunners.Core;

namespace MarathonRunners.UnitTests;

internal class ShellBuilderTests
{
    [Test]
    public async Task ShellBuilder_Creates_Rook_As_Default_Shell()
    {
        //Arrange & Act
        var rookShell = ShellBuilder.CreateBuilder()
            .Build();

        //Assert
        await Assert.That(rookShell)
            .Member(r => r.Name, name => name.IsEqualTo("Rook"))
            .And.Member(r => r.Health, Health => Health.IsEqualTo(100u))
            .And.Member(r => r.Shield, Shield => Shield.IsEqualTo(200u));

    }
}
