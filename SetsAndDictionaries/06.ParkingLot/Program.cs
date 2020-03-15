using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
	class Program
	{
		static void Main(string[] args)
		{
			var currentInput = Console.ReadLine().Split(", ").ToArray();
			var parkingLot = new HashSet<string>();

			while (currentInput[0] != "END")
			{
				var direction = currentInput[0];
				var carNumber = currentInput[1];

				if (direction.ToLower() == "in")
				{
					parkingLot.Add(carNumber);
				}
				else if (direction.ToLower() == "out")
				{
					parkingLot.Remove(carNumber);
				}
				currentInput = Console.ReadLine().Split(", ").ToArray();
			}

			if (parkingLot.Count > 0)
			{
				foreach (var car in parkingLot)
				{
					Console.WriteLine(car);
				}
			}
			else
			{
				Console.WriteLine("Parking Lot is Empty");
			}
		}
	}
}
