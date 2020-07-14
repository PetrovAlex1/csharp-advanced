using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
	class Box<T>
	{
		public List<T> items { get; set; }

		public Box()
		{
			this.items = new List<T>();
		}

		public List<T> SwapItems(int firstIndex, int secondIndex)
		{
			var firstItem = items[firstIndex];
			var secondItem = items[secondIndex];
			items[firstIndex] = secondItem;
			items[secondIndex] = firstItem;

			return items;
		}

		public void Print()
		{
			foreach (var item in items)
			{
				Console.WriteLine($"{item.GetType()}: {item}");
			}
		}
	}
}
