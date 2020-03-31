using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed the Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Stanford",
                Email = "john@ims.com",
                Address = "75 Albin Road St",
                PhoneNumber = "0068 586376456",
                BarCode = "6776443",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Mary",
                LastName = "Crester",
                Email = "mary@ims.com",
                Address = "57 Crossroad St",
                PhoneNumber = "0068 123876456",
                BarCode = "6787443",
                DateOfBirth = new DateTime(1981, 11, 3),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/mary.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Nick",
                LastName = "Donovan",
                Email = "nick@ims.com",
                Address = "33 Jumper Fall St",
                PhoneNumber = "0068 586332466",
                BarCode = "4632879",
                DateOfBirth = new DateTime(1973, 5, 8),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/nick.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Saly",
                LastName = "Berdnar",
                Email = "saly@ims.com",
                Address = "21 Alberd Hall",
                PhoneNumber = "0068 223432486",
                BarCode = "6783432",
                DateOfBirth = new DateTime(1985, 2, 18),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/saly.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Steve",
                LastName = "Busemi",
                Email = "steve@ims.com",
                Address = "98 Horseford Alley",
                PhoneNumber = "0068 145333225",
                BarCode = "4323654",
                DateOfBirth = new DateTime(1972, 12, 18),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/steve.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 6,
                FirstName = "Brad",
                LastName = "Randall",
                Email = "brad@ims.com",
                Address = "32 California St",
                PhoneNumber = "0068 764353653",
                BarCode = "8976542",
                DateOfBirth = new DateTime(1984, 4, 4),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/brad.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 7,
                FirstName = "Roger",
                LastName = "Fredrig",
                Email = "roger@ims.com",
                Address = "58 Indianna St",
                PhoneNumber = "0068 445743241",
                BarCode = "2235432",
                DateOfBirth = new DateTime(1974, 3, 3),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/roger.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 8,
                FirstName = "Teressa",
                LastName = "May",
                Email = "teressa@ims.com",
                Address = "22 California St",
                PhoneNumber = "0068 656743233",
                BarCode = "3342224",
                DateOfBirth = new DateTime(1988, 7, 3),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/teressa.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 9,
                FirstName = "Sara",
                LastName = "Jennings",
                Email = "sara@ims.com",
                Address = "45 Linard St",
                PhoneNumber = "0068 764353653",
                BarCode = "3345221",
                DateOfBirth = new DateTime(1986, 11, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/sara.png",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 10,
                FirstName = "Jack",
                LastName = "Pallace",
                Email = "jack@ims.com",
                Address = "60 Zambata Corn St",
                PhoneNumber = "0068 764353653",
                BarCode = "9987556",
                DateOfBirth = new DateTime(1976, 5, 19),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/moImage.png",
            });
        }
    }
}
