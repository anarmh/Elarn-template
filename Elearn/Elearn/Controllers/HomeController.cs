using Elearn.Data;
using Elearn.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Elearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {



            return View();
        }

      

      
    }
}