using System.Collections.Generic;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace EmployeeManagement
{
	public class CreateEmployeeBase : ComponentBase
	{
		#region Fields


		#region Fields
		protected List<string> DropDownValues;
		#endregion

		#region Properties
		protected EmployeeInformation Employee { get; set; } = new EmployeeInformation();

		[Inject]
		public EmployeeManagement.EmployeeDetails EmployeeDetails { get; set; }

		[Inject]
		protected NavigationManager NavigationManager { get; set; }

		//[Inject]
		//private IJSRuntime JSRuntime { get; set; }
		#endregion

		#region Protecteds
		protected override void OnInitialized()
		{
			const string strTableName = nameof(this.Employee.City);

			DropDownValues = EmployeeCRUD.FetchDropDownList(strTableName);
		}

		#endregion

		#region Privates
		//private async Task LoadStateAsync()
		//{
		//	Employee = await ProtectedLocalStorage.GetAsync<EmployeeInformation>("EmployeeData");
		//}

		protected void CreateNewEmployee()
		{
			EmployeeCRUD.CreateEmployee(this.Employee);

			//ProtectedLocalStorage.SetAsync("EmployeeData", Employee);
			EmployeeDetails.ListEmployee = null;
			this.NavigationManager.NavigateTo("listemployees");
		}

		protected void Cancel()
		{
			this.NavigationManager.NavigateTo("listemployees");
		}
		#endregion
	}
}
#endregion