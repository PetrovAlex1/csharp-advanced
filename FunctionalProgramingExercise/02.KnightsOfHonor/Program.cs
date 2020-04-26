using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();
			Action<string[]> print = x => Console.WriteLine(string.Join(Environment.NewLine, x.Select(x => $"Sir {x}")));
			print(input);

		}
	}
}
