using MediatR;
using Shop.Application.Common.Exceptions;
using Shop.Application.Interfaces;
using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Commands
{
    public class DeleteBookCommandHandler:IRequestHandler<DeleteBookCommand, Unit>
    {
        //Unit - type that defines empty enswer
        private readonly IBooksDbContext _context;

        public DeleteBookCommandHandler(IBooksDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Books.FindAsync(new object[] {request.Id}, cancellationToken);
            if (entity == null || entity.BookId != request.BookId)
            {
                throw new NotFoundException(nameof(Book), request.Id);
            }

            _context.Books.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
}
