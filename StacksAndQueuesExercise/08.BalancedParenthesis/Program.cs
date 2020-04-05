using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstPart = new Queue<char>(Console.ReadLine());
			var secondPart = new Stack<char>(firstPart);
			bool isBalanced = true;

			if (firstPart.Count % 2 != 0)
			{
				Console.WriteLine("NO");
				return;
			}

			for (int i = 0; i < firstPart.Count / 2; i++)
			{
				bool currentBalance = true;

				switch (firstPart.Peek())
				{
					case '{':
						if (secondPart.Peek() != '}')
						{
							currentBalance = false;
						}
						else
						{
							firstPart.Dequeue();
							secondPart.Pop();
						}
						break;
					case '(':
						if (secondPart.Peek() != ')')
						{
							currentBalance = false;
						}
						else
						{
							firstPart.Dequeue();
							secondPart.Pop();
						}
						break;
					case '[':
						if (secondPart.Peek() != ']')
						{
							currentBalance = false;
						}
						else
						{
							firstPart.Dequeue();
							secondPart.Pop();
						}
						break;
					default:
						break;
				}

				if (!currentBalance)
				{
					isBalanced = false;
					break;
				}
			}

			if (isBalanced)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}
