namespace WebApplication3.Controllers
{
	public class HomeController : Microsoft.AspNetCore.Mvc.Controller
	{
		public HomeController() : base()
		{
		}

		public Microsoft.AspNetCore.Mvc.IActionResult Index()
		{
			return View();
		}
	}
}
