using System;

namespace GenericSwapMethodInteger
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var box = new Box<int>();

			for (int i = 0; i < n; i++)
			{
				var currentInput = int.Parse(Console.ReadLine());
				box.items.Add(currentInput);
			}

			var swapIndexes = Console.ReadLine().Split();
			var firstIndex = int.Parse(swapIndexes[0]);
			var secondIndex = int.Parse(swapIndexes[1]);
			box.SwapItems(firstIndex, secondIndex);
			box.Print();
		}
	}
}
