using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrimeHolding.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTitlesOfSeededWorkTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2f5b9d91-1a62-444a-82f8-b26b3c53680b"), "Testing" },
                    { new Guid("751ec32c-1534-45a1-953b-6a080f6394d4"), "Accounting" },
                    { new Guid("83a2a2be-7031-45af-8ce8-145a6e2e68ad"), "Human Resource" },
                    { new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "Software Development" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentId", "Email", "FullName", "MonthlySalary", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("1a64b2a6-b4db-43fb-b25b-6299a041e4d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "WarrenBuffet@gmail.com", "Warren Buffet", 2999.99m, "1234567890" },
                    { new Guid("370341a0-4478-4138-9d7b-2cca08678c6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "CharlesDarwin@gmail.com", "Charles Darwin", 2299.99m, "1234567890" },
                    { new Guid("5622a2eb-9a38-454b-86f9-9384db98695a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "AdamSmith@gmail.com", "Adam Smith", 5999.99m, "1234567890" },
                    { new Guid("86e06955-1ecd-4d11-a248-67c57b5f6339"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "JohnDoe@gmail.com", "John Doe", 999.99m, "1234567890" },
                    { new Guid("b3327152-4ae6-4068-86b4-1f9ecf3f59ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "RichardBranson@gmail.com", "Richard Branson", 899.99m, "1234567890" },
                    { new Guid("dcf7d38a-dcda-4b1f-aab2-dcec1704cf05"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "LeoTolstoy@gmail.com", "Leo Tolstoy", 1499.99m, "1234567890" },
                    { new Guid("fcfa58e2-4f24-4d71-95c2-c3c2cae00d85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"), "JaneDoe@gmail.com", "Jane Doe", 1999.99m, "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "WorkTasks",
                columns: new[] { "Id", "AssigneeId", "Completed", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0b04f496-91f7-4407-a05c-fe1788efe253"), new Guid("86e06955-1ecd-4d11-a248-67c57b5f6339"), false, "Lorem ipsum", new DateTime(1, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work3" },
                    { new Guid("11bdf56d-d619-40ab-9245-b3f329509f0e"), new Guid("86e06955-1ecd-4d11-a248-67c57b5f6339"), false, "Lorem ipsum", new DateTime(1, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work2" },
                    { new Guid("67aee09e-f6a0-474b-88b5-154c2295d282"), new Guid("b3327152-4ae6-4068-86b4-1f9ecf3f59ad"), false, "Lorem ipsum", new DateTime(1, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work6" },
                    { new Guid("7dc8ef73-830a-44cb-9a10-33b74f7ffb02"), new Guid("b3327152-4ae6-4068-86b4-1f9ecf3f59ad"), false, "Lorem ipsum", new DateTime(1, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work7" },
                    { new Guid("8e96605b-d107-4110-a3cd-5a6b00e483da"), new Guid("fcfa58e2-4f24-4d71-95c2-c3c2cae00d85"), false, "Lorem ipsum", new DateTime(1, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work4" },
                    { new Guid("95cb82ca-924b-4c94-9e59-7e0bee85d97e"), new Guid("86e06955-1ecd-4d11-a248-67c57b5f6339"), false, "Lorem ipsum", new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("e0ef9124-317e-4bcd-a6a6-d0b5c8e3ab20"), new Guid("fcfa58e2-4f24-4d71-95c2-c3c2cae00d85"), false, "Lorem ipsum", new DateTime(1, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2f5b9d91-1a62-444a-82f8-b26b3c53680b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("751ec32c-1534-45a1-953b-6a080f6394d4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("83a2a2be-7031-45af-8ce8-145a6e2e68ad"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1a64b2a6-b4db-43fb-b25b-6299a041e4d3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("370341a0-4478-4138-9d7b-2cca08678c6f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5622a2eb-9a38-454b-86f9-9384db98695a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("dcf7d38a-dcda-4b1f-aab2-dcec1704cf05"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("0b04f496-91f7-4407-a05c-fe1788efe253"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("11bdf56d-d619-40ab-9245-b3f329509f0e"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("67aee09e-f6a0-474b-88b5-154c2295d282"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("7dc8ef73-830a-44cb-9a10-33b74f7ffb02"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("8e96605b-d107-4110-a3cd-5a6b00e483da"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("95cb82ca-924b-4c94-9e59-7e0bee85d97e"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("e0ef9124-317e-4bcd-a6a6-d0b5c8e3ab20"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("86e06955-1ecd-4d11-a248-67c57b5f6339"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b3327152-4ae6-4068-86b4-1f9ecf3f59ad"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fcfa58e2-4f24-4d71-95c2-c3c2cae00d85"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9c4197ff-5390-46d1-84f9-eb07cb18452e"));

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
    }
}
