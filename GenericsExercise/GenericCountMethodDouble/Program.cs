using System;

namespace GenericCountMethodDouble
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var box = new Box<double>();

			for (int i = 0; i < n; i++)
			{
				var currentInput = double.Parse(Console.ReadLine());
				box.Items.Add(currentInput);
			}

			var elementToCompare = double.Parse(Console.ReadLine());

			Console.WriteLine(box.CountGreaterElements(elementToCompare));
		}
	}
}
