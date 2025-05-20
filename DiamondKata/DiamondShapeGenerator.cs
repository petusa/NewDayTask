using System.Text;

public class DiamondShapeGenerator
{

    private char nonVisibleChar;

    public DiamondShapeGenerator(char nonVisibleChar = ' ')
    {
        this.nonVisibleChar = nonVisibleChar;
    }

    private char[] GenerateEmptyRow(int size)
    {
        var row = new char[size];
        for (int i = 0; i < size; i++)
        {
            row[i] = nonVisibleChar;
        }
        return row;
    }

    public string Generate(char character)
    {
        var indexInAlphabet = char.ToUpper(character) - 'A';
        var size = indexInAlphabet * 2 + 1; // length of rows and columns: size of generated grid

        var output = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            char[] row = GenerateEmptyRow(size);

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