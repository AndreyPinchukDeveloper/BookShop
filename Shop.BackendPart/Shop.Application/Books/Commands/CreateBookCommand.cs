using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Commands
{
    public class CreateBookCommand:IRequest<Guid>
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
    }
}
