using System;
using System.Linq;

namespace _02.SumNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine()
				.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			Console.WriteLine(input.Count);
			Console.WriteLine(input.Sum());
		}
	}
}
