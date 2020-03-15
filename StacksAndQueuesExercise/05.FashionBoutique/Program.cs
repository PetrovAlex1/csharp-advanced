using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FashionBoutique
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] clothesInBox = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int capacity = int.Parse(Console.ReadLine());
			var clothes = new Stack<int>(clothesInBox);
			int currentSum = 0;
			int countRacks = 0;


			while (clothes.Any())
			{
				int currentBox = clothes.Peek();
				currentSum += currentBox;

				if (currentSum == capacity)
				{
					clothes.Pop();
					currentSum = 0;
					countRacks++;

					if (clothes.Count == 0)
					{
						break;
					}
				}
				else if (currentSum > capacity)
				{
					currentSum = 0;
					countRacks++;
				}
				else
				{
					clothes.Pop();
				}
				if (clothes.Count == 0)
				{
					countRacks++;
				}
			}

			Console.WriteLine(countRacks);
		}
	}
}
