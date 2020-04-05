using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
	class Program
	{
		public class Person
		{
			public string Name { get; set; }

			public int Age { get; set; }
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var list = new List<Person>();

			for (int i = 0; i < n; i++)
			{
				var currentInput = Console.ReadLine().Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
				Person person = new Person();
				person.Name = currentInput[0];
				person.Age = int.Parse(currentInput[1]);
				list.Add(person);
			}

			string condition = Console.ReadLine();
			int ageToCheck = int.Parse(Console.ReadLine());
			string format = Console.ReadLine();
			Func<Person, bool> ageFilter;


			if (condition == "older")
			{
				ageFilter = p => p.Age >= ageToCheck;
			}
			else
			{
				ageFilter = p => p.Age < ageToCheck;
			}

			var resultList = list
				   .Where(ageFilter)
				   .ToList();

			if (format == "name age")
			{
				foreach (var currentPerson in resultList)
				{
					Console.WriteLine($"{currentPerson.Name} - {currentPerson.Age}");
				}
			}
			else if (format == "name")
			{
				foreach (var currentPerson in resultList)
				{
					Console.WriteLine($"{currentPerson.Name}");
				}
			}
			else if (format == "age")
			{
				foreach (var currentPerson in resultList)
				{
					Console.WriteLine($"{currentPerson.Age}");
				}
			}


		}
	}
}
