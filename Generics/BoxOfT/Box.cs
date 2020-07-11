using System.Collections.Generic;

namespace BoxOfT
{
	public class Box<T>
	{
		private List<T> values;

		public int Count
		{
			get
			{
				return this.values.Count;
			}
		}

		public Box()
		{
			this.values = new List<T>();
		}

		public void AddElement(T item)
		{
			this.values.Add(item);
		}

		public T Remove()
		{
			var removedElement = this.values[this.values.Count - 1];
			this.values.RemoveAt(this.values.Count - 1);
			return removedElement;
		}
	}
}
