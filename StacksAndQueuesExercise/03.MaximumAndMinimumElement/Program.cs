using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var numbers = new Stack<int>();
			var list = new List<int>();

			for (int i = 0; i < n; i++)
			{
				var currentCommand = Console.ReadLine().Split(" ");
				int commandNumber = int.Parse(currentCommand[0]);

				switch (commandNumber)
				{
					case 1:
						int numberToPush = int.Parse(currentCommand[1]);
						numbers.Push(numberToPush);
						break;
					case 2:
						if (numbers.Count > 0)
						{
							numbers.Pop();
						}
						break;
					case 3:
						if (numbers.Count > 0)
						{
							list = numbers.OrderByDescending(x => x).ToList();
							Console.WriteLine(list[0]);
						}
						break;
					case 4:
						if (numbers.Count > 0)
						{
							list = numbers.OrderBy(x => x).ToList();
							Console.WriteLine(list[0]);
						}
						break;
					default:
						break;
				}
			}

			Console.WriteLine(string.Join(", ", numbers));
		}
	}
}
