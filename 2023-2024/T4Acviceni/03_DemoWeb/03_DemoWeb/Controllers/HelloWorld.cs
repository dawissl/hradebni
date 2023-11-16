using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace _03_DemoWeb.Controllers
{
    public class HelloWorld : Controller
    {
     
        // 
        // GET: /HelloWorld/
        public string Index()
        {
            return "Výchozí stránka";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
     
        public string Welcome(string name, int age = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, with age {age} years");
        }
    }
}
