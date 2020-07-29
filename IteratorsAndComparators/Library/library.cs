using IteratorsAndComparators;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
	public class library : IEnumerable<Book>
	{
		private List<Book> books;

		public library(params Book[] books)
		{
			this.books = new List<Book>(books);
		}

		public IEnumerator<Book> GetEnumerator()
		{
			for (int i = 0; i < books.Count; i++)
			{
				yield return books[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}
}
