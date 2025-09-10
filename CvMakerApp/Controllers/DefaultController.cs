using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context context;

        public DefaultController(Context context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
