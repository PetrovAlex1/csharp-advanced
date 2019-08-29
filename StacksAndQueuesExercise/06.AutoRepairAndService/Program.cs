using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.AutoRepairAndService
{
	class Program
	{
		static void Main(string[] args)
		{
			var cars = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var carsForService = new Queue<string>(cars);
			var servicedCars = new Stack<string>();

			while (true)
			{
				string command = Console.ReadLine();

				if (command.ToLower() == "end")
				{
					break;
				}
				if (command.Contains("Service"))
				{
					if (carsForService.Count > 0)
					{
						string currentCarForService = carsForService.Dequeue(); //
						Console.WriteLine($"Vehicle {currentCarForService} got served.");
						servicedCars.Push(currentCarForService);
					}
				}
				else if (command.Contains("CarInfo"))
				{
					var splitCommand = command.Split('-');
					string currentBrand = splitCommand[1];

					if (carsForService.Contains(currentBrand))
					{
						Console.WriteLine("Still waiting for service.");
					}
					else if (servicedCars.Contains(currentBrand))
					{
						Console.WriteLine("Served.");
					}

				}
				else if (command.Contains("History"))
				{
					Console.WriteLine(string.Join(", ", servicedCars));
				}
			}

			if (carsForService.Count != 0)
			{
				Console.WriteLine("Vehicles for service: " + string.Join(", ", carsForService));
			}

			Console.WriteLine("Served vehicles: " + string.Join(", ", servicedCars));
		}
	}
}
