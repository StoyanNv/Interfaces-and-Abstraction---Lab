﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class Library : IEnumerable<Book> 
{
    private List<Book> books;
    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
        this.books.Sort();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        for (int i = 0; i < books.Count; i++)
        {
            yield return books[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}