using System.Text;

static class DiamondShapeGenerator
{

    private static char[] GenerateEmptyRow(int size)
    {
        var row = new char[size];
        for (int i = 0; i < size; i++)
        {
            row[i] = ' ';
        }
        return row;
    }

    public static string Generate(char character)
    {
        int indexInAlphabet = char.ToUpper(character) - 'A';
        int size = indexInAlphabet * 2 + 1; // length of rows and columns: size of generated grid
        var output = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            var row = GenerateEmptyRow(size);

            var leftIndex = Math.Abs(indexInAlphabet - i);
            var rightIndex = size - leftIndex - 1;

            var characterInRow = (char)(character - leftIndex);

            row[leftIndex] = characterInRow;
            row[rightIndex] = characterInRow;

            output.Append(new string(row));
            output.Append("\n");
        }
        return output.ToString();
    }

}

public class ProgramWrapper
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
        Console.WriteLine(new ProgramWrapper().Run(args));
    }

}