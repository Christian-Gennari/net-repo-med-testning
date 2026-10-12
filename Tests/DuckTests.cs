namespace Tests;

using Xunit;

public class DuckTests
{
    [Fact]
    public void Quack_ReturnsNameFollowedByQuacks()
    {
        var duck = new Duck { Name = "Donald" };

        var result = duck.Quack();

        Assert.Equal("Donald quacks!", result);
    }

    [Theory]
    [InlineData("Daffy", "Daffy quacks!")]
    [InlineData("Daisy", "Daisy quacks!")]
    [InlineData("", " quacks!")]
    public void Quack_WorksForDifferentNames(string name, string expected)
    {
        var duck = new Duck { Name = name };

        Assert.Equal(expected, duck.Quack());
    }
}
