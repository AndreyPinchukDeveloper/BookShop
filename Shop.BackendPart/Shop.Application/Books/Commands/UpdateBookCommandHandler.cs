using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Interfaces;
using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Commands
{
    public class UpdateBookCommandHandler : IRequestHandler<CreateBookCommandHandler>
    {
        private readonly IBooksDbContext _context;

        public UpdateBookCommandHandler(IBooksDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateBookCommandHandler request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Unit> Handler(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var entity = await = _context.Books.FirstOrDefaultAsync(book => book.Id == request.Id, cancellationToken);
            if (entity == null || entity.BookId != request.BookId) 
            {
                throw new NotFoundException(nameof(Book), request.Id);
            }
            entity
        }
    }
}
