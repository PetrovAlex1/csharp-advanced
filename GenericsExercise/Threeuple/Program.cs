using System;

namespace Threeuple
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstInput = Console.ReadLine().Split();
			var firstName = firstInput[0];
			var lastName = firstInput[1];
			var address = firstInput[2];
			var town = firstInput[3];
			var fullName = firstName + " " + lastName;
			var firstThreeuple = new Threeuple<string, string, string>(fullName, address, town);
			Console.WriteLine(firstThreeuple.ToString());

			var secondInput = Console.ReadLine().Split();
			var name = secondInput[0];
			var litersOfBeer = int.Parse(secondInput[1]);
			var drunkOrNot = secondInput[2];
			var isDrunk = false;

			if (drunkOrNot == "drunk")
			{
				isDrunk = true;
			}

			var secondThreeuple = new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk);
			Console.WriteLine(secondThreeuple.ToString());

			var thirdInput = Console.ReadLine().Split();
			var accountName = thirdInput[0];
			var accountBalance = double.Parse(thirdInput[1]);
			var bankName = thirdInput[2];
			var thirdThreeuple = new Threeuple<string, double, string>(accountName, accountBalance, bankName);
			Console.WriteLine(thirdThreeuple.ToString());
		}
	}
}
