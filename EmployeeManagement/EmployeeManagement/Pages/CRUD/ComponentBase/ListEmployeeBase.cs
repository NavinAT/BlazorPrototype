using EmployeeManagement.Data;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement
{
	public class ListEmployeeBase : ComponentBase
	{
		#region Properties
		[Inject]
		public EmployeeDetails EmployeeDetails { get; set; }
		#endregion

		#region Protecteds
		protected override void OnInitialized()
		{
			if(this.EmployeeDetails.ListEmployee == null || this.EmployeeDetails.ListEmployee.Count == 0)
				this.EmployeeDetails.ListEmployee = EmployeeCRUD.FetchEmployees();
		}
		#endregion
	}
}