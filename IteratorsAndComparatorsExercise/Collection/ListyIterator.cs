using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
	public class ListyIterator<T> : IEnumerable<T>
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
				this.index++;
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

		public void PrintAll()
		{
			Console.WriteLine(string.Join(" ", items));
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < items.Count; i++)
			{
				yield return items[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}
}
