using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person { Id = 1, Name = "John", Age = 30 };
            return View(person);
        }
    }
}