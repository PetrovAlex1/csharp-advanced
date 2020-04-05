using System;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputBounds = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var rows = inputBounds[0];
            var cols = inputBounds[1];
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                var currentSum = 0;

                for (int row = 0; row < rows; row++)
                {
                    currentSum += matrix[row, col];
                }

                Console.WriteLine(currentSum);
            }
        }
    }
}
