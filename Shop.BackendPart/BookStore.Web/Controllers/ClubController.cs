using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class ClubController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
