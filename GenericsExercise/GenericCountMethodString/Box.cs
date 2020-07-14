using System;
using System.Collections.Generic;


namespace GenericCountMethodString
{
	public class Box<T> where T : IComparable
	{
		public List<T> items { get; set; }

		public Box()
		{
			this.items = new List<T>();
		}

		public int ComapareElement(T element)
		{
			var countBiggerElements = 0;

			foreach (var item in items)
			{
				if (item.CompareTo(element) > 0)
				{
					countBiggerElements++;
				}
			}

			return countBiggerElements;
		}
	}
}
