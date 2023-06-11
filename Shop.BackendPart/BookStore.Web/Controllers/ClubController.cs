using BookStore.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class ClubController : Controller
    {
        private readonly AppDbContext _context;
        public ClubController(AppDbContext context)
        {
            _context = context;   
        }

        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }
    }
}
 