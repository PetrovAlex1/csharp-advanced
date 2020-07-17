using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstIsInt = false;
			var secondIsDouble = false;
			var counter = 0;
			var firstInput = Console.ReadLine().Split();
			var firstName = firstInput[0];
			var secondName = firstInput[1];
			var address = firstInput[2];
			var fullName = firstName + " " + secondName;
			var tupleNames = new Tuple<string, string>(fullName, address);
			Console.WriteLine($"{fullName} -> {address}");

			var secondInput = Console.ReadLine().Split();
			var name = secondInput[0];
			var litersOfBeer = double.Parse(secondInput[1]);
			Console.WriteLine($"{name} -> {litersOfBeer}");

			var thirdInput = Console.ReadLine().Split();
			var intValue = int.Parse(thirdInput[0]);
			var doubleValue = double.Parse(thirdInput[1]);
			var tupleDigits = new Tuple<int, double>(intValue, doubleValue);
			Console.WriteLine($"{intValue} -> {doubleValue}");
		}
	}
}
