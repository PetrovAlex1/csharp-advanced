using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixBounds = int.Parse(Console.ReadLine());
            var matrix = new char[matrixBounds, matrixBounds];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine();
                var currentSymbolsRow = new char[matrix.GetLength(0)];

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string currentSymbol = currentRow.Substring(col, 1);
                    currentSymbolsRow[col] = char.Parse(currentSymbol);
                    matrix[row, col] = char.Parse(currentSymbol);
                }
            }

            char symbolToSearch = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbolToSearch)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolToSearch} does not occur in the matrix");
        }
    }
}
