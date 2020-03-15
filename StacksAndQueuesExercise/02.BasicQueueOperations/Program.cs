using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			var command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			int numbersToPush = int.Parse(command[0]);
			int numbersToPop = int.Parse(command[1]);
			int numberToPeek = int.Parse(command[2]);
			var numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			var stackOfNumbers = new Queue<string>();

			for (int i = 0; i < numbersToPush; i++) //Push
			{
				stackOfNumbers.Enqueue(numbers[i]);
			}
			for (int i = 0; i < numbersToPop; i++) //Pop
			{
				stackOfNumbers.Dequeue();
			}


			if (stackOfNumbers.Contains(numberToPeek.ToString()))
			{
				Console.WriteLine("true");
			}
			else
			{
				if (stackOfNumbers.Count == 0)
				{
					Console.WriteLine(0);
				}
				else
				{
					Console.WriteLine(stackOfNumbers.Min());
				}
			}
		}
	}
}
