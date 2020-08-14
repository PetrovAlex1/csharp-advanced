
using System;
using System.Linq;
using System.Collections.Generic;

namespace Froggy
{
	public class Lake
	{
		private List<int> stones;
		private List<int> evens = new List<int>();
		private List<int> odds = new List<int>();

		public Lake(List<int> items)
		{
			this.stones = items;
		}

		private void DevideStones()
		{
			for (int i = 0; i < stones.Count; i++)
			{
				if (i % 2 == 0)
				{
					evens.Add(stones[i]); // 4etni
				}
				else
				{
					odds.Add(stones[i]);
				}
			}
		}

		private void SortStones()
		{
			DevideStones();
			var newEvens = evens.OrderBy(x => x).ToList();
			odds.Reverse();
			stones.Clear();
			stones.AddRange(evens);
			stones.AddRange(odds);

		}

		public void Print()
		{
			SortStones();
			Console.WriteLine(string.Join(", ", stones));
		}

	}
}
