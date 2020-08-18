using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var nameSet = new SortedSet<Person>(new NameComparer()); 
			var ageSet = new SortedSet<Person>(new AgeComparator());

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split().ToArray();
				var person = new Person(input[0], int.Parse(input[1]));
				nameSet.Add(person);
				ageSet.Add(person);
			}

			foreach (var person in nameSet)
			{
				Console.WriteLine($"{person.Name} {person.Age}");
			}
			foreach (var person in ageSet)
			{
				Console.WriteLine($"{person.Name} {person.Age}");
			}
		}
	}
}
