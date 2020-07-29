

using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
	public class Library : IEnumerable<Book>
	{
		private List<Book> books;

		public Library(params Book[] books)
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

	public class LibraryIterator : IEnumerator<Book>
	{
		private readonly List<Book> books;
		private int currentIndex;

		public LibraryIterator(IEnumerable<Book> books)
		{
			this.Reset();
			this.books = new List<Book>(books);
		}

		public Book Current => this.books[this.currentIndex];

		object IEnumerator.Current => this.Current;

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			bool canMove = false;

			if (this.currentIndex < this.books.Count)
			{
				canMove = true;
			}

			return canMove;
		}

		public void Reset()
		{
			this.currentIndex = -1;
		}
	}
}
