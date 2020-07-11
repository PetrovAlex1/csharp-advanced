using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
	class ArrayCreator<T>
	{
		public static T[] Create(int length, T item)
		{
			T[] values = new T[length];

			for (int i = 0; i < values.Length; i++)
			{
				values[i] = item;
			}

			return values;
		}
	}
}
