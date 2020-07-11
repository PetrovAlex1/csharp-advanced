using System;

namespace BoxOfT
{
	class Program
	{
		static void Main(string[] args)
		{
			Box<int> box = new Box<int>();
			box.AddElement(1);
			box.AddElement(2);
			box.AddElement(3);
			Console.WriteLine(box.Remove());
			box.AddElement(4);
			box.AddElement(5);
			Console.WriteLine(box.Remove());

		}
	}
}
