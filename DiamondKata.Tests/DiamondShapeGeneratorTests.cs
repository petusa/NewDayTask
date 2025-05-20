namespace DiamondKata.Tests;

using Xunit;

public class DiamondShapeGeneratorTests
{
    private DiamondShapeGenerator generator = new DiamondShapeGenerator('_');

    [Fact]
    public void TestHappyCaseForA()
    {
        var actual = generator.Generate('A');

        var expected = "A\n";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestHappyCase()
    {
        var actual = generator.Generate('C');

        var expected = @"__A__
_B_B_
C___C
_B_B_
__A__
";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestHappyCaseForCaseSensitiveness()
    {
        var actual = generator.Generate('c');

        var expected = @"__a__
_b_b_
c___c
_b_b_
__a__
";

        Assert.Equal(expected, actual);
    }
}