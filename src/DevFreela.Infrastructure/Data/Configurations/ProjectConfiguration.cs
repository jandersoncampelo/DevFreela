﻿using DevFreela.Domain.Projects.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Data.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
               .ValueGeneratedOnAdd();
        
        builder.Property(p => p.Title)
               .HasMaxLength(50).IsRequired();

        builder.Property(p => p.TotalCost)
               .HasPrecision(18, 2);

        builder.HasOne(p => p.Freelancer)
               .WithMany(f => f.FreelancerProjects)
               .HasForeignKey(p => p.IdFreelancer)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Client)
               .WithMany(f => f.OwnedProjects)
               .HasForeignKey(p => p.IdClient)
               .OnDelete(DeleteBehavior.Restrict);


    }
}
