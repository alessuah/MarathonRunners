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
        await Assert.That(rookShell.Name).IsEqualTo("Rook");

    }
}
