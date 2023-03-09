using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeHolding.Server.Infrastructure.Constants;
using PrimeHolding.Server.Infrastructure.Entities;
using System.Reflection.Emit;

namespace PrimeHolding.Server.Infrastructure.EntityTypeConfigurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(EmployeeConstants.FullNameMaxLenght);

            builder
                .Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(EmployeeConstants.EmailMaxLenght);


            builder
                .Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(EmployeeConstants.PhoneNumberMaxLenght);


            builder
                .Property(e => e.DateOfBirth)
                .IsRequired();


            builder
                .Property(e => e.MonthlySalary)
                .IsRequired()
                .HasPrecision(18,2);

            builder
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}
