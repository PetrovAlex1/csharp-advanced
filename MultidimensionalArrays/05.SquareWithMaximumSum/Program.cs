using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentInput[col];
                }
            }

            int maxSum = int.MinValue;
            int currentMaxSum = 0;
            var maxMatrix = new int[2, 2];

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    currentMaxSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentMaxSum > maxSum)
                    {
                        maxSum = currentMaxSum;
                        maxMatrix[0, 0] = matrix[row, col];
                        maxMatrix[0, 1] = matrix[row, col + 1];
                        maxMatrix[1, 0] = matrix[row + 1, col];
                        maxMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            for (int row = 0; row < maxMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxMatrix.GetLength(1); col++)
                {
                    Console.Write(maxMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
