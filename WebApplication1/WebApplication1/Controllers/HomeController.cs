using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private DBContext context;
        private List<Student> Students;

        public HomeController(DBContext context)
        {
            this.context = context;
            this.Students = context.students.ToList();

        }
        public IActionResult Index()
        {
            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";

            if (isAjax)
            {
                return PartialView("_Table", Students);
            }

            return View(Students);
        }

        public IActionResult Contact()
        {
            var model = new Student { };
            return PartialView("_ContactModalPartial", model);
        }

        [HttpPost]
        public IActionResult Contact(Student model)
        {
            if (ModelState.IsValid)
            {
                context.students.Add(model);
                context.SaveChanges();
            }

            return Redirect("/Home/Index");
        }

        [HttpPost]
        public IActionResult PutContact(Student model)
        {
            Student student = context.students.Where(x => x.id == model.id).FirstOrDefault();

            if (student == null) 
                return Content("Ogrenci piyasada yok");

            student.tc_no = model.tc_no;
            student.name = model.name;
            student.surname = model.surname;
            student.email = model.email;

            context.SaveChanges();

            return Redirect("/Home/Index");
        }

        public IActionResult Delete(decimal sid)
        {
            Student student = context.students.Where(x => x.id == sid).FirstOrDefault();
            
            if (student != null)
            {
                context.Remove(context.students.Single(a => a.id == sid));
                context.SaveChanges();
            }
            return Redirect("/Home/Index");
        }


        public IActionResult Notifications()
        {
            TempData.TryGetValue("Notifications", out object value);
            var notifications = value as IEnumerable<string> ?? Enumerable.Empty<string>();
            return PartialView("_NotificationsPartial", notifications);
        }
    }
}