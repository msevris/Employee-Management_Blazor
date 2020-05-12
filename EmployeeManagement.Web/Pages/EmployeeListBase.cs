using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject] public IEmployeeService EmployeeService { get; set; }
        public bool ShowFooter { get; set; } = true;
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            // await Task.Run(LoadEmployees);
           Employees = (await EmployeeService.GetEmployees()).ToList();
        }
        protected int SelectedEmployeesCount { get; set; } = 0;
        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
        }













        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(3000);
        //    Employee e1 = new Employee()
        //    {
        //        EmployeeId = 1,
        //        FirstName = "John",
        //        LastName = "Stanford",
        //        Email = "john@ims.com",
        //        Address = "75 Albin Road St",
        //        PhoneNumber = "0068 586376456",
        //        BarCode = "6776443",
        //        DateOfBirth = new DateTime(1980, 10, 5),
        //        Gender = Gender.Male,
        //        DepartmentId =1,
        //        PhotoPath = "images/john.png",
        //    };
        //    Employee e2 = new Employee()
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Mary",
        //        LastName = "Crester",
        //        Email = "mary@ims.com",
        //        Address = "57 Crossroad St",
        //        PhoneNumber = "0068 123876456",
        //        BarCode = "6787443",
        //        DateOfBirth = new DateTime(1981, 11, 3),
        //        Gender = Gender.Female,
        //        DepartmentId =2,
        //        PhotoPath = "images/mary.png",
        //    };
        //    Employee e3 = new Employee()
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Nick",
        //        LastName = "Donovan",
        //        Email = "nick@ims.com",
        //        Address = "33 Jumper Fall St",
        //        PhoneNumber = "0068 586332466",
        //        BarCode = "4632879",
        //        DateOfBirth = new DateTime(1973, 5, 8),
        //        Gender = Gender.Male,
        //        DepartmentId =3,
        //        PhotoPath = "images/nick.png",
        //    };
        //    Employee e4 = new Employee()
        //    {
        //        EmployeeId = 4,
        //        FirstName = "Saly",
        //        LastName = "Berdnar",
        //        Email = "saly@ims.com",
        //        Address = "21 Alberd Hall",
        //        PhoneNumber = "0068 223432486",
        //        BarCode = "6783432",
        //        DateOfBirth = new DateTime(1985, 2, 18),
        //        Gender = Gender.Female,
        //        DepartmentId =3,
        //        PhotoPath = "images/saly.png",
        //    };
        //    Employee e5 = new Employee()
        //    {
        //        EmployeeId = 5,
        //        FirstName = "Steve",
        //        LastName = "Busemi",
        //        Email = "steve@ims.com",
        //        Address = "98 Horseford Alley",
        //        PhoneNumber = "0068 145333225",
        //        BarCode = "4323654",
        //        DateOfBirth = new DateTime(1972, 12, 18),
        //        Gender = Gender.Male,
        //        DepartmentId =1,
        //        PhotoPath = "images/steve.png",
        //    };
        //    Employee e6 = new Employee()
        //    {
        //        EmployeeId = 6,
        //        FirstName = "Brad",
        //        LastName = "Randall",
        //        Email = "brad@ims.com",
        //        Address = "32 California St",
        //        PhoneNumber = "0068 764353653",
        //        BarCode = "8976542",
        //        DateOfBirth = new DateTime(1984, 4, 4),
        //        Gender = Gender.Male,
        //        DepartmentId =2,
        //        PhotoPath = "images/brad.png",
        //    };
        //    Employee e7 = new Employee()
        //    {
        //        EmployeeId = 7,
        //        FirstName = "Roger",
        //        LastName = "Fredrig",
        //        Email = "roger@ims.com",
        //        Address = "58 Indianna St",
        //        PhoneNumber = "0068 445743241",
        //        BarCode = "2235432",
        //        DateOfBirth = new DateTime(1974, 3, 3),
        //        Gender = Gender.Male,
        //        DepartmentId =1,
        //        PhotoPath = "images/roger.png",
        //    };
        //    Employee e8 = new Employee()
        //    {
        //        EmployeeId = 8,
        //        FirstName = "Teressa",
        //        LastName = "May",
        //        Email = "teressa@ims.com",
        //        Address = "22 California St",
        //        PhoneNumber = "0068 656743233",
        //        BarCode = "3342224",
        //        DateOfBirth = new DateTime(1988, 7, 3),
        //        Gender = Gender.Female,
        //        DepartmentId =2,
        //        PhotoPath = "images/teressa.png",
        //    };
        //    Employee e9 = new Employee()
        //    {
        //        EmployeeId = 9,
        //        FirstName = "Sara",
        //        LastName = "Jennings",
        //        Email = "sara@ims.com",
        //        Address = "45 Linard St",
        //        PhoneNumber = "0068 764353653",
        //        BarCode = "3345221",
        //        DateOfBirth = new DateTime(1986, 11, 23),
        //        Gender = Gender.Female,
        //        DepartmentId =3,
        //        PhotoPath = "images/sara.png",
        //    };
        //    Employee e10 = new Employee()
        //    {
        //        EmployeeId = 10,
        //        FirstName = "Jack",
        //        LastName = "Pallace",
        //        Email = "jack@ims.com",
        //        Address = "60 Zambata Corn St",
        //        PhoneNumber = "0068 764353653",
        //        BarCode = "9987556",
        //        DateOfBirth = new DateTime(1976, 5, 19),
        //        Gender = Gender.Male,
        //        DepartmentId =1,
        //        PhotoPath = "images/moImage.png",
        //    };

        //    Employees = new List<Employee> { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };
        //}
    }
}
