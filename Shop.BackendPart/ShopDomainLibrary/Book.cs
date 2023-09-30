using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopDomainLibrary
{
    public class Book
    {
        public Guid BookId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }          
        public string Author { get; set; }

        public string Descriptions { get; set; }
        public DateTime NewSupply { get; set; }
        public DateTime SellDate { get; set; }
        /*public Book(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        internal static bool IsIsbn(string query)
        {
            query = query.Replace("-", "")
                         .Replace(" ", "")
                         .ToUpper();

            return  Regex.IsMatch(query, @"ISBN\\d{10}");
        }*/
    }
}
