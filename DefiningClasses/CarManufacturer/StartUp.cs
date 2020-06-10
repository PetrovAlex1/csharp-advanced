using System;
using System.Collections.Generic;

namespace CarManufacturer
{
	class StartUp
	{
		static void Main(string[] args)
		{
			var tires = new Dictionary<int, List<Tire>>();
			int j = 0;

			while (true)
			{
				var input = Console.ReadLine().Split();
				var tireList = new List<Tire>();

				if (input[0] == "No")
				{
					break;
				}

				for (int i = 0; i < input.Length; i += 2)
				{
					var year = int.Parse(input[i]);
					var presure = double.Parse(input[i + 1]);
					var tire = new Tire(year, presure);
					tireList.Add(tire);
				}

				tires.Add(j, tireList);
				j++;
			}

			var engines = new List<Engine>();

			while (true)
			{
				var input = Console.ReadLine().Split();

				if (input[0] == "Engines")
				{
					break;
				}

				var horsePower = int.Parse(input[0]);
				var cubicCapacity = double.Parse(input[1]);
				var engine = new Engine(horsePower, cubicCapacity);
				engines.Add(engine);
			}

			var cars = new List<Car>();

			while (true)
			{
				var input = Console.ReadLine().Split();

				if (input[0] == "Show")
				{
					break;
				}

				var make = input[0];
				var model = input[1];
				var year = int.Parse(input[2]);
				var fuelQuantity = double.Parse(input[3]);
				var fuelConsumption = double.Parse(input[4]);
				var engineIndex = int.Parse(input[5]);
				var tireIndex = int.Parse(input[6]);
				var engine = engines[engineIndex];
				var tire = tires[tireIndex].ToArray();
				var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
				cars.Add(car);
			}

			foreach (var car in cars)
			{
				var presureSum = 0.0;

				if (car.Year >= 2017)
				{
					if (car.Engine.HorsePower > 330)
					{
						for (int i = 0; i < car.Tires.Length; i++)
						{
							presureSum += car.Tires[i].Presure;
						}

						if (presureSum >= 9 && presureSum < 10)
						{
							car.Drive(20);
							PrintInformation(car);
						}
					}
				}
			}
		}

		private static void PrintInformation(Car car)
		{
			Console.WriteLine($"Make: {car.Make}" +
							  $"\nModel: {car.Model}" +
							  $"\nYear: {car.Year} " +
							  $"\nHorsePowers: {car.Engine.HorsePower}" +
							  $"\nFuelQuantity: {car.FuelQuantity}");
		}
	}
}
