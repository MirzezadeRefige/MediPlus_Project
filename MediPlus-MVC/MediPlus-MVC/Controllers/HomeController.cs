using Microsoft.AspNetCore.Mvc;

namespace MediPlus_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
