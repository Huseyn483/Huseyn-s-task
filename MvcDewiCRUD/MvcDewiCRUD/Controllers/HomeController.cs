using Microsoft.AspNetCore.Mvc;
using MvcDewiCRUD.DAL;
using MvcDewiCRUD.Models;

namespace MvcDewiCRUD.Controllers
{
    public class HomeController : Controller
    {
        private DewiDbContext _context { get; }
        public HomeController(DewiDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Dewi> Huseyn = _context.dewis.ToList();
            return View(Huseyn);
        }
    }
}
