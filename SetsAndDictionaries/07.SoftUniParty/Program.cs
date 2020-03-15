using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
	class Program
	{
		static void Main(string[] args)
		{
			var guestsList = new HashSet<string>();
			var vips = new HashSet<string>();
			var normalGuests = new HashSet<string>();
			bool isParty = false;

			while (true)
			{
				var currentGuest = Console.ReadLine();

				if (currentGuest.ToLower() == "end")
				{
					break;
				}
				else if (currentGuest.ToLower() == "party")
				{
					isParty = true;
					continue;
				}
				else if (isParty)
				{
					if (guestsList.Contains(currentGuest))
					{
						AddExactlyGuest(vips, normalGuests, currentGuest);
					}

					guestsList.Remove(currentGuest);
				}
				else
				{
					guestsList.Add(currentGuest);
				}
			}

			RrintResult(guestsList);
		}

		private static void RrintResult(HashSet<string> guestsList)
		{
			if (guestsList.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(guestsList.Count);

				foreach (var guest in guestsList)
				{
					var firstLetter = guest.Substring(0, 1);

					if (firstLetter.All(char.IsDigit))
					{
						Console.WriteLine(guest);
					}
				}
				foreach (var guest in guestsList)
				{
					var firstLetter = guest.Substring(0, 1);

					if (!firstLetter.All(char.IsDigit))
					{
						Console.WriteLine(guest);
					}
				}
			}
		}

		private static void AddExactlyGuest(HashSet<string> vips, HashSet<string> normalGuests, string currentGuest)
		{
			var firstLetter = currentGuest.Substring(0, 1);

			if (firstLetter.All(char.IsDigit))
			{
				vips.Add(currentGuest);
			}
			else
			{
				normalGuests.Add(currentGuest);
			}
		}
	}
}
