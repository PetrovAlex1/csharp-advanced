using System;
using System.Collections.Generic;

namespace GenericSwapMethosString
{
	public class Box<T>
	{
		public List<T> Items { get; set; }

		public List<T> SwapItems(int firstIndex, int secondIndex)
		{
			var firstItem = Items[firstIndex];
			var secondItem = Items[secondIndex];

			Items[firstIndex] = secondItem;
			Items[secondIndex] = firstItem;

			return Items;
		}

		public void Print()
		{
			foreach (var item in Items)
			{
				Console.WriteLine($"{item.GetType()}: {item}");
			}
		}
	}
}
