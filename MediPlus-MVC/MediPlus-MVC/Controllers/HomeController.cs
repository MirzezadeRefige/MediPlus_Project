using MediPlus_DAL.Contexts;
using MediPlus_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediPlus_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly MediPlusDbContext _context;

		public HomeController(MediPlusDbContext context)
		{
			_context=context;
		}

		public IActionResult Index()
        {
			List<SliderItem> data = _context.SliderItems.ToList();

			return View(data);
        }
    }
}
