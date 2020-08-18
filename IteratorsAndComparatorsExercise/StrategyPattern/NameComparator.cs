using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace StrategyPattern
{
	public class NameComparer : IComparer<Person>
	{
		public int Compare(Person first, Person second)
		{
			var lengthDiff = first.Name.Length - second.Name.Length;

			if (lengthDiff == 0)
			{
				if (char.IsUpper(first.Name[0]) && char.IsUpper(second.Name[0]))
				{
					var firstLetterResult = first.Name.CompareTo(second.Name);

					if (firstLetterResult != 0)
					{
						return firstLetterResult;
					}

					return firstLetterResult;
				}
				if (char.IsUpper(first.Name[0]))
				{
					return 0;
				}
				if (char.IsUpper(second.Name[0]))
				{
					return -1;
				}
			}

			return lengthDiff;
		}
	}
}
