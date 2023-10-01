using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Books.Queries.GetBookDetails;
using Shop.Application.Common.Exceptions;
using Shop.Application.Interfaces;
using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Queries.GetBookList
{
    public class GetBookListQueryHandler : IRequestHandler<GetBookListQuery, BookListViewModel>
    {
        private readonly IBooksDbContext _context;
        private readonly IMapper _mapper;

        public GetBookListQueryHandler(IBooksDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookListViewModel> Handle(GetBookListQuery request, CancellationToken cancellationToken)
        {
            var bookQuery = await _context.Books.Where(book => book.BookId == request.BookId)
                .ProjectTo<BookLookupDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new BookListViewModel { Books = bookQuery };
        }
    }
}
