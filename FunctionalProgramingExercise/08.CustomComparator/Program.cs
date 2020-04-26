using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CustomComparator
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Func<int, bool> checkEvenNumber = x => x % 2 == 0;
			Func<int, bool> checkOddNumber = x => x % 2 != 0;
			var evenNumbers = new List<int>();
			var oddNumbers = new List<int>();
			var resultList = new List<int>();

			for (int i = 0; i < input.Length; i++)
			{
				if (checkEvenNumber(input[i]))
				{
					evenNumbers.Add(input[i]);
				}
			}
			for (int i = 0; i < input.Length; i++)
			{
				if (checkOddNumber(input[i]))
				{
					oddNumbers.Add(input[i]);
				}
			}

			evenNumbers.Sort();
			oddNumbers.Sort();
			resultList.AddRange(evenNumbers);
			resultList.AddRange(oddNumbers);
			Console.WriteLine(string.Join(" ", resultList));
		}
	}
}
