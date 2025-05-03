using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketNow.Data;

namespace TicketNow.Controllers
{
    public class ProducersController : Controller
    {
        public readonly AppDBContext _context;
        public ProducersController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = _context.Producers.ToListAsync();
            return View();
        }
    }
}
