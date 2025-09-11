using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class StackPartial : ViewComponent
    {
        private readonly Context _context;

        public StackPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Stacks.OrderByDescending(x => x.StackId).ToList();
            return View(degerler);

        }
    }
}