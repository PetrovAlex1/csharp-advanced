using System;

namespace GenericArrayCreator
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			var strings = ArrayCreator<string>.Create(5, "Pesho");
			var integers = ArrayCreator<int>.Create(10, 33);
		}
	}
}
