namespace Server.Pages.Learn018
{
	public class Page1Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Page1Model() : base()
		{
		}

		public void OnGet()
		{
			ViewData["MyData"] = "I'm Hamed Banaei";
			//ViewBag.MyData = "I'm Hamed Banaei"; // Just In MVC or MVC Core
		}
	}
}
