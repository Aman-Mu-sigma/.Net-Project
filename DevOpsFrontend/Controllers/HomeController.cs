using Microsoft.AspNetCore.Mvc;

namespace DevOpsFrontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello DevOps from .NET in Codespaces!";
            return View();
        }
    }
}