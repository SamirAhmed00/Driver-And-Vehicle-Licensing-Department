using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class ApplicationTypeConfiguration : IEntityTypeConfiguration<ApplicationType>
    {
        public void Configure(EntityTypeBuilder<ApplicationType> builder)
        {
            builder.ToTable("ApplicationTypes");
            builder.HasKey(at => at.ApplicationTypeID);
            builder.Property(at => at.ApplicationFees).HasColumnType("decimal(18,2)");
        }
    }
}
