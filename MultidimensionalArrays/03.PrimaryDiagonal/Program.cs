using System;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputBound = int.Parse(Console.ReadLine());
            var rows = inputBound;
            var cols = inputBound;
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            var primaryDiagonalSum = 0;

            for (int i = 0; i < rows; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            Console.WriteLine(primaryDiagonalSum);
        }
    }
}
