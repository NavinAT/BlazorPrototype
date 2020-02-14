using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement
{
    public class StudentDetails
    {
        [Required(ErrorMessage = "Student Name is required")]
        [StringLength(30, ErrorMessage = "Name should be less than 30 characters")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Department code is required")]
        [StringLength(8, ErrorMessage = "Department code should be less than 8 characters")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        public bool IsEligibleForScholarship { get; set; }
    }
}