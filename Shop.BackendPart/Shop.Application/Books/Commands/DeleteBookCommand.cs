using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Commands
{
    public class DeleteBookCommand:IRequest<Unit>
    {
        public Guid BookId { get; set; }
        public Guid Id { get; set; }
    }
}
