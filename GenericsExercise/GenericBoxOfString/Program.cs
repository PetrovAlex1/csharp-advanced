using System;

namespace GenericBoxOfString
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				var currentInput = Console.ReadLine();
				var currentBox = new Box<string>(currentInput);
				Console.WriteLine(currentBox.ToString());
			}
		}
	}
}
