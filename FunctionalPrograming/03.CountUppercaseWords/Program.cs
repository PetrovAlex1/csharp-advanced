using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

			var input = Console.ReadLine()
				.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Where(checker)
				.ToList();

			input.ForEach(Console.WriteLine);
		}
	}
}
