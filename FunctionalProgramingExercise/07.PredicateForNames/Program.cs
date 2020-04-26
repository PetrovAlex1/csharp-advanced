using System;
using System.Linq;

namespace _07.PredicateForNames
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var input = Console.ReadLine().Split().ToList();
			Func<string, bool> checkName = x => x.Length <= n ? true : false;

			foreach (var name in input)
			{
				if (checkName(name))
				{
					Console.WriteLine(name);
				}
			}
		}
	}
}
