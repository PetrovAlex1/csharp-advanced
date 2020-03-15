using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
	class Program
	{
		static void Main(string[] args)
		{
			var continents = new Dictionary<string, List<string>>();
			var countries = new Dictionary<string, List<string>>();
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split().ToArray();
				var continent = input[0];
				var country = input[1];
				var city = input[2];

				if (!continents.ContainsKey(continent))
				{
					continents[continent] = new List<string>();
				}
				if (!continents[continent].Contains(country))
				{
					continents[continent].Add(country);
					countries[country] = new List<string>();
				}
				if (!countries[country].Contains(city))
				{
					countries[country].Add(city);
				}
			}

			foreach (var continent in continents)
			{
				Console.WriteLine(continent.Key + ":");

				foreach (var country in countries)
				{
					if (continent.Value.Contains(country.Key))
					{
						Console.Write("  " + country.Key + " -> " + string.Join(", ", country.Value));
						Console.WriteLine();
					}
				}
			}
		}
	}
}
