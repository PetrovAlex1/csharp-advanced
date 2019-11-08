using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int bounds = int.Parse(Console.ReadLine());
            var matrix = new int[bounds, bounds];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentInput[col];
                }
            }

            var command = Console.ReadLine().Split().ToArray();

            while (command[0].ToLower() != "end")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                switch (command[0].ToLower())
                {
                    case "add":
                        if (IsInRange(matrix, row, col))
                        {
                            matrix[row, col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "subtract":
                        if (IsInRange(matrix, row, col))
                        {
                            matrix[row, col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool IsInRange(int[,] matrix, int row, int col)
        {
            if (row <= matrix.GetLength(0) && col <= matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
