using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class CvController : Controller
    {
        private readonly Context _context;
        public CvController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult StylePartial()
        {
            return PartialView();
        }

    }
}