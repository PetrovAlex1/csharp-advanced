using System;
using System.Linq;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] cymbols = { " ", ", " };
			var command = Console.ReadLine().Split(cymbols, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var stack = new Stack<string>();

			while (command[0] != "END")
			{
				switch (command[0])
				{
					case "Push":
						var items = command.Where(x => x != "Push").ToList();
						stack.Push(items);
						break;
					case "Pop":
						stack.Pop();
						break;
					default:
						break;
				}

				command = Console.ReadLine().Split(cymbols, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			stack.Print();
		}
	}
}
