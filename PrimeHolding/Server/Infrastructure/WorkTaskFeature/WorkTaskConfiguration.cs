using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeHolding.Server.Core.WorkTaskFeature.Entities;
using PrimeHolding.Server.Core.WorkTaskFeature.Support;

namespace PrimeHolding.Server.Infrastructure.WorkTaskFeature;

public class WorkTaskConfiguration : IEntityTypeConfiguration<WorkTask>
{
    public void Configure(EntityTypeBuilder<WorkTask> builder)
    {
        builder
            .HasKey(wt => wt.Id);

        builder
            .Property(wt => wt.Title)
            .IsRequired()
            .HasMaxLength(WorkTaskConstants.TitleMaxLength);

        builder
            .Property(wt => wt.Description)
            .IsRequired()
            .HasMaxLength(WorkTaskConstants.DescriptionMaxLength);

        builder
            .Property(wt => wt.DueDate)
            .IsRequired();

        builder
            .Property(wt => wt.Completed)
            .IsRequired();

        builder
            .HasOne(wt => wt.Assignee)
            .WithMany(e => e.WorkTasks)
            .HasForeignKey(wt => wt.AssigneeId);
    }
}
