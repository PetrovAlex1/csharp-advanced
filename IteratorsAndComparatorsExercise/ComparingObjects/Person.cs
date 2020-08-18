using System;
using System.Diagnostics.CodeAnalysis;

namespace ComparingObjects
{
	public class Person : IComparable<Person>
	{
		public Person(string name, int age, string town)
		{
			this.Name = name;
			this.Town = town;
			this.Age = age;
		}

		public string Name { get; set; }

		public int Age { get; set; }

		public string Town { get; set; }

		public int CompareTo(Person other)
		{
			if (this.Town == other.Town && this.Age == other.Age && this.Name == other.Name)
			{
				return 0;
			}

			return -1;
		}

	}
}
