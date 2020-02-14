using System;
using System.Threading.Tasks;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace EmployeeManagement
{
	public class DeleteEmployeeBase : ComponentBase
	{
		#region Fields
		protected EmployeeInformation employee = new EmployeeInformation();
		#endregion

		#region Properties
		[Parameter]
		public Guid EmployeeNumber { get; set; }

		[Inject]
		protected NavigationManager NavigationManager { get; set; }

		[Inject]
		public EmployeeDetails EmployeeDetails { get; set; }

		[Inject]
		protected IJSRuntime IJSRuntime { get; set; }

		private Guid qEmployeeNumber { get; set; }
		#endregion

		#region Protecteds
		protected override void OnInitialized()
		{
			employee = EmployeeCRUD.FetchSingleEmployee(this.EmployeeNumber);
		}

		protected override void OnParametersSet()
		{
			this.qEmployeeNumber = this.EmployeeNumber;
		}

		protected async Task Delete()
		{
			await this.IJSRuntime.InvokeVoidAsync("DeleteConfirmation", this.qEmployeeNumber);

			this.EmployeeDetails.ListEmployee = null;
			this.NavigationManager.NavigateTo("listemployees");
		}

		protected void Cancel()
		{
			this.NavigationManager.NavigateTo("listemployees");
		}
		#endregion
	}
}