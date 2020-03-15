using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var diff = new Queue<int>();

			for (int i = 0; i < n; i++)
			{
				var pumps = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
				diff.Enqueue(pumps[0] - pumps[1]);
			}

			int index = 0;

			while (true)
			{
				var copyDiff = new Queue<int>(diff);
				int fuel = -1;

				while (copyDiff.Any())
				{
					if (copyDiff.Peek() > 0 && fuel == -1)
					{
						fuel = copyDiff.Dequeue();
						diff.Enqueue(diff.Dequeue());
					}
					else if (copyDiff.Peek() < 0 && fuel == -1)
					{
						copyDiff.Enqueue(copyDiff.Dequeue());
						diff.Enqueue(diff.Dequeue());
						index++;
					}
					else
					{
						fuel += copyDiff.Dequeue();

						if (fuel < 0)
						{
							break;
						}
					}
				}

				if (fuel >= 0)
				{
					Console.WriteLine(index);
					return;
				}

				index++;
			}
		}
	}
}
