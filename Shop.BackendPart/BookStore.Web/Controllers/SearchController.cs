 using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
