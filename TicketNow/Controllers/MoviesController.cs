using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketNow.Data;

namespace TicketNow.Controllers
{
    public class MoviesController : Controller
    {
        public readonly AppDBContext _context;
        public MoviesController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = _context.Movies.ToListAsync();
            return View();
        }
    }
}
