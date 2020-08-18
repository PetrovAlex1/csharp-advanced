using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace StrategyPattern
{
	public class AgeComparator : IComparer<Person>
	{
		public int Compare(Person first, Person second)
		{
			var ageDiff = first.Age - second.Age;

			return ageDiff;
		}
	}
}
