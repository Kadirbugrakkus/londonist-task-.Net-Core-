using CrmApp.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace CrmApp.App.Controllers
{
    public class ContactController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Get: /Contact/Index
        public IActionResult Index()
        {
            ViewBag.Country = _context.Countries;
            return View();
        }
    }
}
