using System;
using System.Linq;

namespace _04.AddVAT
{
	class Program
	{
		static void Main(string[] args)
		{


			var input = Console.ReadLine()
				.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.Select(x => x * 1.2)
				.ToArray();

			foreach (var price in input)
			{
				Console.WriteLine($"{price:F2}");
			}
		}
	}
}
