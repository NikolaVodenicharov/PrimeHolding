﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeHolding.Server.Infrastructure.Constants;
using PrimeHolding.Server.Infrastructure.Entities;

namespace PrimeHolding.Server.Infrastructure.EntityTypeConfigurations
{
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
}