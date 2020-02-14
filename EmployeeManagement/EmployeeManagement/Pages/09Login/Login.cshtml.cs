using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement
{
	public class LoginModel : PageModel
	{
		#region Properties
		[Required]
		[BindProperty]
		[EmailAddress]
		public string Email { get; set; }

		[Inject]
		public EmployeeCRUD EmployeeCrud { get; set; }

		[Required]
		[BindProperty]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		#endregion

		#region Publics
		public async Task<IActionResult> OnPostAsync()
		{
			if(string.IsNullOrEmpty(this.Email) || string.IsNullOrEmpty(this.Password))
			{
				this.TempData["LoginError"] = "Please give valid detail.";
				return Page();
			}

			if(!(this.Email.ToLower().Equals("hans.imboden@m-s.in") && this.Password.Equals("123456")))
			{
				this.TempData["LoginError"] = "The given credential is not valid.";
				return Page();
			}

			List<Claim> claims = new List<Claim>
			                     {
				                     new Claim(ClaimTypes.Name, "Hans"),
				                     new Claim(ClaimTypes.Email, this.Email)
			                     };

			ClaimsIdentity claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			await this.HttpContext.SignInAsync(
			                                   CookieAuthenticationDefaults.AuthenticationScheme,
			                                   new ClaimsPrincipal(claimIdentity));

			return LocalRedirect(this.Url.Content("~/"));
		}
		#endregion
	}
}