using System;
using System.Linq;

namespace Froggy
{
	class Program
	{
		static void Main(string[] args)
		{
			var stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
			var lake = new Lake(stones);
			lake.Print();
		}
	}
}
