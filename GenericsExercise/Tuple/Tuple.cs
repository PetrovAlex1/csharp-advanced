
using System;

namespace Tuple
{
	public class Tuple<T>
	{
		public T Item1 { get; set; }
		public T Item2 { get; set; }
		public Tuple(T item1, T item2)
		{
			this.Item1 = item1;
			this.Item2 = item2;
		}
		public override string ToString()
		{
			return $"{Item1} -> {Item2}";
		}

		public void Print()
		{
			Console.WriteLine($"{Item1} -> {Item2}");
		}
	}
}
