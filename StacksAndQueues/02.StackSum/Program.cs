using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var numbers = new Stack<int>();

			for (int i = 0; i < input.Length; i++)
			{
				numbers.Push(int.Parse(input[i].ToString()));
			}

			while (true)
			{
				string[] commandInput = Console.ReadLine().Split(" ");
				string command = commandInput[0].ToLower();

				if (command == "end")
				{
					break;
				}
				else if (command == "add")
				{
					for (int i = 1; i <= 2; i++)
					{
						numbers.Push(int.Parse(commandInput[i]));
					}
				}
				else if (command == "remove")
				{
					int countRemoves = int.Parse(commandInput[1]);

					if (countRemoves > numbers.Count)
					{
						continue;
					}
					else
					{
						for (int i = 0; i < countRemoves; i++)
						{
							numbers.Pop();
						}
					}
				}
			}

			var sum = numbers.Sum();
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
