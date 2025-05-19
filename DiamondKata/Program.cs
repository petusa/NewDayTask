using System;

static class DiamondShapeGenerator
{
    public static string Generate(char input)
    {
        throw new NotImplementedException();
    }

}

public class ProrgamWrapper
{
    public string Run(string[] args)
    {
        if (args.Length == 0 || args[0].Length != 1)
        {
            return "Please provide a single character as an argument.";
        }

        char c = args[0][0];

        if (!char.IsLetter(c))
        {
            return "Please provide a character from the English Alphabet.";

        }

        return DiamondShapeGenerator.Generate(c);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(new ProrgamWrapper().Run(args));
    }

}