using EmployeeManagement;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorAppCRUD
{
	public class Startup
	{
		#region Properties
		public IConfiguration Configuration { get; }
		#endregion

		#region Constructors
		public Startup(IConfiguration configuration)
		{
			this.Configuration = configuration;
		}
		#endregion

		#region Publics
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddProtectedBrowserStorage();
			services.AddSingleton<EmployeeDetails>();

            // Get authentication info
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // Cookie authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

			//Dependency Injection
			services.AddSingleton<ISingletonService, SingletonService>();
            services.AddScoped<IScopedService, ScopedService>();
            services.AddTransient<ITransientService, TransientService>();
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if(env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			                 {
				                 endpoints.MapBlazorHub();
				                 endpoints.MapFallbackToPage("/_Host");
			                 });
		}
		#endregion
	}
}