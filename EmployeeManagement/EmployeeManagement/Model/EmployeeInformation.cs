using System;

namespace BlazorAppCRUD
{
	public class EmployeeInformation
	{
		#region Properties
		public string EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public string Department { get; set; }
		public int Salary { get; set; }
		public DateTime DOB { get; set; }
		public string City { get; set; }
		#endregion
	}
}