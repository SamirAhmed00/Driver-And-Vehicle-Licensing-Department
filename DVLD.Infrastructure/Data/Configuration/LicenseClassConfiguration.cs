using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class LicenseClassConfiguration : IEntityTypeConfiguration<LicenseClass>
    {
        public void Configure(EntityTypeBuilder<LicenseClass> builder)
        {
            builder.ToTable("LicenseClasses");
            builder.HasKey(lc => lc.LicenseClassID);
            builder.Property(lc => lc.ClassFees).HasColumnType("decimal(18,2)");
        }
    }
}
