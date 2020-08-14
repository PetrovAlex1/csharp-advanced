using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
	public class Stack<T> : IEnumerable<T>
	{
		private List<T> data = new List<T>();

		public void Push(List<T> items)
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (data.Count == 0)
				{
					data.Add(items[i]);
					continue;
				}
				else
				{
					data.Insert(0, items[i]);
				}
			}
		}

		public void Pop()
		{
			if (data.Count != 0)
			{
				data.RemoveAt(0);
			}
			else
			{
				Console.WriteLine("No elements");
				Environment.Exit(0);
			}
		}

		public void Print()
		{
			foreach (var item in data)
			{
				Console.WriteLine(item);
			}
			foreach (var item in data)
			{
				Console.WriteLine(item);
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < data.Count; i++)
			{
				yield return data[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}
}
