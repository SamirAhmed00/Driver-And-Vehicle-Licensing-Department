using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class InternationalLicenseConfiguration : IEntityTypeConfiguration<InternationalLicense>
    {
        public void Configure(EntityTypeBuilder<InternationalLicense> builder)
        {
            builder.ToTable("InternationalLicenses");
            builder.HasKey(il => il.InternationalLicenseID);

            builder.HasOne(il => il.Driver).WithMany(d => d.InternationalLicenses).HasForeignKey(il => il.DriverID);
            builder.HasOne(il => il.LocalLicense).WithMany().HasForeignKey(il => il.IssuedUsingLocalLicenseID);
        }
    }
}
