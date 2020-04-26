using System;
using System.Linq;

namespace _03.CustomMinFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToList();
			Func<int, int, int> checkTwoNumbers = (a, b) => a > b ? a : b;


			for (int j = 0; j <= input.Count; j++)
			{
				if (input.Count == 1)
				{
					break;
				}

				j = 0;
				int result = checkTwoNumbers(input[j], input[j + 1]);

				if (result == input[j])
				{
					input.Remove(input[j]);
				}
				else
				{
					input.Remove(input[j + 1]);
				}
			}

			Console.WriteLine(input[0]);
		}
	}
}
