using Microsoft.AspNetCore.Mvc;
using Opdracht9.Data;

namespace Opdracht9.Controllers
{
    public class RoosterVMController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RoosterVMController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string? klas = null)
        {
            if(klas == null)
            {
                klas = "I9AOA";
            }
            return View(_context.RoosterVMs.Where(r=>r.Klas == klas));
        }
    }
}
