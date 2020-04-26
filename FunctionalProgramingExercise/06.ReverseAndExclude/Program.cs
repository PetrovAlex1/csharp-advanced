using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
			var deviser = int.Parse(Console.ReadLine());
			Func<int, bool> filter = x => x % deviser != 0;
			input = input.Where(filter).ToArray();

			Console.WriteLine(string.Join(" ", input));

		}
	}
}
