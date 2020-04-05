using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProspectorsSolution
{
    class Program
    {
        public static List<string> commands = new List<string>()
        {
            "Up",
            "Down",
            "Right",
            "Left"
        };

        public static int ourGuyDiamondCOunter = 0;
        public static int someGuysDiamondCOunter = 0;
        public static int allDiamonds = 0;

        static void Main(string[] args)
        {
            string[,] field = CreateField();
            DrawField(field);
            string direction = Direction();
            Console.Clear();

            while (direction != null && AreThereDiamonds(field))
            {
                MoveOurGuy(field, direction);
                MoveSomeGuy(field);
                Console.Clear();
                Thread.Sleep(100);
                DrawField(field);
                direction = Direction();
            }

            Console.Clear();
            Console.WriteLine("Game over!");
            Console.WriteLine($"All diamonds :{allDiamonds}");
            Console.WriteLine($"OurGuy collected: {(ourGuyDiamondCOunter * 100) / allDiamonds}% of the diamonds.");
            Console.WriteLine($"SomeGuys collected: {(someGuysDiamondCOunter * 100) / allDiamonds}% of the diamonds.");
        }

        public static int[] GetFieldBounds(int maxX, int maxY)
        {
            Console.WriteLine("Define bordaries for the field:");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            var fieldSize = new int[2];

            if (!(x >= 10 && x <= maxX && y >= 10 && y <= maxY))
            {
                Console.WriteLine("Error! Invalid field size!");
            }
            else
            {
                fieldSize[0] = x;
                fieldSize[1] = y;
            }

            return fieldSize;
        }

        public static void InsertElementToField(string[,] field, double fieldSize, string element)
        {
            var coordinates = new List<string>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    coordinates.Add($"{row}{col}");
                }
            }

            Random randomNum = new Random();

            for (int i = 0; i < fieldSize; i++)
            {
                int randomRow = randomNum.Next(0, field.GetLength(0));
                int randomCol = randomNum.Next(0, field.GetLength(1));

                string currentCoordinates = $"{randomRow}{randomCol}";

                if (coordinates.Contains(currentCoordinates) && field[randomRow, randomCol] != "OurGuy")
                {
                    field[randomRow, randomCol] = element;
                    coordinates.Remove(currentCoordinates);
                }
                else
                {
                    i--;
                }
            }
        }

        static string[,] CreateField()
        {
            int[] size = GetFieldBounds(50, 50);

            int rows = size[0];
            int cols = size[1];

            var field = new string[rows, cols];

            int fieldCells = rows * cols;

            Random rnd = new Random();

            int ourGuyRow = rnd.Next(0, rows);
            int ourGuyCol = rnd.Next(0, cols);

            field[ourGuyRow, ourGuyCol] = "OurGuy";

            double groundCells = Math.Round(0.4 * fieldCells);
            double grassCells = Math.Round(0.3 * fieldCells);
            double treeCells = Math.Round(0.2 * fieldCells);
            double stoneCells = Math.Round(0.1 * fieldCells);
            double diamondCells = Math.Round(0.1 * fieldCells);
            allDiamonds = (int)diamondCells;
            double someGuyCells = Math.Round(0.05 * fieldCells);

            InsertElementToField(field, groundCells, "Ground");
            InsertElementToField(field, grassCells, "Grass");
            InsertElementToField(field, treeCells, "Tree");
            InsertElementToField(field, stoneCells, "Stone");
            InsertElementToField(field, diamondCells, "Diamond");
            InsertElementToField(field, someGuyCells, "SomeGuy");

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == null)
                    {
                        field[row, col] = "Ground";
                    }
                }
            }

            return field;
        }

        public static void DrawField(string[,] field)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    string currentCell = field[row, col];

                    switch (currentCell)
                    {
                        case "Ground":
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write('\u2592');
                                Console.ResetColor();
                            }

                            break;
                        case "Grass":
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write('\u2593');
                                Console.ResetColor();
                            }

                            break;
                        case "Tree":
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write('\u2663');
                                Console.ResetColor();
                            }

                            break;
                        case "Stone":
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write('\u00A9');
                                Console.ResetColor();
                            }

                            break;
                        case "Diamond":
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write('\u2666');
                                Console.ResetColor();
                            }

                            break;
                        case "SomeGuy":
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write('\u263b');
                                Console.ResetColor();
                            }

                            break;
                        case "OurGuy":
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write('\u263a');
                                Console.ResetColor();
                            }

                            break;
                    }
                }

                Console.WriteLine();
            }
        }

        public static bool isInside(string[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0)
                   && desiredRow >= 0
                   && desiredCol < board.GetLength(1)
                   && desiredCol >= 0;
        }

        public static string Direction()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    return "Up";
                case ConsoleKey.DownArrow:
                    return "Down";
                case ConsoleKey.LeftArrow:
                    return "Left";
                case ConsoleKey.RightArrow:
                    return "Right";
                case ConsoleKey.Escape:
                    break;
            }

            return null;
        }

        public static void MoveGuy(string[,] field, int currentRow, int currentCol, string direction, string guy)
        {
            switch (direction)
            {
                case "Up":
                    if (CanMove(field, currentRow - 1, currentCol))
                    {
                        if (field[currentRow - 1, currentCol] == "Diamond")
                        {
                            if (guy == "OurGuy")
                            {
                                ourGuyDiamondCOunter++;
                            }
                            else if (guy == "SomeGuy")
                            {
                                someGuysDiamondCOunter++;
                            }
                        }

                        field[currentRow - 1, currentCol] = guy;
                        field[currentRow, currentCol] = "Ground";
                    }

                    return;
                case "Down":
                    if (CanMove(field, currentRow + 1, currentCol))
                    {
                        if (field[currentRow + 1, currentCol] == "Diamond")
                        {
                            if (guy == "OurGuy")
                            {
                                ourGuyDiamondCOunter++;
                            }
                            else if (guy == "SomeGuy")
                            {
                                someGuysDiamondCOunter++;
                            }
                        }

                        field[currentRow + 1, currentCol] = guy;
                        field[currentRow, currentCol] = "Ground";
                    }

                    return;
                case "Left":
                    if (CanMove(field, currentRow, currentCol - 1))
                    {
                        if (field[currentRow, currentCol - 1] == "Diamond")
                        {
                            if (guy == "OurGuy")
                            {
                                ourGuyDiamondCOunter++;
                            }
                            else if (guy == "SomeGuy")
                            {
                                someGuysDiamondCOunter++;
                            }
                        }

                        field[currentRow, currentCol - 1] = guy;
                        field[currentRow, currentCol] = "Ground";
                    }

                    return;
                case "Right":
                    if (CanMove(field, currentRow, currentCol + 1))
                    {
                        if (field[currentRow, currentCol + 1] == "Diamond")
                        {
                            if (guy == "OurGuy")
                            {
                                ourGuyDiamondCOunter++;
                            }
                            else if (guy == "SomeGuy")
                            {
                                someGuysDiamondCOunter++;
                            }
                        }

                        field[currentRow, currentCol + 1] = guy;
                        field[currentRow, currentCol] = "Ground";
                    }

                    return;
            }
        }

        public static List<int> Find(string[,] field, string element)
        {
            List<int> coordinates = new List<int>();

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == element)
                    {
                        coordinates.Add(i);
                        coordinates.Add(j);
                    }
                }
            }

            return coordinates;
        }

        public static void MoveOurGuy(string[,] field, string direction)
        {
            List<int> coordinates = Find(field, "OurGuy");
            int row = coordinates[0];
            int col = coordinates[1];

            MoveGuy(field, row, col, direction, "OurGuy");
        }

        public static void MoveSomeGuy(string[,] field)
        {
            List<int> coordinates = Find(field, "SomeGuy");

            for (int i = 0; i < coordinates.Count / 2; i += 2)
            {
                int row = coordinates[i];
                int col = coordinates[i + 1];

                Random rnd = new Random();

                int position = rnd.Next(0, 4);
                string direction = commands.ElementAt(position);

                MoveGuy(field, row, col, direction, "SomeGuy");
            }
        }

        public static bool AreThereDiamonds(string[,] field)
        {
            List<int> coordinates = Find(field, "Diamond");

            if (coordinates.Any())
            {
                return true;
            }

            return false;
        }

        public static bool CanMove(string[,] field, int desiredRow, int desiredCol)
        {
            return isInside(field, desiredRow, desiredCol)
                        && (field[desiredRow, desiredCol] == "Ground"
                        || field[desiredRow, desiredCol] == "Grass"
                        || field[desiredRow, desiredCol] == "Diamond");
        }
    }
}

