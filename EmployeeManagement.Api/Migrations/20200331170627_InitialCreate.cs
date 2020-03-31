using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    BarCode = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "BarCode", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoPath" },
                values: new object[,]
                {
                    { 1, "75 Albin Road St", "6776443", new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "john@ims.com", "John", 0, "Stanford", "0068 586376456", "images/john.png" },
                    { 2, "57 Crossroad St", "6787443", new DateTime(1981, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "mary@ims.com", "Mary", 1, "Crester", "0068 123876456", "images/mary.png" },
                    { 3, "33 Jumper Fall St", "4632879", new DateTime(1973, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "nick@ims.com", "Nick", 0, "Donovan", "0068 586332466", "images/nick.png" },
                    { 4, "21 Alberd Hall", "6783432", new DateTime(1985, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "saly@ims.com", "Saly", 1, "Berdnar", "0068 223432486", "images/saly.png" },
                    { 5, "98 Horseford Alley", "4323654", new DateTime(1972, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "steve@ims.com", "Steve", 0, "Busemi", "0068 145333225", "images/steve.png" },
                    { 6, "32 California St", "8976542", new DateTime(1984, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "brad@ims.com", "Brad", 0, "Randall", "0068 764353653", "images/brad.png" },
                    { 7, "58 Indianna St", "2235432", new DateTime(1974, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "roger@ims.com", "Roger", 0, "Fredrig", "0068 445743241", "images/roger.png" },
                    { 8, "22 California St", "3342224", new DateTime(1988, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "teressa@ims.com", "Teressa", 1, "May", "0068 656743233", "images/teressa.png" },
                    { 9, "45 Linard St", "3345221", new DateTime(1986, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sara@ims.com", "Sara", 1, "Jennings", "0068 764353653", "images/sara.png" },
                    { 10, "60 Zambata Corn St", "9987556", new DateTime(1976, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "jack@ims.com", "Jack", 0, "Pallace", "0068 764353653", "images/moImage.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
