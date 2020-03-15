using System;
using System.Collections.Generic;

namespace _07.TrafficJam
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var carQueue = new Queue<string>();
			int totalCounter = 0;
			string carName = Console.ReadLine();

			while (carName.ToLower() != "end")
			{
				if (carName.ToLower() != "green")
				{
					carQueue.Enqueue(carName);
				}
				else
				{
					int carToPass = Math.Min(n, carQueue.Count);

					for (int i = 0; i < carToPass; i++)
					{
						Console.WriteLine($"{carQueue.Dequeue()} passed!");
						totalCounter++;
					}
				}

				carName = Console.ReadLine();
			}

			Console.WriteLine($"{totalCounter} cars passed the crossroads.");
		}
	}
}
