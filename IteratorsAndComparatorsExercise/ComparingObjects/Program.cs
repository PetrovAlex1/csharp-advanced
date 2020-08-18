using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().ToArray();
			var people = new List<Person>();

			while (true)
			{
				if (input[0].ToLower() == "end")
				{
					break;
				}

				var person = new Person(input[0], int.Parse(input[1]), input[2]);
				people.Add(person);
				input = Console.ReadLine().Split().ToArray();
			}

			var position = int.Parse(Console.ReadLine());
			var samePerson = 0;

			foreach (var person in people)
			{
				if (person.CompareTo(people[position - 1]) == 0)
				{
					samePerson++;
				}
			}

			if (samePerson == 1)
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine($"{samePerson} {people.Count - samePerson} {people.Count}");
			}
		}
	}
}
