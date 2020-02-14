using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Data
{
    public class EmployeeInformation
    {
        #region Properties

        public Guid EmployeeNumber { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(30, ErrorMessage = "Name should be less than 40 characters")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Department is Required")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        #endregion
    }
}