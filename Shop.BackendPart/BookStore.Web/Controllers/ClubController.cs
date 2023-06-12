﻿using BookStore.Web.Data;
using BookStore.Web.Models;
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
            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }
    }
}
 