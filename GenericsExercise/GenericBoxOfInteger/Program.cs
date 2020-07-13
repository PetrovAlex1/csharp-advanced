using System;

namespace GenericBoxOfInteger
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				var currentInteger = int.Parse(Console.ReadLine());
				var box = new Box<int>(currentInteger);
				Console.WriteLine(box.ToString());
			}
		}
	}
}
