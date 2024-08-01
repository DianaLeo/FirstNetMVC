using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace first_aspnetcore_mvc.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // GET: /HelloWorld/Welcome/
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        // return HtmlEncoder.Default.Encode($"Hello{name}, some is : {some}");
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}