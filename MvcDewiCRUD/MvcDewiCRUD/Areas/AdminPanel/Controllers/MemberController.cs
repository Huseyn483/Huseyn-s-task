using Microsoft.AspNetCore.Mvc;
using MvcDewiCRUD.Areas.AdminPanel.ViewModel;
using MvcDewiCRUD.DAL;
using MvcDewiCRUD.Models;

namespace MvcDewiCRUD.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class MemberController : Controller
    {
        private DewiDbContext _context { get; }
        public MemberController(DewiDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.dewis);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(CreateVM createVM)
        {
            if (!ModelState.IsValid)
            {
                return View(createVM);
            }
            Dewi newMember = new Dewi
            {
                PhotoUrl = createVM.PhotoUrl,
                Name=createVM.Name,
                Description=createVM.Description
            };
            await _context.dewis.AddAsync(newMember);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");


            
        }
    }
}
