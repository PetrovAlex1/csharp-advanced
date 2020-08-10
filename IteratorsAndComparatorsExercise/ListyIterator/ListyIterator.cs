
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator1
{
	public class ListyIterator<T>
	{
		private List<T> items;
		private int index = 0;

		public ListyIterator(params T[] items)
		{
			this.items = items.ToList();
		}

		public bool Move()
		{
			var couldMove = false;

			if (index < items.Count)
			{
				couldMove = true;
				index++;
			}

			return couldMove;
		}

		public bool HasNext()
		{
			var hasNext = false;

			if (index < items.Count - 1)
			{
				hasNext = true;
			}

			return hasNext;
		}

		public void Print()
		{
			if (items.Count == 0)
			{
				Console.WriteLine("Invalid Operation!");
			}
			else
			{
				Console.WriteLine(items[index]);
			}
		}
	}
}
