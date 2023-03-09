using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrimeHolding.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "WorkTasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "WorkTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "Software Development" },
                    { new Guid("9c232f11-0a60-46fc-95c3-8613488b2d42"), "Human Resource" },
                    { new Guid("d5add2f0-6eaf-492d-9743-a0ee9393693e"), "Accounting" },
                    { new Guid("ea3a1d44-42df-4760-a7e4-0c1f51fdc453"), "Testing" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentId", "Email", "FullName", "MonthlySalary", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("3563bafb-638d-4944-b3a0-3a4ab8b99cc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "AdamSmith@gmail.com", "Adam Smith", 5999.99m, "1234567890" },
                    { new Guid("5910d9cf-52a1-4de4-9662-a5335f5bf506"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "RichardBranson@gmail.com", "Richard Branson", 899.99m, "1234567890" },
                    { new Guid("86fd9feb-3a57-4689-8a2e-dbfccdfb367c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "LeoTolstoy@gmail.com", "Leo Tolstoy", 1499.99m, "1234567890" },
                    { new Guid("ce2405e7-0138-4183-b60e-5800af3e69e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "JaneDoe@gmail.com", "Jane Doe", 1999.99m, "1234567890" },
                    { new Guid("d2d6e078-6fc1-48ab-907b-7232f923654e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "WarrenBuffet@gmail.com", "Warren Buffet", 2999.99m, "1234567890" },
                    { new Guid("dd7a30a2-09ba-4a11-82e5-8823f60cfbd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "JohnDoe@gmail.com", "John Doe", 999.99m, "1234567890" },
                    { new Guid("ee0d8839-1129-4e70-9621-175e200c7900"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"), "CharlesDarwin@gmail.com", "Charles Darwin", 2299.99m, "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "WorkTasks",
                columns: new[] { "Id", "AssigneeId", "Completed", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { new Guid("201e0dc0-fde8-4e68-8f10-ddfa3fc3efb9"), new Guid("ce2405e7-0138-4183-b60e-5800af3e69e4"), false, "Lorem ipsum", new DateTime(1, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("4e8f766f-3eff-4c1a-91b0-a72876d9cf3d"), new Guid("5910d9cf-52a1-4de4-9662-a5335f5bf506"), false, "Lorem ipsum", new DateTime(1, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("82fc3f11-5a91-4ba0-93e0-0d1d3bb2c346"), new Guid("dd7a30a2-09ba-4a11-82e5-8823f60cfbd1"), false, "Lorem ipsum", new DateTime(1, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("832ce9a5-91ad-40da-9a14-51d291e65e4f"), new Guid("dd7a30a2-09ba-4a11-82e5-8823f60cfbd1"), false, "Lorem ipsum", new DateTime(1, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("9e9480df-36d1-4ea5-affc-61828f79d1ad"), new Guid("dd7a30a2-09ba-4a11-82e5-8823f60cfbd1"), false, "Lorem ipsum", new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("bf92b02f-8549-473f-9982-d94db2b66335"), new Guid("5910d9cf-52a1-4de4-9662-a5335f5bf506"), false, "Lorem ipsum", new DateTime(1, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("eba91129-5ca9-42de-a5d0-40d5059078dd"), new Guid("ce2405e7-0138-4183-b60e-5800af3e69e4"), false, "Lorem ipsum", new DateTime(1, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9c232f11-0a60-46fc-95c3-8613488b2d42"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5add2f0-6eaf-492d-9743-a0ee9393693e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ea3a1d44-42df-4760-a7e4-0c1f51fdc453"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3563bafb-638d-4944-b3a0-3a4ab8b99cc5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("86fd9feb-3a57-4689-8a2e-dbfccdfb367c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d2d6e078-6fc1-48ab-907b-7232f923654e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ee0d8839-1129-4e70-9621-175e200c7900"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("201e0dc0-fde8-4e68-8f10-ddfa3fc3efb9"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("4e8f766f-3eff-4c1a-91b0-a72876d9cf3d"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("82fc3f11-5a91-4ba0-93e0-0d1d3bb2c346"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("832ce9a5-91ad-40da-9a14-51d291e65e4f"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("9e9480df-36d1-4ea5-affc-61828f79d1ad"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("bf92b02f-8549-473f-9982-d94db2b66335"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("eba91129-5ca9-42de-a5d0-40d5059078dd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5910d9cf-52a1-4de4-9662-a5335f5bf506"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ce2405e7-0138-4183-b60e-5800af3e69e4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("dd7a30a2-09ba-4a11-82e5-8823f60cfbd1"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("152dad6a-a746-4760-908a-47b3e7c28c61"));

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "WorkTasks");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "WorkTasks");
        }
    }
}
