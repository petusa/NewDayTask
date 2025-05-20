namespace DiamondKata.Tests;

using Xunit;

public class ProgramTests
{
    private ProgramWrapper program = new ProgramWrapper(new DiamondShapeGenerator('_'));

    [Fact]
    public void TestNoArgumentsProvidedCase()
    {
        string[] args = { };
        var actual = program.Main(args);

        var expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestNoSingleCharacterProvidedAsFirstArgumentCase()
    {
        string[] args = { "AB" };
        var actual = program.Main(args);

        var expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void TestNonLetterCase()
    {
        string[] args = { "*" };
        var actual = program.Main(args);

        var expected = @"Please provide a character from the English Alphabet.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestIgnoreFurtherArgumentsCase()
    {
        string[] args = { "C", "SomeFurtherArgumentNotTakenIntoAccount" };
        var actual = program.Main(args);

        var expected = @"__A__
_B_B_
C___C
_B_B_
__A__
";

        Assert.Equal(expected, actual);
    }
}