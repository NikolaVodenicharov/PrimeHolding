using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrimeHolding.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NonNullableForeighKeyInWorkTask : Migration
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
                    { new Guid("05a423bd-cafb-425e-8ec2-3d4033efb5ea"), "Human Resource" },
                    { new Guid("2f32540c-aa12-4046-aac6-30f9827d32b2"), "Testing" },
                    { new Guid("81cd087e-e2a8-4e6f-a67a-d79b45f328f0"), "Accounting" },
                    { new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "Software Development" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentId", "Email", "FullName", "MonthlySalary", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("1717d7eb-4478-4249-b5c1-85aa450b2905"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "CharlesDarwin@gmail.com", "Charles Darwin", 2299.99m, "1234567890" },
                    { new Guid("2b5717b6-76d8-404e-92c4-ba4da7df7fad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "LeoTolstoy@gmail.com", "Leo Tolstoy", 1499.99m, "1234567890" },
                    { new Guid("71b95131-dc0e-4f64-b91a-c2911f1f55c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "AdamSmith@gmail.com", "Adam Smith", 5999.99m, "1234567890" },
                    { new Guid("a0741b83-0cf2-4c98-98ad-edd4b5e88d15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "JaneDoe@gmail.com", "Jane Doe", 1999.99m, "1234567890" },
                    { new Guid("bd4b5ebd-60bf-40c5-ae6e-65cbc73c8c31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "JohnDoe@gmail.com", "John Doe", 999.99m, "1234567890" },
                    { new Guid("d648588d-37d8-498a-9568-fefd945ce57c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "RichardBranson@gmail.com", "Richard Branson", 899.99m, "1234567890" },
                    { new Guid("d8525d95-5332-4807-8ae1-6f9320cad620"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"), "WarrenBuffet@gmail.com", "Warren Buffet", 2999.99m, "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "WorkTasks",
                columns: new[] { "Id", "AssigneeId", "Completed", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0ecf61df-7b1d-4782-815a-049fca061f88"), new Guid("d648588d-37d8-498a-9568-fefd945ce57c"), false, "Lorem ipsum", new DateTime(1, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work7" },
                    { new Guid("2a70e355-0251-403e-b513-cbf7f588330e"), new Guid("bd4b5ebd-60bf-40c5-ae6e-65cbc73c8c31"), false, "Lorem ipsum", new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work1" },
                    { new Guid("5c37e614-cfb9-4e2f-8c16-8e3626218116"), new Guid("bd4b5ebd-60bf-40c5-ae6e-65cbc73c8c31"), false, "Lorem ipsum", new DateTime(1, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work3" },
                    { new Guid("62c01a71-a7f1-405b-b5d2-72feb15d3fe1"), new Guid("bd4b5ebd-60bf-40c5-ae6e-65cbc73c8c31"), false, "Lorem ipsum", new DateTime(1, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work2" },
                    { new Guid("7acce4a2-712e-40b3-a80d-e1a4d8efeffa"), new Guid("a0741b83-0cf2-4c98-98ad-edd4b5e88d15"), false, "Lorem ipsum", new DateTime(1, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work5" },
                    { new Guid("b6a7af06-ca19-4448-a2e5-c733d7ba18b6"), new Guid("a0741b83-0cf2-4c98-98ad-edd4b5e88d15"), false, "Lorem ipsum", new DateTime(1, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work4" },
                    { new Guid("d0319a4a-862a-4594-a8bd-5bf0e7719ea8"), new Guid("d648588d-37d8-498a-9568-fefd945ce57c"), false, "Lorem ipsum", new DateTime(1, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work6" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTasks_Employees_AssigneeId",
                table: "WorkTasks",
                column: "AssigneeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                keyValue: new Guid("05a423bd-cafb-425e-8ec2-3d4033efb5ea"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2f32540c-aa12-4046-aac6-30f9827d32b2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("81cd087e-e2a8-4e6f-a67a-d79b45f328f0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1717d7eb-4478-4249-b5c1-85aa450b2905"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2b5717b6-76d8-404e-92c4-ba4da7df7fad"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("71b95131-dc0e-4f64-b91a-c2911f1f55c9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d8525d95-5332-4807-8ae1-6f9320cad620"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("0ecf61df-7b1d-4782-815a-049fca061f88"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("2a70e355-0251-403e-b513-cbf7f588330e"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("5c37e614-cfb9-4e2f-8c16-8e3626218116"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("62c01a71-a7f1-405b-b5d2-72feb15d3fe1"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("7acce4a2-712e-40b3-a80d-e1a4d8efeffa"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("b6a7af06-ca19-4448-a2e5-c733d7ba18b6"));

            migrationBuilder.DeleteData(
                table: "WorkTasks",
                keyColumn: "Id",
                keyValue: new Guid("d0319a4a-862a-4594-a8bd-5bf0e7719ea8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a0741b83-0cf2-4c98-98ad-edd4b5e88d15"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bd4b5ebd-60bf-40c5-ae6e-65cbc73c8c31"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d648588d-37d8-498a-9568-fefd945ce57c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("99d83d4b-bba7-4390-99c4-bb3997146da4"));

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
    }
}
