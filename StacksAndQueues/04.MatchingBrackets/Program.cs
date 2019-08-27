using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var scopeIndexes = new Stack<int>();

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '(')
				{
					scopeIndexes.Push(i);
				}
				else if (input[i] == ')')
				{
					int startIndex = scopeIndexes.Pop();
					Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
				}
			}
		}
	}
}
