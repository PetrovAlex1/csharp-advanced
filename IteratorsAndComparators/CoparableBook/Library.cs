
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
	class Library : IEnumerable<Book>
	{
		private SortedSet<Book> books;

		public Library(params Book[] books)
		{
			this.books = new SortedSet<Book>(books);
		}

		public IEnumerator<Book> GetEnumerator()
		{
			foreach (var book in books)
			{
				yield return book;
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
