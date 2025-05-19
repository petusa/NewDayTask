namespace DiamondKata.Tests;

using Xunit;

public class DiamondKataTests
{
    [Fact]
    public void TestNoArgumentsProvidedCase()
    {
        string[] args = { };
        var application = new ProgramWrapper();
        var actual = application.Run(args);

        var expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestNoSingleCharacterProvidedAsFirstArgumentCase()
    {
        string[] args = { "AB" };
        var application = new ProgramWrapper();
        var actual = application.Run(args);

        var expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestIgnoreFurtherArgumentsCase()
    {
        string[] args = { "C", "SomeFurtherArgumentNotTakenIntoAccount" };
        var application = new ProgramWrapper();
        var actual = application.Run(args);

        var expected = @"  A  
 B B 
C   C
 B B 
  A  
".ReplaceLineEndings();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestNonLetterCase()
    {
        string[] args = { "*" };
        var application = new ProgramWrapper();
        var actual = application.Run(args);

        var expected = @"Please provide a character from the English Alphabet.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestHappyCase()
    {
        string[] args = { "C" };
        var application = new ProgramWrapper();
        var actual = application.Run(args);

        var expected = @"  A  
 B B 
C   C
 B B 
  A  
".ReplaceLineEndings();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestHappyCaseForCaseSensitiveness()
    {
        string[] args = { "c" };
        var application = new ProgramWrapper();
        var actual = application.Run(args);

        var expected = @"  a  
 b b 
c   c
 b b 
  a  
".ReplaceLineEndings();

        Assert.Equal(expected, actual);
    }
}