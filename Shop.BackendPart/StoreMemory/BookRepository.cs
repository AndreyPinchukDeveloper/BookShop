﻿using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] _books = new[]
        {
            new Book(1, "Art of something!"),
            new Book(2, "Refactoring"),
            new Book(3, "Something great"),
        };

        public Book[] GetAllByTitle(string title)
        {
             return _books.Where(book=>book.Title.Contains(title))
                          .ToArray();
        }
    }
}
