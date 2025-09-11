using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class ExperiensPartial : ViewComponent
    {
        private readonly Context _context;

        public ExperiensPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Experiences.OrderByDescending(x => x.ExperienceId).ToList();
            return View(degerler);

        }
    }
}