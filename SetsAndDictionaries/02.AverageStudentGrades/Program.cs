using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var students = new Dictionary<string, List<double>>();

			for (int i = 0; i < n; i++)
			{
				var line = Console.ReadLine().Split().ToArray();
				var name = line[0];
				var grade = double.Parse(line[1]);

				if (!students.ContainsKey(name))
				{
					students[line[0]] = new List<double>();
				}

				students[name].Add(grade);
			}

			foreach (var kvp in students)
			{
				var name = kvp.Key;
				var avarageGrade = kvp.Value.Average();
				var grades = kvp.Value;

				Console.Write($"{name} -> ");

				foreach (var grade in kvp.Value)
				{
					Console.Write($"{grade:F2} ");
				}

				Console.Write($"(avg: {avarageGrade:F2})");
				Console.WriteLine();
			}
		}
	}
}
