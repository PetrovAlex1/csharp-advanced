
using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
	public class Box<T> where T : IComparable
	{
		public List<T> Items { get; set; }

		public Box()
		{
			this.Items = new List<T>();
		}

		public int CountGreaterElements(T element)
		{
			var counter = 0;

			foreach (var item in Items)
			{
				if (item.CompareTo(element) > 0)
				{
					counter++;
				}
			}

			return counter;
		}
	}
}
