using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
	class Program
	{
		static void Main(string[] args)
		{
			var listyIterator = new ListyIterator<string>();
			var command = Console.ReadLine().Split().ToArray();

			while (command[0] != "END")
			{
				switch (command[0])
				{
					case "Create":
						if (command.Length == 0)
						{
							var list = new List<string>();
							listyIterator = new ListyIterator<string>(list.ToArray());
						}
						else
						{
							var list = new List<string>();
							list.AddRange(command.ToList<string>());
							list = list.Where(x => x != "Create").ToList();
							listyIterator = new ListyIterator<string>(list.ToArray());
						}
						break;
					case "Move":
						Console.WriteLine(listyIterator.Move());
						break;
					case "Print":
						listyIterator.Print();
						break;
					case "HasNext":
						Console.WriteLine(listyIterator.HasNext());
						break;
					case "PrintAll":
						listyIterator.PrintAll();
						break;
					default:
						break;
				}

				command = Console.ReadLine().Split().ToArray();
			}
		}
	}
}

