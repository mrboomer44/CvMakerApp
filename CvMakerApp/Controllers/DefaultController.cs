using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var deger = context.Titles.FirstOrDefault();
            return View(deger);
        }
        [HttpPost]
        public IActionResult Index(Entity.Entities.Title title)
        {
            var deger = context.Titles.FirstOrDefault();
            if (deger != null)
            {
                deger.Name = title.Name;
                deger.Surname = title.Surname;
                deger.Description = title.Description;
                deger.WebUrl = title.WebUrl;
                deger.Phone = title.Phone;
                deger.Email = title.Email;
                deger.ImageUrl = title.ImageUrl;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public IActionResult Description()
        {
            var deger = context.Descriptions.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddDescription()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDescription(Entity.Entities.Description description)
        {
            context.Add(description);
            context.SaveChanges();
            return RedirectToAction("Description");
        }
        public IActionResult DeleteDescription(int id)
        {
            var deger = context.Descriptions.Find(id);
            if (deger != null)
            {
                context.Descriptions.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Description");
        }
        [HttpGet]
        public IActionResult UpdateDescription(int id)
        {
            var deger = context.Descriptions.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateDescription(Entity.Entities.Description description)
        {
            var deger = context.Descriptions.Find(description.DescriptionId);
            if (deger != null)
            {
                deger.DescriptionText = description.DescriptionText;                
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Description", "Default");
        }
        [HttpGet]
        public IActionResult Experience()
        {
            var deger = context.Experiences.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Entity.Entities.Experience experience)
        {
            context.Add(experience);
            context.SaveChanges();
            return RedirectToAction("Experience");
        }
        public IActionResult DeleteExperience(int id)
        {
            var deger = context.Experiences.Find(id);
            if (deger != null)
            {
                context.Experiences.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Experience");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var deger = context.Experiences.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Entity.Entities.Experience experience)
        {
            var deger = context.Experiences.Find(experience.ExperienceId);
            if (deger != null)
            {
                deger.Company = experience.Company;
                deger.Position = experience.Position;
                deger.StartDate = experience.StartDate;
                deger.EndDate = experience.EndDate;
                deger.Description = experience.Description;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Experience", "Default");
        }
    }
}

