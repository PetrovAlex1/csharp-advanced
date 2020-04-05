using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine()
				.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			Func<int, bool> filterNumbers = n => n % 2 == 0;
			Func<int, int> orderNumbers = n => n;

			var filteredList = input
				.Where(filterNumbers)
				.OrderBy(orderNumbers)
				.ToList();

			Console.WriteLine(string.Join(", ", filteredList));
		}
	}
}
