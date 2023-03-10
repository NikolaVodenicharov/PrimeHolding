using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrimeHolding.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NullableForeightKeyOfWorkTaskToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTasks_Employees_AssigneeId",
                table: "WorkTasks");

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
                    { new Guid("3f6662bd-7aa5-405a-88c4-f0f278e424e0"), "Human Resource" },
                    { new Guid("5ffe80f0-d6da-48c6-ae5b-5302faf2925e"), "Testing" },
                    { new Guid("9555923e-5bfc-4089-83a8-ea2cc7894821"), "Accounting" },
                    { new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "Software Development" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentId", "Email", "FullName", "MonthlySalary", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("08a83b44-af87-4e1e-8fc6-40fdbd78ee8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "WarrenBuffet@gmail.com", "Warren Buffet", 2999.99m, "1234567890" },
                    { new Guid("338142b5-9ac3-4d27-a72c-ad3a4fbc86c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "AdamSmith@gmail.com", "Adam Smith", 5999.99m, "1234567890" },
                    { new Guid("3caf25d7-8621-4d7b-b6c7-02f2a7fe03cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "JaneDoe@gmail.com", "Jane Doe", 1999.99m, "1234567890" },
                    { new Guid("5e7349a3-4299-41b3-babb-3845c2c31650"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "JohnDoe@gmail.com", "John Doe", 999.99m, "1234567890" },
                    { new Guid("7957bdc4-37c9-4109-ac7e-744f485442db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "RichardBranson@gmail.com", "Richard Branson", 899.99m, "1234567890" },
                    { new Guid("9e43a78c-1fa3-494d-9610-ea9074e01e59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "CharlesDarwin@gmail.com", "Charles Darwin", 2299.99m, "1234567890" },
                    { new Guid("f96e5ed7-2c0a-4838-8fba-4ca7fcc96a2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"), "LeoTolstoy@gmail.com", "Leo Tolstoy", 1499.99m, "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "WorkTasks",
                columns: new[] { "Id", "AssigneeId", "Completed", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { new Guid("2bd1400e-5caa-4845-9ad0-ad12c9c064d5"), new Guid("3caf25d7-8621-4d7b-b6c7-02f2a7fe03cc"), false, "Lorem ipsum", new DateTime(1, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work4" },
                    { new Guid("709b579f-ebb5-45d2-b327-2fb53376f0b6"), new Guid("5e7349a3-4299-41b3-babb-3845c2c31650"), false, "Lorem ipsum", new DateTime(1, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work3" },
                    { new Guid("74ef45f5-f42c-4294-893a-ad6e0e2d948c"), new Guid("5e7349a3-4299-41b3-babb-3845c2c31650"), false, "Lorem ipsum", new DateTime(1, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work2" },
                    { new Guid("76463beb-db7e-40a4-899a-f9d2fde8062c"), new Guid("3caf25d7-8621-4d7b-b6c7-02f2a7fe03cc"), false, "Lorem ipsum", new DateTime(1, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work5" },
                    { new Guid("7b7149eb-d741-4e24-ba35-21c2de62af7e"), new Guid("5e7349a3-4299-41b3-babb-3845c2c31650"), false, "Lorem ipsum", new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("b399fd16-d0d6-4575-9a91-aad94e5fe528"), new Guid("7957bdc4-37c9-4109-ac7e-744f485442db"), false, "Lorem ipsum", new DateTime(1, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work7" },
                    { new Guid("e8ec89b9-04f8-48e7-9b2c-4f9f9a0cf65f"), new Guid("7957bdc4-37c9-4109-ac7e-744f485442db"), false, "Lorem ipsum", new DateTime(1, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work6" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTasks_Employees_AssigneeId",
                table: "WorkTasks",
                column: "AssigneeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTasks_Employees_AssigneeId",
                table: "WorkTasks");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f6662bd-7aa5-405a-88c4-f0f278e424e0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5ffe80f0-d6da-48c6-ae5b-5302faf2925e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9555923e-5bfc-4089-83a8-ea2cc7894821"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("08a83b44-af87-4e1e-8fc6-40fdbd78ee8f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("338142b5-9ac3-4d27-a72c-ad3a4fbc86c2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9e43a78c-1fa3-494d-9610-ea9074e01e59"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f96e5ed7-2c0a-4838-8fba-4ca7fcc96a2c"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("2bd1400e-5caa-4845-9ad0-ad12c9c064d5"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("709b579f-ebb5-45d2-b327-2fb53376f0b6"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("74ef45f5-f42c-4294-893a-ad6e0e2d948c"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("76463beb-db7e-40a4-899a-f9d2fde8062c"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("7b7149eb-d741-4e24-ba35-21c2de62af7e"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("b399fd16-d0d6-4575-9a91-aad94e5fe528"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("e8ec89b9-04f8-48e7-9b2c-4f9f9a0cf65f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3caf25d7-8621-4d7b-b6c7-02f2a7fe03cc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5e7349a3-4299-41b3-babb-3845c2c31650"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7957bdc4-37c9-4109-ac7e-744f485442db"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e1f9e884-5205-4098-8ea9-d1d77600a9e9"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTasks_Employees_AssigneeId",
                table: "WorkTasks",
                column: "AssigneeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
