using Microsoft.AspNetCore.Mvc;
using TicketNow.Data;

namespace TicketNow.Controllers
{
    public class ActorsController : Controller
    {
        public readonly AppDBContext _context;
        public ActorsController(AppDBContext  context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
