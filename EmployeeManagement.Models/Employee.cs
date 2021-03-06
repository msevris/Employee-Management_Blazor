﻿using EmployeeManagement.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;



namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Please enter FirstName")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter LastName")]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain ="ims.com")]
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string BarCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

        
        public Department Department { get; set; }
    }
}
