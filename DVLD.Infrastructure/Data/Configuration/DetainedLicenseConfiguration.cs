using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class DetainedLicenseConfiguration : IEntityTypeConfiguration<DetainedLicense>
    {
        public void Configure(EntityTypeBuilder<DetainedLicense> builder)
        {
            builder.ToTable("DetainedLicenses");
            builder.HasKey(dl => dl.DetainID);
            builder.Property(dl => dl.FineFees).HasColumnType("decimal(18,2)");

            builder.HasOne(dl => dl.License).WithOne(l => l.DetainedLicense).HasForeignKey<DetainedLicense>(dl => dl.LicenseID);
        }
    }
}
