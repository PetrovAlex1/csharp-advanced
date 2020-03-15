using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
	class Program
	{
		static void Main(string[] args)
		{
			int quantityFood = int.Parse(Console.ReadLine());
			int[] orders = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var queue = new Queue<int>(orders);
			int maxNumber = queue.Max();
			bool cannotComplete = false;

			while (queue.Any() && quantityFood > 0)
			{
				int currentOreder = queue.Peek();

				if ((quantityFood - currentOreder) >= 0)
				{
					quantityFood -= currentOreder;
					queue.Dequeue();
				}
				else if (currentOreder == 0)
				{
					queue.Dequeue();
				}
				else
				{
					cannotComplete = true;
					break;
				}
			}

			if (cannotComplete)
			{
				Console.WriteLine(maxNumber);
				Console.Write("Orders left: " + string.Join(" ", queue));
			}
			else
			{
				Console.WriteLine(maxNumber);
				Console.WriteLine("Orders complete");
			}
		}
	}
}
