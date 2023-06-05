using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainLibrary
{
    public class Book
    {
        public int Id { get;}

        public string Isbn { get; }
        public string Author { get; }

        public string Title { get;}

        public Book(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        internal static bool IsIsbn(string query)
        {
            return false;
        }
    }
}
