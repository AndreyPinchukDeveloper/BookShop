using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Queries.GetBookDetails
{
    public class GetBookDetailsQuery:IRequest<BookDetailsViewModel>
    {
        public Guid BookId { get; set; }
        public Guid Id { get; set; }
    }
}
