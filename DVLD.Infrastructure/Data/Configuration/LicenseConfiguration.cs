using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class LicenseConfiguration : IEntityTypeConfiguration<License>
    {
        public void Configure(EntityTypeBuilder<License> builder)
        {
            builder.ToTable("Licenses");
            builder.HasKey(l => l.LicenseID);
            builder.Property(l => l.PaidFees).HasColumnType("decimal(18,2)");
            builder.Property(l => l.enIssueReason).HasConversion<byte>();

            builder.HasOne(l => l.Driver).WithMany(d => d.Licenses).HasForeignKey(l => l.DriverID);
            builder.HasOne(l => l.LicenseClass).WithMany(lc => lc.Licenses).HasForeignKey(l => l.LicenseClassID);
        }
    }
}
