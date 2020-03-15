using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.HotPotato
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			int n = int.Parse(Console.ReadLine());
			var children = new Queue<string>(input);
			int counter = 0;

			while (children.Count != 1)
			{
				counter++;

				if (counter % n != 0)
				{
					string currentChild = children.Peek();
					children.Enqueue(currentChild);
					children.Dequeue();
				}
				else
				{
					Console.WriteLine($"Removed {children.Dequeue()}");
				}
			}

			Console.WriteLine($"Last is {children.Dequeue()}");
		}
	}
}
