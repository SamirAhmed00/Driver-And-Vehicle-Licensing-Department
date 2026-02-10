using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications");
            builder.HasKey(a => a.ApplicationID);
            builder.Property(a => a.PaidFees).HasColumnType("decimal(18,2)");
            builder.Property(a => a.ApplicationStatus).HasConversion<short>(); // enApplicationStatus

            builder.HasOne(a => a.Applicant).WithMany().HasForeignKey(a => a.ApplicantPersonID);
            builder.HasOne(a => a.ApplicationType).WithMany(at => at.Applications).HasForeignKey(a => a.ApplicationTypeID);
            builder.HasOne(a => a.CreatedByUser).WithMany().HasForeignKey(a => a.CreatedByUserID);
        }
    }
}
