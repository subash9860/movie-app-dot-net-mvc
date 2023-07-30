using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int? age)
    {
        // string? ageVar = age.HasValue ? age.ToString() : "0";
        // return Content("ageVar");
        //  HtmlEncoder.Default.Encode($"hi {name},  You are: {ageVar}");

        ViewData["Message"] = "Namaste " + name;
        ViewData["age"] = age;
        return View();

    }
}

