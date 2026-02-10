using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class TestTypeConfiguration : IEntityTypeConfiguration<TestType>
    {
        public void Configure(EntityTypeBuilder<TestType> builder)
        {
            builder.ToTable("TestTypes");
            builder.HasKey(tt => tt.TestTypeID);
            builder.Property(tt => tt.TestTypeFees).HasColumnType("decimal(18,2)");
        }
    }
}
