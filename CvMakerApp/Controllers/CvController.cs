using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
