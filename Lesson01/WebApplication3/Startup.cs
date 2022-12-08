using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			// Old Solution in ASP.NET (MVC, WEB API) Core 2.2
			//services.AddMvc();

			// The following example adds support for controllers and
			// API - related features, but not views or pages. The API template uses this code
			//services.AddControllers();

			// The following example adds support for controllers,
			// API - related features, and views, but not pages.The Web Application(MVC) template uses this code
			//services.AddControllersWithViews();

			// The following example adds support for Razor Pages and
			// minimal controller support.The Web Application template uses this code
			services.AddRazorPages();

			// The new methods can also be combined.
			// The following example is equivalent to calling AddMvc in ASP.NET Core 2.2
			//services.AddControllersWithViews();
			//services.AddRazorPages();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapGet("/", async context =>
			//	{
			//		await context.Response.WriteAsync("Hello World!");
			//	});
			//});

			// Old Solution in ASP.NET (MVC, WEB API) Core 2.2
			//app.UseMvc();

			app.UseEndpoints(endpoints =>
			{
				//endpoints.MapControllers();

				//endpoints.MapControllerRoute(
				//	name: "default",
				//	pattern: "{controller=Home}/{action=Index}/{id?}");

				endpoints.MapRazorPages();
			});
		}
	}
}
