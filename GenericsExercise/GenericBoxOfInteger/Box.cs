
namespace GenericBoxOfInteger
{
	public class Box<T>
	{
		private T data;

		public Box(T item)
		{
			this.data = item;
		}

		public override string ToString()
		{
			return $"{data.GetType()}: {data}";
		}
	}
}
