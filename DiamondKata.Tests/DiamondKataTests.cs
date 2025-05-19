namespace DiamondKata.Tests;

using Xunit;
public class UnitTest1
{
    [Fact]
    public void TestNoArgumentsProvidedCase()
    {
        string[] args = { };
        var application = new ProrgamWrapper();
        string actual = application.Run(args);

        string expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestNoSingleCharacterProvidedAsFirstArgumentCase()
    {
        string[] args = { "AB" };
        var application = new ProrgamWrapper();
        string actual = application.Run(args);

        string expected = @"Please provide a single character as an argument.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestIgnoreFurtherArgumentsCase()
    {
        string[] args = { "C", "SomeFurtherArgumentNotTakenIntoAccount" };
        var application = new ProrgamWrapper();
        string actual = application.Run(args);

        string expected = @"  A  
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
        var application = new ProrgamWrapper();
        string actual = application.Run(args);

        string expected = @"Please provide a character from the English Alphabet.";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestHappyCase()
    {
        string[] args = { "C" };
        var application = new ProrgamWrapper();
        string actual = application.Run(args);

        string expected = @"  A  
 B B 
C   C
 B B 
  A  
".ReplaceLineEndings();

        Assert.Equal(expected, actual);
    }
}