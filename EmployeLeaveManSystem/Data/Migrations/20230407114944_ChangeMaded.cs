﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeLeaveManSystem.Data.Migrations
{
    public partial class ChangeMaded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultDays",
                table: "LeaveTypeVM",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultDays",
                table: "LeaveTypeVM");
        }
    }
}
