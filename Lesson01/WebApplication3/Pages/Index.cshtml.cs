using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
		//public void OnGet()
		//{
		//}

		public IActionResult OnGet()
		{
			return Page();
		}
	}
}
