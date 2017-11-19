using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    // Anleitung zum erstellen einer ASP.NET Core Anwendung mit Visual Studio Code
    // https://docs.microsoft.com/de-de/aspnet/core/tutorials/first-mvc-app-xplat/adding-controller
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        // http://localhost:5000/HelloWorld/

        // public string Index()
        // {
        //     return "This is my default action...";
        // }
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        // http://localhost:5000/HelloWorld/Welcome/

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        // http://localhost:5000/HelloWorld/Welcome?name=Rick&numtimes=4
        public string Welcome2(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        public string Welcome3(string name, int ID = 1)
        {
            // http://localhost:5000/HelloWorld/Welcome/3?name=Rick
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}