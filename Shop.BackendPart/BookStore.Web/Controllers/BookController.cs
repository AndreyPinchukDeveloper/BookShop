using BookStore.Web.Controllers.Base;
using BookStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Books.Commands;
using Shop.Application.Books.Queries.GetBookList;

namespace BookStore.Web.Controllers
{
    public class BookController:BaseController
    {
        [HttpGet]
        public async Task<ActionResult<BookListViewModel>> GetAll()
        {
            var query = new GetBookListQuery
            {
                BookId = BookId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateBookDTO createBookDTO)
        {
            var command = _mapper.Map<CreateBookCommand>(createBookDTO);
            command.BookId = BookId;
            var noteId = await Mediator.Send(command);
            return Ok(BookId);
        }
    }
}
