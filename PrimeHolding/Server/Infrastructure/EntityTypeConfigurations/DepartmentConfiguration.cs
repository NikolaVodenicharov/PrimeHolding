using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeHolding.Server.Core.DepartmentFeature.Entities;
using PrimeHolding.Server.Core.DepartmentFeature.Support;

namespace PrimeHolding.Server.Infrastructure.EntityTypeConfigurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(DepartmentConstants.NameMaxLenght);
        }
    }
}
