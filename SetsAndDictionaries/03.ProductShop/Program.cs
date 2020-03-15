using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
	class Program
	{
		static void Main(string[] args)
		{
			var shopInfo = new SortedDictionary<string, Dictionary<string, double>>();
			var input = Console.ReadLine().Split(", ").ToArray();

			while (input[0] != "Revision")
			{
				var shopName = input[0];
				var product = input[1];
				double price = double.Parse(input[2]);

				if (!shopInfo.ContainsKey(shopName))
				{
					shopInfo[shopName] = new Dictionary<string, double>();
				}

				shopInfo[shopName].Add(product, price);
				input = Console.ReadLine().Split(", ").ToArray();
			}

			foreach (var kvp in shopInfo)
			{
				var shopName = kvp.Key;

				Console.WriteLine(shopName + "->");

				foreach (var products in kvp.Value)
				{
					var currentProduct = products.Key;
					var currentPrice = products.Value;

					Console.WriteLine($"Product: {currentProduct}, Price: {currentPrice}");
				}
			}
		}
	}
}
