using Microsoft.AspNetCore.Mvc;

namespace _03_HelloWorld.Controllers
{
    public class Greetings : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hello(string name, int age)
        {
            ViewData["Name"] = name;
            ViewData["Age"] = age;            
            return View();
        }
    }
}
