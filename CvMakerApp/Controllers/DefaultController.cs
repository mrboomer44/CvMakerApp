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
        [HttpGet]
        public IActionResult Education()
        {
            var deger = context.Educations.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Entity.Entities.Education education)
        {
            context.Add(education);
            context.SaveChanges();
            return RedirectToAction("Education");
        }
        public IActionResult DeleteEducation(int id)
        {
            var deger = context.Educations.Find(id);
            if (deger != null)
            {
                context.Educations.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Education");
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var deger = context.Educations.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Entity.Entities.Education education)
        {
            var deger = context.Educations.Find(education.EducationId);
            if (deger != null)
            {
                deger.SchoolName = education.SchoolName;
                deger.Department = education.Department;
                deger.EducationalType = education.EducationalType;
                deger.StartDate = education.StartDate;
                deger.EndDate = education.EndDate;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Education", "Default");
        }
        [HttpGet]
        public IActionResult Memberships()
        {
            var deger = context.Memberships.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddMembership()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMembership(Entity.Entities.Membership membership)
        {
            context.Add(membership);
            context.SaveChanges();
            return RedirectToAction("Memberships");
        }
        public IActionResult DeleteMembership(int id)
        {
            var deger = context.Memberships.Find(id);
            if (deger != null)
            {
                context.Memberships.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Memberships");
        }
        [HttpGet]
        public IActionResult UpdateMembership(int id)
        {
            var deger = context.Memberships.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateMembership(Entity.Entities.Membership membership)
        {
            var deger = context.Memberships.Find(membership.MembershipId);
            if (deger != null)
            {
                deger.Organisation = membership.Organisation;
                deger.Position = membership.Position;
                deger.StartDate = membership.StartDate;
                deger.EndDate = membership.EndDate;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Memberships");
        }

        [HttpGet]
        public IActionResult Language()
        {
            var deger = context.Languages.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddLanguage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddLanguage(Entity.Entities.Language language)
        {
            context.Add(language);
            context.SaveChanges();
            return RedirectToAction("Language");
        }
        public IActionResult DeleteLanguage(int id)
        {
            var deger = context.Languages.Find(id);
            if (deger != null)
            {
                context.Languages.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Language");
        }
        [HttpGet]
        public IActionResult UpdateLanguage(int id)
        {
            var deger = context.Languages.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateLanguage(Entity.Entities.Language language)
        {
            var deger = context.Languages.Find(language.LanguageId);
            if (deger != null)
            {
                deger.LanguageName = language.LanguageName;
                deger.LanguageLevel = language.LanguageLevel;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Language");
        }
        [HttpGet]
        public IActionResult Stack()
        {
            var deger = context.Stacks.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddStack()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStack(Entity.Entities.Stack stack)
        {
            context.Add(stack);
            context.SaveChanges();
            return RedirectToAction("Stack");
        }
        public IActionResult DeleteStack(int id)
        {
            var deger = context.Stacks.Find(id);
            if (deger != null)
            {
                context.Stacks.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Stack");
        }
        [HttpGet]
        public IActionResult UpdateStack(int id)
        {
            var deger = context.Stacks.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateStack(Entity.Entities.Stack stack)
        {
            var deger = context.Stacks.Find(stack.StackId);
            if (deger != null)
            {
                deger.Description = stack.Description;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Stack");
        }
        [HttpGet]
        public IActionResult Voluntary()
        {
            var deger = context.Voluntaries.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddVoluntary()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVoluntary(Entity.Entities.Voluntary voluntary)
        {
            context.Add(voluntary);
            context.SaveChanges();
            return RedirectToAction("Voluntary");
        }
        public IActionResult DeleteVoluntary(int id)
        {
            var deger = context.Voluntaries.Find(id);
            if (deger != null)
            {
                context.Voluntaries.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Voluntary");
        }
        [HttpGet]
        public IActionResult UpdateVoluntary(int id)
        {
            var deger = context.Voluntaries.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateVoluntary(Entity.Entities.Voluntary voluntary  )
        {
            var deger = context.Voluntaries.Find(voluntary.VoluntaryId);
            if (deger != null)
            {
                deger.CompanyName = voluntary.CompanyName;
                deger.Position = voluntary.Position;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Voluntary");
        }
        [HttpGet]
        public IActionResult Testimonial()
        {
            var deger = context.Testimonials.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Entity.Entities.Testimonial testimonial)
        {
            context.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("Testimonial");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var deger = context.Testimonials.Find(id);
            if (deger != null)
            {
                context.Testimonials.Remove(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Testimonial");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var deger = context.Testimonials.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Entity.Entities.Testimonial testimonial)
        {
            var deger = context.Testimonials.Find(testimonial.TestimonialId);
            if (deger != null)
            {
                deger.TestimonialName = testimonial.TestimonialName;
                deger.position = testimonial.position;
                deger.Company = testimonial.Company;
                context.Update(deger);
                context.SaveChanges();
            }
            return RedirectToAction("Testimonial");
        }
    }
}

