using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
