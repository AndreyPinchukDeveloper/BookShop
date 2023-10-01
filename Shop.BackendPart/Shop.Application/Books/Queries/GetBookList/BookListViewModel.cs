using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Queries.GetBookList
{
    public class BookListViewModel
    {
        public IList<BookLookupDTO> Books { get; set; }
    }
}
