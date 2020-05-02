using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var divisibleNumbers = new List<int>();
			bool isDivisible = true;

			for (int i = 1; i <= n; i++)
			{
				foreach (var num in sequence)
				{
					if (i % num == 0)
					{
						isDivisible = true;
						continue;
					}
					else
					{
						isDivisible = false;
						break;
					}
				}

				if (isDivisible)
				{
					divisibleNumbers.Add(i);
				}
				else
				{
					continue;
				}
			}

			Console.WriteLine(string.Join(" ", divisibleNumbers));
		}
	}
}
