using System;
using System.Collections.Generic;

namespace GenericSwapMethosString
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var box = new Box<string>();
			box.Items = new List<string>();

			for (int i = 0; i < n; i++)
			{
				var currentInput = Console.ReadLine();
				box.Items.Add(currentInput);
			}

			var swapIndexes = Console.ReadLine().Split();
			var firstIndex = int.Parse(swapIndexes[0]);
			var secondIndex = int.Parse(swapIndexes[1]);
			box.SwapItems(firstIndex, secondIndex);
			box.Print();

		}
	}
}
