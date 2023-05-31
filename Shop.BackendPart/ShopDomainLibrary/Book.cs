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

        public string Title { get;}

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }  
    }
}
