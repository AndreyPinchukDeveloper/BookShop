using BookStore.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Books.Queries.GetBookList;

namespace BookStore.Web.Controllers
{
    public class BookController:BaseController
    {
        public async Task<ActionResult<BookListViewModel>> GetAll()
        {

        }
    }
}
