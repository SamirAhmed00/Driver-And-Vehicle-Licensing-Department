using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("Drivers");
            builder.HasKey(d => d.DriverID);

            builder.HasOne(d => d.Person).WithOne(p => p.Driver).HasForeignKey<Driver>(d => d.PersonID);
            builder.HasOne(d => d.CreatedByUser).WithMany().HasForeignKey(d => d.CreatedByUserID);
        }
    }
}
