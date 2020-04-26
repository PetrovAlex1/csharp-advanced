using System;

namespace _01.ActionPrint
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();
			Action<string[]> printSeparately = x => Console.WriteLine(string.Join(System.Environment.NewLine, x));
			printSeparately(input);
		}
	}
}
