using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Common.Exceptions;
using Shop.Application.Interfaces;
using ShopDomainLibrary;

namespace Shop.Application.Books.Queries.GetBookDetails
{
    public class GetBookDetailsQueryHandler:IRequestHandler<GetBookDetailsQuery, BookDetailsViewModel>
    {
        private readonly IBooksDbContext _context;
        private readonly IMapper _mapper;
        public GetBookDetailsQueryHandler(IBooksDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookDetailsViewModel> Handle(GetBookDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Books.FirstOrDefaultAsync(book => book.Id == request.Id, cancellationToken);
            if (entity == null || entity.BookId != request.BookId)
            {
                throw new NotFoundException(nameof(Book), request.Id);
            }

            return _mapper.Map<BookDetailsViewModel>(entity);
        }
    }
}
