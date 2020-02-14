using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement
{
	public class LogoutModel : PageModel
	{
		#region Publics
		public async Task<IActionResult> OnGetAsync(string returnUrl = null)
		{
			await this.HttpContext
			          .SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			return LocalRedirect(this.Url.Content("~/"));
		}
		#endregion
	}
}