using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var resultList = new List<int>();
			var start = input[0];
			var end = input[1];
			var keyWord = Console.ReadLine();
			Predicate<int> findEvenNumbers = x => x % 2 == 0;
			Predicate<int> findOddNumbers = x => x % 2 != 0;

			if (keyWord.ToLower() == "odd")
			{
				for (int i = start; i <= end; i++)
				{
					if (findOddNumbers(i))
					{
						resultList.Add(i);
					}
				}
			}
			else if (keyWord.ToLower() == "even")
			{
				for (int i = start; i <= end; i++)
				{
					if (findEvenNumbers(i))
					{
						resultList.Add(i);
					}
				}
			}

			Console.WriteLine(string.Join(" ", resultList));
		}
	}
}
