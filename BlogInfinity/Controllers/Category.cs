using Microsoft.AspNetCore.Mvc;

namespace BlogInfinity.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
