using MediatR;
using Shop.Application.Interfaces;
using ShopDomainLibrary;
using System.Threading.Tasks;
using System.Threading;

namespace Shop.Application.Books.Commands
{
    public class CreateBookCommandHandler: IRequestHandler<CreateBookCommand, Guid>
    {
        private readonly IBooksDbContext _context;

        public CreateBookCommandHandler(IBooksDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                BookId = request.BookId,
                Descriptions = request.Descriptions,
                NewSupply = DateTime.Now,
            };

            await _context.Books.AddAsync(book, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);//save data in database
            return book.Id;
        }
    }
}
