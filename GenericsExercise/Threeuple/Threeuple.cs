
namespace Threeuple
{
	public class Threeuple<T, C, V>
	{
		public T Item1 { get; set; }
		public C Item2 { get; set; }
		public V Item3 { get; set; }

		public Threeuple(T item1, C item2, V item3)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
		}

		public override string ToString()
		{
			return $"{Item1} -> {Item2} -> {Item3}";
		}
	}
}
