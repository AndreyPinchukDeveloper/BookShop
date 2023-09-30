using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Commands
{
    public class UpdateBookCommand:IRequest
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public DateTime SellDate { get; set; }
    }
}
