using Microsoft.AspNetCore.Mvc;

namespace poo1atv.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
