using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Task2.Models;

namespace Task2.Controllers
{
    public class RegisterController : Controller
    {

        [HttpGet]
        public IActionResult Register()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Register(PersonRegister model)
        {
            if (model.Date.DayOfWeek == DayOfWeek.Saturday || model.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                ModelState.AddModelError(nameof(model.Date), "Выберите будний день");
            }
            if (model.Date < DateTime.Now)
            {
                ModelState.AddModelError(nameof(model.Date), "Не корректно выбрана дата");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home", new { data = "Registration compleated successfully" });
            }

            return View(model);
        }
    }
}
