﻿ using Microsoft.AspNetCore.Mvc;
using ShopDomainLibrary;

namespace BookStore.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public SearchController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index(string query)
        {
            var books = _bookRepository.GetAllByTitle(query);

            return View(books);
        }
    }
}
