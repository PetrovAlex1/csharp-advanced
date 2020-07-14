using System;

namespace GenericCountMethodString
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var box = new Box<string>();

			for (int i = 0; i < n; i++)
			{
				var currentInput = Console.ReadLine();
				box.items.Add(currentInput);
			}

			var elementToCompare = Console.ReadLine();
			Console.WriteLine(box.ComapareElement(elementToCompare));
		}
	}
}
