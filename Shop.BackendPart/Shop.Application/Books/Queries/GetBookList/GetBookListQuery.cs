using MediatR;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Queries.GetBookList
{
    public class GetBookListQuery:IRequest<BookListViewModel>
    {
        public Guid BookId { get; set; }
    }
}
