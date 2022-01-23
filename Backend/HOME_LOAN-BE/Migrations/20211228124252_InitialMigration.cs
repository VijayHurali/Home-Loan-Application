using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HOME_LOAN_BE.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin_Details",
                columns: table => new
                {
                    AdminUsername = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_Details", x => x.AdminUsername);
                });

            migrationBuilder.CreateTable(
                name: "customer_Details",
                columns: table => new
                {
                    Customer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(nullable: true),
                    Middle_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Email_id = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Confirm_Password = table.Column<string>(nullable: true),
                    Phone_No = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Aadhar_No = table.Column<string>(nullable: true),
                    Pan_No = table.Column<string>(nullable: true),
                    Squestion = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_Details", x => x.Customer_id);
                });

            migrationBuilder.CreateTable(
                name: "employee_Details",
                columns: table => new
                {
                    Emp_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_of_Employment = table.Column<string>(nullable: true),
                    Retirement_Age = table.Column<int>(nullable: false),
                    Organisation_Type = table.Column<string>(nullable: true),
                    Employee_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_Details", x => x.Emp_ID);
                });

            migrationBuilder.CreateTable(
                name: "loan",
                columns: table => new
                {
                    Loan_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Max_Loan_Amt = table.Column<float>(nullable: false),
                    ROI = table.Column<float>(nullable: false),
                    Tenure = table.Column<int>(nullable: false),
                    Loan_Amt = table.Column<float>(nullable: false),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loan", x => x.Loan_id);
                });

            migrationBuilder.CreateTable(
                name: "property_Details",
                columns: table => new
                {
                    Propertyid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyLocation = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true),
                    EstimatedAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_Details", x => x.Propertyid);
                });

            migrationBuilder.CreateTable(
                name: "status_Details",
                columns: table => new
                {
                    statusid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(nullable: true),
                    amount = table.Column<float>(nullable: false),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_Details", x => x.statusid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin_Details");

            migrationBuilder.DropTable(
                name: "customer_Details");

            migrationBuilder.DropTable(
                name: "employee_Details");

            migrationBuilder.DropTable(
                name: "loan");

            migrationBuilder.DropTable(
                name: "property_Details");

            migrationBuilder.DropTable(
                name: "status_Details");
        }
    }
}
