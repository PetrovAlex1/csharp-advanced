﻿using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
	class Library : IEnumerable<Book>
	{
		private SortedSet<Book> books;

		public Library(params Book[] books)
		{
			this.books = new SortedSet<Book>(new BookComparator());
		}

		public void Add(Book book)
		{
			books.Add(book);
		}

		public IEnumerator<Book> GetEnumerator()
		{
			foreach (var book in this.books)
			{
				yield return book;
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}

}
