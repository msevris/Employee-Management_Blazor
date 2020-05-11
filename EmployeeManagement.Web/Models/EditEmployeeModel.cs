using EmployeeManagement.Models;
using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter FirstName")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter LastName")]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "ims.com")]
        public string Email { get; set; }
        [CompareProperty("Email",ErrorMessage ="Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string BarCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
