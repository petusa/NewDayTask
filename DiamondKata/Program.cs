public class ProgramWrapper
{
    private DiamondShapeGenerator generator;

    public ProgramWrapper()
    {
        generator = new DiamondShapeGenerator();
    }

    public ProgramWrapper(DiamondShapeGenerator generator)
    {
        this.generator = generator;
    }

    public string Main(string[] args)
    {
        if (args.Length == 0 || args[0].Length != 1)
        {
            return "Please provide a single character as an argument.";
        }

        char character = args[0][0];

        if (!char.IsLetter(character))
        {
            return "Please provide a character from the English Alphabet.";

        }

        return generator.Generate(character);
    }

}

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine(new ProgramWrapper().Main(args));
    }

}