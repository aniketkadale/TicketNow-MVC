using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketNow.Data;

namespace TicketNow.Controllers
{
    public class CinemasController : Controller
    {
        public readonly AppDBContext _context;
        public CinemasController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
