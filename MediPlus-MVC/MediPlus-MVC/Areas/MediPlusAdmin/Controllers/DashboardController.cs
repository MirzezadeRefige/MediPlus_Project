using MediPlus_DAL.Contexts;
using MediPlus_DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus_MVC.Areas.MediPlusAdmin.Controllers
{
	public class DashboardController : Controller
	{
		private readonly MediPlusDbContext _context;

		public DashboardController(MediPlusDbContext context)
		{
			_context = context;
		}

		[Area("Admin")]
		public IActionResult Index()
		{
			List<SliderItem> sliderItems = _context.SliderItems.ToList();
			return View(sliderItems);
		}
	}
}
