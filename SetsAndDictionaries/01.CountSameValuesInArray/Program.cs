using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
	class Program
	{
		static void Main(string[] args)
		{
			var dict = new Dictionary<double, int>();
			var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

			for (int i = 0; i < input.Length; i++)
			{
				if (!dict.ContainsKey(input[i]))
				{
					dict[input[i]] = 1;
					continue;
				}

				dict[input[i]]++;
			}

			foreach (var kvp in dict)
			{
				double number = kvp.Key;
				int count = kvp.Value;

				Console.WriteLine($"{number} - {count} times");
			}
		}
	}
}
