
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
	public class Book : IComparable<Book>
	{
		public Book(string title, int year, params string[] authors)
		{
			this.Title = title;
			this.Year = year;
			this.Authors = authors;
		}

		public string Title { get; set; }

		public int Year { get; set; }

		public IReadOnlyList<string> Authors { get; set; }

		public int CompareTo(Book otherBook)
		{
			int yearDifference = this.Year.CompareTo(otherBook.Year);

			if (yearDifference == 0)
			{
				yearDifference = this.Title.CompareTo(otherBook.Title);
			}

			return yearDifference;
		}

		public override string ToString()
		{
			return $"{this.Title} - {this.Year}";
		}
	}
}
