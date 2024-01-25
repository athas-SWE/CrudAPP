using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_EMPLOYEE.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
