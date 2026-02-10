using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class LocalDrivingLicenseApplicationConfiguration : IEntityTypeConfiguration<LocalDrivingLicenseApplication>
    {
        public void Configure(EntityTypeBuilder<LocalDrivingLicenseApplication> builder)
        {
            builder.ToTable("LocalDrivingLicenseApplications");
            builder.HasKey(l => l.LocalDrivingLicenseApplicationID);

            builder.HasOne(l => l.Application)
                   .WithOne(a => a.LocalDrivingLicenseApplication)
                   .HasForeignKey<LocalDrivingLicenseApplication>(l => l.ApplicationID);

            builder.HasOne(l => l.LicenseClass)
                   .WithMany(lc => lc.LocalDrivingLicenseApplications)
                   .HasForeignKey(l => l.LicenseClassID);
        }
    }
}
