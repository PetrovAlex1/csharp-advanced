using System;
using System.Collections.Generic;

namespace _05.Supermarket
{
	class Program
	{
		static void Main(string[] args)
		{
			var people = new Queue<string>();
			int counter = 0;
			bool findPaid = false;

			while (true)
			{
				string name = Console.ReadLine();

				if (name.ToLower() == "paid")
				{
					findPaid = true;

					foreach (var currentName in people)
					{
						Console.WriteLine(currentName);
					}

					counter = 0;

					continue;
				}
				else if (name.ToLower() == "end")
				{
					break;
				}
				else
				{
					people.Enqueue(name);
				}

				counter++;
			}

			Console.WriteLine($"{counter} people remaining.");
		}
	}
}
