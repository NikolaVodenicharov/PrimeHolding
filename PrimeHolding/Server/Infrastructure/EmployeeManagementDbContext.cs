using Microsoft.EntityFrameworkCore;
using PrimeHolding.Server.Core.DepartmentFeature.Entities;
using PrimeHolding.Server.Core.EmployeeFeature.Entities;
using PrimeHolding.Server.Core.WorkTaskFeature.Entities;
using System.Reflection;

namespace PrimeHolding.Server.Infrastructure
{
    public class EmployeeManagementDbContext : DbContext
    {
        public EmployeeManagementDbContext(DbContextOptions<EmployeeManagementDbContext> options) 
            : base(options) 
        {
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<WorkTask> WorkTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seed(modelBuilder);
        }

        private static void Seed(ModelBuilder modelBuilder)
        {
            var departmentIds = new List<Guid>()
            { 
                Guid.NewGuid(), 
                Guid.NewGuid(), 
                Guid.NewGuid(),
                Guid.NewGuid() 
            };

            var employeeIds = new List<Guid>()
            {
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid()
            };

            SeedDepartments(modelBuilder, departmentIds);

            SeedEmployees(modelBuilder, departmentIds, employeeIds);

            SeedWorkTasks(modelBuilder, employeeIds);
        }

        private static void SeedDepartments(ModelBuilder modelBuilder, List<Guid> departmentIds)
        {
            modelBuilder
                .Entity<Department>()
                .HasData(new Department
                {
                    Id = departmentIds[0],
                    Name = "Software Development"
                });

            modelBuilder
                .Entity<Department>()
                .HasData(new Department
                {
                    Id = departmentIds[1],
                    Name = "Testing"
                });

            modelBuilder
                .Entity<Department>()
                .HasData(new Department
                {
                    Id = departmentIds[2],
                    Name = "Accounting"
                });

            modelBuilder
                .Entity<Department>()
                .HasData(new Department
                {
                    Id = departmentIds[3],
                    Name = "Human Resource"
                });
        }

        private static void SeedEmployees(ModelBuilder modelBuilder, List<Guid> departmentIds, List<Guid> employeeIds)
        {
            modelBuilder
                .Entity<Employee>()
                .HasData(new Employee
                {
                    Id = employeeIds[0],
                    FullName = "John Doe",
                    Email = "JohnDoe@gmail.com",
                    PhoneNumber= "1234567890",
                    DateOfBirth = new DateTime(),
                    MonthlySalary = 999.99M,
                    DepartmentId = departmentIds[0]
                });

            modelBuilder
                .Entity<Employee>()
                .HasData(new Employee
                {
                    Id = employeeIds[1],
                    FullName = "Jane Doe",
                    Email = "JaneDoe@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(),
                    MonthlySalary = 1999.99M,
                    DepartmentId = departmentIds[0]
                });

            modelBuilder
                .Entity<Employee>()
                .HasData(new Employee
                {
                    Id = employeeIds[2],
                    FullName = "Richard Branson",
                    Email = "RichardBranson@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(),
                    MonthlySalary = 899.99M,
                    DepartmentId = departmentIds[0]
                });

            modelBuilder
                .Entity<Employee>()
                .HasData(new Employee
                {
                    Id = employeeIds[3],
                    FullName = "Adam Smith",
                    Email = "AdamSmith@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(),
                    MonthlySalary = 5999.99M,
                    DepartmentId = departmentIds[0]
                });

            modelBuilder
                .Entity<Employee>()
                .HasData(new Employee
                {
                    Id = employeeIds[4],
                    FullName = "Warren Buffet",
                    Email = "WarrenBuffet@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(),
                    MonthlySalary = 2999.99M,
                    DepartmentId = departmentIds[0]
                });

            modelBuilder
                .Entity<Employee>()
                .HasData(new Employee
                {
                    Id = employeeIds[5],
                    FullName = "Leo Tolstoy",
                    Email = "LeoTolstoy@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(),
                    MonthlySalary = 1499.99M,
                    DepartmentId = departmentIds[0]
                });

            modelBuilder
                .Entity<Employee>()
                .HasData(new Employee
                {
                    Id = employeeIds[6],
                    FullName = "Charles Darwin",
                    Email = "CharlesDarwin@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(),
                    MonthlySalary = 2299.99M,
                    DepartmentId = departmentIds[0]
                });
        }

        private static void SeedWorkTasks(ModelBuilder modelBuilder, List<Guid> employeeIds)
        {
            modelBuilder
                .Entity<WorkTask>()
                .HasData(new WorkTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Work1",
                    Description = "Lorem ipsum",
                    DueDate = new DateTime().AddDays(10),
                    Completed = false,
                    AssigneeId= employeeIds[0]
                });

            modelBuilder
                .Entity<WorkTask>()
                .HasData(new WorkTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Work2",
                    Description = "Lorem ipsum",
                    DueDate = new DateTime().AddDays(44),
                    Completed = false,
                    AssigneeId = employeeIds[0]
                });

            modelBuilder
                .Entity<WorkTask>()
                .HasData(new WorkTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Work3",
                    Description = "Lorem ipsum",
                    DueDate = new DateTime().AddDays(28),
                    Completed = false,
                    AssigneeId = employeeIds[0]
                });

            modelBuilder
                .Entity<WorkTask>()
                .HasData(new WorkTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Work4",
                    Description = "Lorem ipsum",
                    DueDate = new DateTime().AddDays(16),
                    Completed = false,
                    AssigneeId = employeeIds[1]
                });

            modelBuilder
                .Entity<WorkTask>()
                .HasData(new WorkTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Work5",
                    Description = "Lorem ipsum",
                    DueDate = new DateTime().AddDays(50),
                    Completed = false,
                    AssigneeId = employeeIds[1]
                });

            modelBuilder
                .Entity<WorkTask>()
                .HasData(new WorkTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Work6",
                    Description = "Lorem ipsum",
                    DueDate = new DateTime().AddDays(30),
                    Completed = false,
                    AssigneeId = employeeIds[2]
                });

            modelBuilder
                .Entity<WorkTask>()
                .HasData(new WorkTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Work7",
                    Description = "Lorem ipsum",
                    DueDate = new DateTime().AddDays(20),
                    Completed = false,
                    AssigneeId = employeeIds[2]
                });
        }
    }
}
