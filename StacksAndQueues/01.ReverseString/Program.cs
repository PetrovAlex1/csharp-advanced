using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseString
{
	class Program
	{
		static void Main(string[] args)
		{
			var chars = new Stack<char>();
			string input = Console.ReadLine();

			foreach (var letter in input)
			{
				chars.Push(letter);
			}

			while (chars.Count > 0)
			{
				Console.Write(chars.Pop());
			}
		}
	}
}
