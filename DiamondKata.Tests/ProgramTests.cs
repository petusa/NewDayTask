namespace DiamondKata.Tests;

using Xunit;

public class ProgramTests
{
    [Fact]
    public void TestNoArgumentsProvidedCase()
    {
        string[] args = { };
        var program = new ProgramWrapper();
        var actual = program.Main(args);

        var expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestNoSingleCharacterProvidedAsFirstArgumentCase()
    {
        string[] args = { "AB" };
        var program = new ProgramWrapper();
        var actual = program.Main(args);

        var expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void TestNonLetterCase()
    {
        string[] args = { "*" };
        var program = new ProgramWrapper();
        var actual = program.Main(args);

        var expected = @"Please provide a character from the English Alphabet.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestIgnoreFurtherArgumentsCase()
    {
        string[] args = { "C", "SomeFurtherArgumentNotTakenIntoAccount" };
        var program = new ProgramWrapper(new DiamondShapeGenerator('_'));
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