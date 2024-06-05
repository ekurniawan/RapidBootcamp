using Microsoft.AspNetCore.Mvc;

namespace RapidBootcamp.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello ASP.NET Core MVC!");
        }
    }
}
